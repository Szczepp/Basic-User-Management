## This is a small task made during the remote internship
User Managment panel with authentication

## Requirements
Create a Web application with registration and authentication. <br>
Non-authenticated users should not have access to the user management (admin panel).
Authenticated users should have access the user management table: 
* id, 
* name, 
* e-mail, 
* last login time, 
* registration time, 
* status (active/blocked).
<br> <br>
The left column of the table should contains checkboxes without labels for multiple selection (table header contains `Select All` checkbox without label). <br>
There must be a toolbar over the table with the flooring actions: `Block` (red button with text), `Unblock` (icon), `Delete` (icon).<br>
Every users should be able to block or delete yourself or any other user. <br>
If user account is blocked or deleted any next user’s request should redirect to the login page. <br>
User can use any non-empty password (even one character).<br>
Blocked user should not be able to login, deleted user can re-register.
