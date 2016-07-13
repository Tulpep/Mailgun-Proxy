# Mailgun-Proxy
Simple .NET proxy to the Mailgun API

Ready to use on Azure or on premise this .NET API take HTTP Posts requests and send them via email using Mailgun.
It fully supports CORS. Using it you dont need to reveal your Mailgun API in your websites or javascript applications.

This proxy is mantain for us because it is used in the contact forms of several of our websites.
If you have any question just create a issue. If you want to make some changes we are open to Pull Requests! :smile:

These are the settings available in this project:

|  APP SETTING       |     Function                                                            |
| ------------------ | ----------------------------------------------------------------------- |
| MAILGUN_API_KEY    | Secret API Key of Mailgun                                               |
| MAILGUN_DOMAIN     | Sender domain approved in Mailgun                                       |
| FROM               | Email address of the sender                                             |
| TO                 | Email address of the recepient                                          |
| CORS_ORIGINS       | Comma separated urls of the allowed websites to use the service via AJAX|
| CORS_HEADERS       | Allowed Headers in AJAX. If not sure use  `*`                           |
| CORS_METHODS       | Comma separated HTTP methods to be use via AJAX. ie. `get,post`         |

