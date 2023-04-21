This project demonstrates the issue of stepping into an external source on purpose and then stepping into an external source without intent to do so.

First, please make sure you have "Enable external source debug" switched on in your Rider settings.

To reproduce, place a breakpoint in M1.fs Line 5.
Start the project in Debug mode and wait for the breakpoint to be hit.
Then use `Step Into` (F7 in the IntelliJ keymap) exactly once to step into the external Fantomas.Core source.
Then use `Step Over` (F8 in the IntelliJ keymap) afterwards. You should see that the debugger steps into the sources of `async.fs` from the `Microsoft.FSharp.Control` namespace.

It would be great to have a whitelisting feature in Rider to say it's okay to step into the `Fantomas.Core` sources, but all other external sources should be ignored while debugging.