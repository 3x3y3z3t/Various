## TimeMachine
A small program to fling your machine to the past (or to the future) and then fling back to present after a short while.

(Actually it changes the system time by a specified amount and changes back to present time.)

### Version
v1.1.0

### How To Build
You can build TimeMachine in using Visual Studio. TimeMachine is built on .NET 6.

### How To Run
You need to run TimeMachine with Administrator privilege. 

Actually admin privilege is not strictly necessary, it only requires `SE_SYSTEMTIME_NAME` privilege, or `SeSystemtimePrivilege` to be able to change system time.
If you can grant the program this privilege, admin is not necessary.
