﻿using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Testing.Fixtures;

namespace Cake.Buildah.Tests.Registry.Login;

public class BuildahRegistryLoginFixture : ToolFixture<BuildahRegistryLoginSettings>, ICakeContext
{
    public string Path { get; set; } = null!;

    IFileSystem ICakeContext.FileSystem => FileSystem;

    ICakeEnvironment ICakeContext.Environment => Environment;

    public ICakeLog Log => Log;

    ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();

    IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;

    public IRegistry Registry => Registry;

    public ICakeDataResolver Data => throw new NotImplementedException();

    ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();

    public BuildahRegistryLoginFixture(): base("Buildah") => ProcessRunner.Process.SetStandardOutput(new string[] { });

    protected override void RunTool()
    {
        this.BuildahLogin(Settings, Path);
    }
}
