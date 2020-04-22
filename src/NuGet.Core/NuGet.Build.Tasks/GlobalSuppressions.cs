﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void MSBuildLogger.Log(ILogMessage message)', validate parameter 'message' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.MSBuildLogger.Log(NuGet.Common.ILogMessage)")]
[assembly: SuppressMessage("Build", "CA1822:Member LogError does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.MSBuildLogger.LogError(NuGet.Common.INuGetLogMessage,NuGet.Build.MSBuildLogger.LogErrorWithDetails,NuGet.Build.MSBuildLogger.LogErrorAsString)")]
[assembly: SuppressMessage("Build", "CA1822:Member LogMessage does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.MSBuildLogger.LogMessage(NuGet.Common.INuGetLogMessage,Microsoft.Build.Framework.MessageImportance,NuGet.Build.MSBuildLogger.LogMessageWithDetails,NuGet.Build.MSBuildLogger.LogMessageAsString)")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<IMSBuildItem>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.MSBuildUtility.WrapMSBuildItem(System.Collections.Generic.IEnumerable{Microsoft.Build.Framework.ITaskItem})~NuGet.Commands.IMSBuildItem[]")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.AddAllProjectsForRestore(DependencyGraphSpec spec)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.AddAllProjectsForRestore(NuGet.ProjectModel.DependencyGraphSpec)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.AddPropertyIfExists(IDictionary<string, string> properties, string key, string value)', validate parameter 'properties' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.AddPropertyIfExists(System.Collections.Generic.IDictionary{System.String,System.String},System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.AddPropertyIfExists(IDictionary<string, string> properties, string key, string[] value)', validate parameter 'properties' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.AddPropertyIfExists(System.Collections.Generic.IDictionary{System.String,System.String},System.String,System.String[])")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'BuildTasksUtility.CalculateEffectivePackageSaveMode(ISettings)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.CalculateEffectivePackageSaveMode(NuGet.Configuration.ISettings)~NuGet.Packaging.PackageSaveMode")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.CopyPropertyIfExists(ITaskItem item, IDictionary<string, string> properties, string key, string toKey)', validate parameter 'properties' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.CopyPropertyIfExists(Microsoft.Build.Framework.ITaskItem,System.Collections.Generic.IDictionary{System.String,System.String},System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool BuildTasksUtility.DoesProjectSupportRestore(PackageSpec packageSpec)', validate parameter 'packageSpec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.DoesProjectSupportRestore(NuGet.ProjectModel.PackageSpec)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1801:Parameter log of method GetInstalledPackageReferences is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.GetInstalledPackageReferences(System.String,System.Boolean,NuGet.Common.ILogger)~System.Collections.Generic.IEnumerable{NuGet.Packaging.PackageReference}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'BuildTasksUtility.GetInstalledPackageReferences(string, bool, ILogger)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.GetInstalledPackageReferences(System.String,System.Boolean,NuGet.Common.ILogger)~System.Collections.Generic.IEnumerable{NuGet.Packaging.PackageReference}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter log of method GetProjectRestoreStyle is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.GetProjectRestoreStyle(System.Nullable{NuGet.ProjectModel.ProjectStyle},System.Boolean,System.String,System.String,System.String,NuGet.Common.ILogger)~System.ValueTuple{NuGet.ProjectModel.ProjectStyle,System.Boolean,System.String}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.LogInputParam(ILogger log, string name, params string[] values)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.LogInputParam(NuGet.Common.ILogger,System.String,System.String[])")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void BuildTasksUtility.LogOutputParam(ILogger log, string name, params string[] values)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.LogOutputParam(NuGet.Common.ILogger,System.String,System.String[])")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'BuildTasksUtility.RestoreAsync(DependencyGraphSpec, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, ILogger, CancellationToken)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.RestoreAsync(NuGet.ProjectModel.DependencyGraphSpec,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter restorePC of method RestoreAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.BuildTasksUtility.RestoreAsync(NuGet.ProjectModel.DependencyGraphSpec,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA2225:Provide a method named 'ToConsoleOutLogMessage' or 'FromBuildErrorEventArgs' as an alternate for operator op_Implicit.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildErrorEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ConsoleOutLogMessage.implicit operator ConsoleOutLogMessage(BuildErrorEventArgs buildErrorEventArgs)', validate parameter 'buildErrorEventArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildErrorEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA2225:Provide a method named 'ToConsoleOutLogMessage' or 'FromBuildMessageEventArgs' as an alternate for operator op_Implicit.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildMessageEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ConsoleOutLogMessage.implicit operator ConsoleOutLogMessage(BuildMessageEventArgs buildMessageEventArgs)', validate parameter 'buildMessageEventArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildMessageEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA2225:Provide a method named 'ToConsoleOutLogMessage' or 'FromBuildWarningEventArgs' as an alternate for operator op_Implicit.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildWarningEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ConsoleOutLogMessage.implicit operator ConsoleOutLogMessage(BuildWarningEventArgs buildWarningEventArgs)', validate parameter 'buildWarningEventArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.ConsoleOutLogMessage.op_Implicit(Microsoft.Build.Framework.BuildWarningEventArgs)~NuGet.Build.Tasks.ConsoleOutLogMessage")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object, object)' could vary based on the current user's locale settings. Replace this call in 'GetReferenceNearestTargetFrameworkTask.AssignNearestFrameworkForSingleReference(ITaskItem, NuGetFramework, IList<NuGetFramework>, MSBuildLogger)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.GetReferenceNearestTargetFrameworkTask.AssignNearestFrameworkForSingleReference(Microsoft.Build.Framework.ITaskItem,NuGet.Frameworks.NuGetFramework,System.Collections.Generic.IList{NuGet.Frameworks.NuGetFramework},NuGet.Build.MSBuildLogger)~Microsoft.Build.Framework.ITaskItem")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'GetReferenceNearestTargetFrameworkTask.Execute()' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.GetReferenceNearestTargetFrameworkTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'bool.ToString()' could vary based on the current user's locale settings. Replace this call in 'GetRestoreProjectStyleTask.Execute()' with a call to 'bool.ToString(IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.GetRestoreProjectStyleTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Execute' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.GetRestoreSettingsTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1063:Modify 'LoggingQueue.Dispose' so that it calls Dispose(true), then calls GC.SuppressFinalize on the current object instance ('this' or 'Me' in Visual Basic), and then returns.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.LoggingQueue`1.Dispose")]
[assembly: SuppressMessage("Build", "CA1816:Change LoggingQueue<T>.Dispose() to call GC.SuppressFinalize(object). This will prevent derived types that introduce a finalizer from needing to re-implement 'IDisposable' to call it.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.LoggingQueue`1.Dispose")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ISettings RestoreSettingsUtils.ReadSettings(string solutionDirectory, string restoreDirectory, string restoreConfigFile, Lazy<IMachineWideSettings> machineWideSettings, SettingsLoadingContext settingsLoadContext)', validate parameter 'machineWideSettings' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreSettingsUtils.ReadSettings(System.String,System.String,System.String,System.Lazy{NuGet.Configuration.IMachineWideSettings},NuGet.Configuration.SettingsLoadingContext)~NuGet.Configuration.ISettings")]
[assembly: SuppressMessage("Build", "CA1063:Modify 'RestoreTask.Dispose' so that it calls Dispose(true), then calls GC.SuppressFinalize on the current object instance ('this' or 'Me' in Visual Basic), and then returns.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTask.Dispose")]
[assembly: SuppressMessage("Build", "CA1816:Change RestoreTask.Dispose() to call GC.SuppressFinalize(object). This will prevent derived types that introduce a finalizer from needing to re-implement 'IDisposable' to call it.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTask.Dispose")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Execute' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1303:Method 'bool RestoreTask.Execute()' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Waiting for debugger to attach.\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Execute' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTaskEx.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1303:Method 'bool RestoreTaskEx.Execute()' passes a literal string as parameter 'message' of a call to 'void TaskLoggingHelper.LogMessage(MessageImportance importance, string message, params object[] messageArgs)'. Retrieve the following string(s) from a resource table instead: \"\"{0}\" {1}\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTaskEx.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'GetGlobalProperties' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.RestoreTaskEx.GetGlobalProperties~System.Collections.Generic.Dictionary{System.String,System.String}")]
[assembly: SuppressMessage("Build", "CA2208:Call the ArgumentOutOfRangeException constructor that contains a message and/or paramName parameter.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.TaskLoggingQueue.Process(System.String)")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Process' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.TaskLoggingQueue.Process(System.String)")]
[assembly: SuppressMessage("Build", "CA1303:Method 'bool WriteRestoreGraphTask.Execute()' passes a literal string as parameter 'message' of a call to 'void TaskLoggingHelper.LogWarning(string message, params object[] messageArgs)'. Retrieve the following string(s) from a resource table instead: \"Unable to find a project to restore!\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Build.Tasks.WriteRestoreGraphTask.Execute~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetCentralPackageVersionsTask.CentralPackageVersions")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetCentralPackageVersionsTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetReferenceNearestTargetFrameworkTask.AnnotatedProjectReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetReferenceNearestTargetFrameworkTask.AssignedProjects")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetReferenceNearestTargetFrameworkTask.FallbackTargetFrameworks")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreDotnetCliToolsTask.DotnetCliToolReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreDotnetCliToolsTask.RestoreConfigFilePaths")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreDotnetCliToolsTask.RestoreFallbackFolders")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreDotnetCliToolsTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreDotnetCliToolsTask.RestoreSources")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreFrameworkReferencesTask.FrameworkReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreFrameworkReferencesTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestorePackageDownloadsTask.PackageDownloads")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestorePackageDownloadsTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestorePackageReferencesTask.PackageReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestorePackageReferencesTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreProjectReferencesTask.ProjectReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreProjectReferencesTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.OutputConfigFilePaths")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.OutputFallbackFolders")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.OutputSources")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.RestoreFallbackFolders")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.RestoreFallbackFoldersOverride")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.RestoreSettingsPerFramework")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.RestoreSources")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSettingsTask.RestoreSourcesOverride")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSolutionProjectsTask.OutputProjectReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.GetRestoreSolutionProjectsTask.ProjectReferences")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.NuGetMessageTask.Args")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.RestoreTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.WarnForInvalidProjectsTask.AllProjects")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.WarnForInvalidProjectsTask.ValidProjects")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Build.Tasks.WriteRestoreGraphTask.RestoreGraphItems")]
[assembly: SuppressMessage("Build", "CA1063:Provide an overridable implementation of Dispose(bool) on 'LoggingQueue' or mark the type as sealed. A call to Dispose(false) should only clean up native resources. A call to Dispose(true) should clean up both managed and native resources.", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Build.Tasks.LoggingQueue`1")]
[assembly: SuppressMessage("Build", "CA1052:Type 'RestoreSettingsUtils' is a static holder type but is neither static nor NotInheritable", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Build.Tasks.RestoreSettingsUtils")]
[assembly: SuppressMessage("Build", "CA1063:Provide an overridable implementation of Dispose(bool) on 'RestoreTask' or mark the type as sealed. A call to Dispose(false) should only clean up native resources. A call to Dispose(true) should clean up both managed and native resources.", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Build.Tasks.RestoreTask")]
