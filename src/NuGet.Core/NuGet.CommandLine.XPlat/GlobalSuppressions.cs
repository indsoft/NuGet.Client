// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1802:Field '_useConsoleColor' is declared as 'readonly' but is initialized with a constant value. Mark this field as 'const' instead.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.CommandLine.XPlat.CommandOutputLogger._useConsoleColor")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void AddPackageReferenceCommand.Register(CommandLineApplication app, Func<ILogger> getLogger, Func<IPackageReferenceCommandRunner> getCommandRunner)', validate parameter 'app' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.AddPackageReferenceCommand.Register(Microsoft.Extensions.CommandLineUtils.CommandLineApplication,System.Func{NuGet.Common.ILogger},System.Func{NuGet.CommandLine.XPlat.IPackageReferenceCommandRunner})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<int> AddPackageReferenceCommandRunner.ExecuteCommand(PackageReferenceArgs packageReferenceArgs, MSBuildAPIUtility msBuild)', validate parameter 'msBuild' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.AddPackageReferenceCommandRunner.ExecuteCommand(NuGet.CommandLine.XPlat.PackageReferenceArgs,NuGet.CommandLine.XPlat.MSBuildAPIUtility)~System.Threading.Tasks.Task{System.Int32}")]
[assembly: SuppressMessage("Build", "CA1308:In method 'LogInternal', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.CommandOutputLogger.LogInternal(NuGet.Common.LogLevel,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void CommandOutputLogger.LogInternal(LogLevel logLevel, string message)', validate parameter 'message' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.CommandOutputLogger.LogInternal(NuGet.Common.LogLevel,System.String)")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.IndexOf(char)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.XPlat.CommandOutputLogger.LogInternal(NuGet.Common.LogLevel, string)' with a call to 'string.IndexOf(char, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.CommandOutputLogger.LogInternal(NuGet.Common.LogLevel,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ListPackageCommand.Register(CommandLineApplication app, Func<ILogger> getLogger, Func<IListPackageCommandRunner> getCommandRunner)', validate parameter 'app' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommand.Register(Microsoft.Extensions.CommandLineUtils.CommandLineApplication,System.Func{NuGet.Common.ILogger},System.Func{NuGet.CommandLine.XPlat.IListPackageCommandRunner})")]
[assembly: SuppressMessage("Build", "CA1822:Member AddPackagesToDict does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.AddPackagesToDict(System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.FrameworkPackages},System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IList{NuGet.Protocol.Core.Types.IPackageSearchMetadata}})")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.XPlat.ListPackageCommandRunner.ExecuteCommandAsync(NuGet.CommandLine.XPlat.ListPackageArgs)' with a call to 'string.Equals(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.ExecuteCommandAsync(NuGet.CommandLine.XPlat.ListPackageArgs)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ListPackageCommandRunner.ExecuteCommandAsync(ListPackageArgs)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.ExecuteCommandAsync(NuGet.CommandLine.XPlat.ListPackageArgs)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task ListPackageCommandRunner.ExecuteCommandAsync(ListPackageArgs listPackageArgs)', validate parameter 'listPackageArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.ExecuteCommandAsync(NuGet.CommandLine.XPlat.ListPackageArgs)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1822:Member GetLatestVersionPerSourceAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.GetLatestVersionPerSourceAsync(NuGet.Configuration.PackageSource,NuGet.CommandLine.XPlat.ListPackageArgs,System.String,System.Collections.Generic.IEnumerable{System.Lazy{NuGet.Protocol.Core.Types.INuGetResourceProvider}},System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IList{NuGet.Protocol.Core.Types.IPackageSearchMetadata}})~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1822:Member GetPackageMetadataFromSourceAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.GetPackageMetadataFromSourceAsync(NuGet.Configuration.PackageSource,NuGet.CommandLine.XPlat.ListPackageArgs,System.String,NuGet.Versioning.NuGetVersion,System.Collections.Generic.IEnumerable{System.Lazy{NuGet.Protocol.Core.Types.INuGetResourceProvider}},System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.IList{NuGet.Protocol.Core.Types.IPackageSearchMetadata}})~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1822:Member GetUpdateLevel does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.GetUpdateLevel(NuGet.Versioning.NuGetVersion,NuGet.Versioning.NuGetVersion)~NuGet.CommandLine.XPlat.UpdateLevel")]
[assembly: SuppressMessage("Build", "CA1822:Member MeetsConstraints does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.ListPackageCommandRunner.MeetsConstraints(NuGet.Versioning.NuGetVersion,NuGet.CommandLine.XPlat.InstalledPackageReference,NuGet.CommandLine.XPlat.ListPackageArgs)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void MSBuildAPIUtility.AddPackageReferencePerTFM(string projectPath, LibraryDependency libraryDependency, IEnumerable<string> frameworks)', validate parameter 'libraryDependency' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.AddPackageReferencePerTFM(System.String,NuGet.LibraryModel.LibraryDependency,System.Collections.Generic.IEnumerable{System.String})")]
[assembly: SuppressMessage("Build", "CA1801:Parameter project of method GetItemGroup is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetItemGroup(Microsoft.Build.Evaluation.Project,System.Collections.Generic.IEnumerable{Microsoft.Build.Construction.ProjectItemGroupElement},System.String)~Microsoft.Build.Construction.ProjectItemGroupElement")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetPackageReferencesFromTargets(string, string)' with a call to 'string.Equals(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetPackageReferencesFromTargets(System.String,System.String)~System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.InstalledPackageReference}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'GetResolvedVersions' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetResolvedVersions(System.String,System.Collections.Generic.IEnumerable{System.String},NuGet.ProjectModel.LockFile,System.Boolean)~System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.FrameworkPackages}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'MSBuildAPIUtility.GetResolvedVersions(string, IEnumerable<string>, LockFile, bool)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetResolvedVersions(System.String,System.Collections.Generic.IEnumerable{System.String},NuGet.ProjectModel.LockFile,System.Boolean)~System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.FrameworkPackages}")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetResolvedVersions(string, System.Collections.Generic.IEnumerable<string>, NuGet.ProjectModel.LockFile, bool)' with a call to 'string.Equals(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetResolvedVersions(System.String,System.Collections.Generic.IEnumerable{System.String},NuGet.ProjectModel.LockFile,System.Boolean)~System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.FrameworkPackages}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'MSBuildAPIUtility.GetTargetFrameworkCondition(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.GetTargetFrameworkCondition(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int MSBuildAPIUtility.RemovePackageReference(string projectPath, LibraryDependency libraryDependency)', validate parameter 'libraryDependency' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.MSBuildAPIUtility.RemovePackageReference(System.String,NuGet.LibraryModel.LibraryDependency)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int Program.MainInternal(string[] args, CommandOutputLogger log)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Program.MainInternal(System.String[],NuGet.CommandLine.XPlat.CommandOutputLogger)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1308:In method 'MainInternal', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Program.MainInternal(System.String[],NuGet.CommandLine.XPlat.CommandOutputLogger)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'MainInternal' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Program.MainInternal(System.String[],NuGet.CommandLine.XPlat.CommandOutputLogger)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1303:Method 'int Program.MainInternal(string[] args, CommandOutputLogger log)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Waiting for debugger to attach.\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Program.MainInternal(System.String[],NuGet.CommandLine.XPlat.CommandOutputLogger)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void RemovePackageReferenceCommand.Register(CommandLineApplication app, Func<ILogger> getLogger, Func<IPackageReferenceCommandRunner> getCommandRunner)', validate parameter 'app' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.RemovePackageReferenceCommand.Register(Microsoft.Extensions.CommandLineUtils.CommandLineApplication,System.Func{NuGet.Common.ILogger},System.Func{NuGet.CommandLine.XPlat.IPackageReferenceCommandRunner})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<int> RemovePackageReferenceCommandRunner.ExecuteCommand(PackageReferenceArgs packageReferenceArgs, MSBuildAPIUtility msBuild)', validate parameter 'msBuild' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.RemovePackageReferenceCommandRunner.ExecuteCommand(NuGet.CommandLine.XPlat.PackageReferenceArgs,NuGet.CommandLine.XPlat.MSBuildAPIUtility)~System.Threading.Tasks.Task{System.Int32}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ProjectPackagesPrintUtility.PrintPackagesAsync(IEnumerable<FrameworkPackages>, string, bool, bool, bool)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Utility.ProjectPackagesPrintUtility.PrintPackagesAsync(System.Collections.Generic.IEnumerable{NuGet.CommandLine.XPlat.FrameworkPackages},System.String,System.Boolean,System.Boolean,System.Boolean)~System.Threading.Tasks.Task{NuGet.CommandLine.XPlat.Utility.PrintPackagesResult}")]
[assembly: SuppressMessage("Build", "CA1814:arrValues is a multidimensional array. Replace it with a jagged array if possible.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Utility.TableParser.GetMaxColumnsWidth(System.String[,])~System.Int32[]")]
[assembly: SuppressMessage("Build", "CA1814:arrValues is a multidimensional array. Replace it with a jagged array if possible.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Utility.TableParser.ToStringTable``1(``0[],System.String[,])~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Build", "CA1814:ToStringTableAsync uses a multidimensional array of string[*,*]. Replace it with a jagged array if possible.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.XPlat.Utility.TableParser.ToStringTableAsync``1(``0[],System.String[],System.Func{``0,System.Threading.Tasks.Task{System.Object}}[])~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{System.String}}")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.CommandLine.XPlat.PackageReferenceArgs.Frameworks")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.CommandLine.XPlat.PackageReferenceArgs.Sources")]
[assembly: SuppressMessage("Build", "CA1052:Type 'Program' is a static holder type but is neither static nor NotInheritable", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.CommandLine.XPlat.Program")]
[assembly: SuppressMessage("Build", "CA1052:Type 'RemovePackageReferenceCommand' is a static holder type but is neither static nor NotInheritable", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.CommandLine.XPlat.RemovePackageReferenceCommand")]
