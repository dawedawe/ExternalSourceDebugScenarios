string GetVersion()
{
    var t = Task.Run(() =>
    {
        var v = Fantomas.Core.CodeFormatter.GetVersion(); // breakpoint here, hit F7 (Step Into) once,
                                                                // this should bring you into CodeFormatter.fs from the Fantomas.Core package 
                                                                // continue with F8 (Step Over)
        return v; 
    }).GetAwaiter().GetResult(); // here we enter Future.cs, ExecutionContext.cs, Tasks.cs, ThreadPoolWorkQueue.cs,
                                 // PortableThreadPool.WorkerThread.cs (from System.Threading), even though we used F8 to step over

    return t;
}

var v = GetVersion();
Console.WriteLine($"version = {v}");