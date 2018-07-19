#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam

var target = Argument("target", "Default");

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            OutputPath = Directory("..\\output")
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true
        });        
    });

Task("Default")
    .IsDependentOn("Build");

RunTarget(target);