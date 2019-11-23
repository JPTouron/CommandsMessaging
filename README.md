
# CommandsMessaging
Sample code to just try and see how to organize a command based messaging approach using cqrs concepts as commands + commandhandlers

## Execute
press F5 and run the console

## Tests
show a bit of the usage and the rest is in the Main() method

### Fundaments
based on the messaging system used in CQRS, where commands describe an action to be run and the commandHandler executes said action.
the communication throughout the code between commands and various other parts of the system is performed between imperative coding (calling the commands) and events fired by the handlers which any part of the code can subscribe to.
This comm system is not implemented here however

#### Event communication samples
[https://blogs.cuttingedge.it/steven/posts/2012/returning-data-from-command-handlers/](https://blogs.cuttingedge.it/steven/posts/2012/returning-data-from-command-handlers/)

[https://blogs.cuttingedge.it/steven/posts/2011/meanwhile-on-the-command-side-of-my-architecture/](https://blogs.cuttingedge.it/steven/posts/2011/meanwhile-on-the-command-side-of-my-architecture/)
