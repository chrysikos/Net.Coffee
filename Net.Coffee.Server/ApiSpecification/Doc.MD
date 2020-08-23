# rJes


## What is? 
**rJes** is a specification which defines some rules how JSON responses should be structured.Is designed to give you a consistent format in order to help consume your api easily.


## Simple Rules
rJes, types responses :

<table>
<tr><th>Type</td><th>Description</th><th>Required Keys</th><th>Optional Keys</td></tr>
<tr><td>success</td><td>All went well, and some data was returned.</td><td>status </td><td>messsage, data</td></tr>
<tr><td>fail</td><td>There was a problem with the data submitted, or some pre-condition (infrastructure) of the API call wasn't satisfied</td><td>status, data, message</td><td></td></tr>
<tr><td>error</td><td>An error occurred in processing the request, i.e. an exception was thrown</td><td>status, message,code, data</td><td></td></tr>
</table>

## Example response types 

### Success

#### Status Codes

##### 200 (OK)
It indicates that the REST API successfully carried out whatever action the client requested and that no more specific code in the 2xx series is appropriate.
Unlike the 204 status code, a 200 response should include a response body.The information returned with the response is dependent on the method used in the request, for example:
GET an entity corresponding to the requested resource is sent in the response;
HEAD the entity-header fields corresponding to the requested resource are sent in the response without any message-body;
POST an entity describing or containing the result of the action;
TRACE an entity containing the request message as received by the end server.

##### 201 (Created)
A responds with the 201 status code whenever a resource is created inside a collection. There may also be times when a new resource is created as a result of some controller action, in which case 201 would also be an appropriate response.
The newly created resource can be referenced by the URI(s) returned in the entity of the response, with the most specific URI for the resource given by a Location header field.
The origin server MUST create the resource before returning the 201 status code. If the action cannot be carried out immediately, the server SHOULD respond with a 202 (Accepted) response instead.

##### 202 (Accepted)
A 202 response is typically used for actions that take a long while to process. It indicates that the request has been accepted for processing, but the processing has not been completed. The request might or might not be eventually acted upon, or even maybe disallowed when processing occurs.
Its purpose is to allow a server to accept a request for some other process (perhaps a batch-oriented process that is only run once per day) without requiring that the user agent’s connection to the server persist until the process is completed.
The entity returned with this response SHOULD include an indication of the request’s current status and either a pointer to a status monitor (job queue location) or some estimate of when the user can expect the request to be fulfilled.

##### 204 (No Content)
The 204 status code is usually sent out in response to a PUT, POST, or DELETE request when the API declines to send back any status message or representation in the response message’s body.
An API may also send 204 in conjunction with a GET request to indicate that the requested resource exists, but has no state representation to include in the body.
If the client is a user agent, it SHOULD NOT change its document view from that which caused the request to be sent. This response is primarily intended to allow input for actions to take place without causing a change to the user agent’s active document view, although any new or updated metainformation SHOULD be applied to the document currently in the user agent’s active view.
The 204 response MUST include only status and messsage fields.

#### Examples
When an API call is successful, the rJes object is used as a simple envelope for the results, using the data key, as in the following:

#### GET /Customer:
```
{
    status : "success",
    message : "",
    data : [
            { "Id" : 1, "FirstName" : "Efstathios", "Lastname" : "Chrysikos" },
            { "Id" : 2, "FirstName" : "Kostas", "Lastname" : "Dimitropoulos" },
        ]
     }
}
```
#### GET GET /Customer/1:
```
{
    status : "success",
    message : "",
    data : { "Id" : 1, "FirstName" : "Efstathios", "Lastname" : "Chrysikos" }
}
```
#### DELETE /Customer/2:
```
{
    status : "success",
    message : "",
    data : null
}
```
Required keys:

* status: Should always be set to "success".
* data: Acts as the wrapper for any data returned by the API call. If the call returns no data (as in the last example), data should be set to null.

### Fail (Business Rules)
#### Status Codes

##### 400 (Bad Request)
400 is the generic client-side error status, used when no other 4xx error code is appropriate. Errors can be like malformed request syntax, invalid request message parameters, or deceptive request routing etc.
The client SHOULD NOT repeat the request without modifications.

##### 401 (Unauthorized)
A 401 error response indicates that the client tried to operate on a protected resource without providing the proper authorization. It may have provided the wrong credentials or none at all. The response must include a WWW-Authenticate header field containing a challenge applicable to the requested resource.
The client MAY repeat the request with a suitable Authorization header field. If the request already included Authorization credentials, then the 401 response indicates that authorization has been refused for those credentials. If the 401 response contains the same challenge as the prior response, and the user agent has already attempted authentication at least once, then the user SHOULD be presented the entity that was given in the response, since that entity might include relevant diagnostic information.

##### 403 (Forbidden)
A 403 error response indicates that the client’s request is formed correctly, but the REST API refuses to honor it, i.e. the user does not have the necessary permissions for the resource. A 403 response is not a case of insufficient client credentials; that would be 401 (“Unauthorized”).
Authentication will not help, and the request SHOULD NOT be repeated. Unlike a 401 Unauthorized response, authenticating will make no difference.

##### 404 (Not Found)
The 404 error status code indicates that the REST API can’t map the client’s URI to a resource but may be available in the future. Subsequent requests by the client are permissible.
No indication is given of whether the condition is temporary or permanent.  This status code is commonly used when the server does not wish to reveal exactly why the request has been refused, or when no other response is applicable.

### Examples
When an API call is rejected due to invalid data or call conditions, the rJes object's data key contains an object explaining what went wrong, typically a hash of validation errors. For example:

#### POST Customer (with data body: "Trying to creating a Customer"): ####
```
{
    "status" : "fail",
    "message" : "Failed to create a customer.",
    "data" : [
              { "message": "FirstName is required" },
              { "message": "LastName is required" },
	]
}
```
Required keys:

* status: Should always be set to "fail".
* data: Again, provides the wrapper for the details of why the request failed. If the reasons for failure correspond to POST values, the response object's keys SHOULD correspond to those POST values.

### Error (Unhandled Exception, Internal Errors) ### 

#### Status Codes

##### 500 (Internal Server Error)
500 is the generic REST API error response. Most web frameworks automatically respond with this response status code whenever they execute some request handler code that raises an exception.
A 500 error is never the client’s fault, and therefore, it is reasonable for the client to retry the same request that triggered this response and hope to get a different response.
API response is the generic error message, given when an unexpected condition was encountered and no more specific message is suitable.

##### 501 (Not Implemented)
The server either does not recognize the request method, or it lacks the ability to fulfill the request. Usually, this implies future availability (e.g., a new feature of a web-service API).

### Examples
When an API call fails due to an error on the server. For example:
#### GET /Customer: ####
```
{
    "status" : "error",
    "message" : "Unable to communicate with database",
    "code" : "1300",
    "data" : ""
}
```
Required keys:
* status: Should always be set to "error".
* message: A meaningful, end-user-readable (or at the least log-worthy) message, explaining what went wrong.

Optional keys:
* code: A numeric code corresponding to the error, if applicable
* data: A generic container for any other information about the error, i.e. the conditions that caused the error, stack traces, etc.



