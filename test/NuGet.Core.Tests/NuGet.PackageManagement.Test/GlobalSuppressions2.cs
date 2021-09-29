// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.PackageManagement.Test.BuildIntegratedNuGetProjectTests.BuildIntegratedNuGetProject_IsRestoreRequiredWithNoChangesFallbackFolder~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.PackageManagement.Test.BuildIntegratedNuGetProjectTests.BuildIntegratedNuGetProject_IsRestoreRequiredWithNoChangesFallbackFolderIgnoresOtherHashes")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.PackageManagement.Test.DependencyGraphRestoreUtilityTests.RestoreAsync_WithMinimalProjectAndAdditionalErrorMessage_WritesErrorsToAssetsFile~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.PackageManagement.Test.InstallationCompatibilityTests.TestContext.GetRestoreResult(System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageIdentity})~NuGet.Commands.RestoreResult")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.BuildIntegratedTests.CreateReference(System.String)~NuGet.ProjectModel.ExternalProjectReference")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.BuildIntegratedTests.CreateSource(System.Collections.Generic.List{NuGet.Protocol.Core.Types.SourcePackageDependencyInfo})~NuGet.Protocol.Core.Types.SourceRepositoryProvider")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.BuildIntegratedTests.PopulateSettingsWithSources(NuGet.Protocol.Core.Types.SourceRepositoryProvider,NuGet.Test.Utility.TestDirectory)~NuGet.Configuration.ISettings")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.BuildIntegratedTests.TestPacMan_BuildIntegrated_PreviewUpdatesAsync_WithStrictVersionRange~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.CreateSource(System.Collections.Generic.List{NuGet.Protocol.Core.Types.SourcePackageDependencyInfo})~NuGet.Protocol.Core.Types.SourceRepositoryProvider")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_BuildIntegratedProject_PreviewUpdatePackage~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_MultipleBuildIntegratedProjects_PreviewUpdatePackage~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewInstallPackage_BuildIntegrated_NullVersion_Throws~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewUpdatePackage_DeepDependencies~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewUpdatePackage_IgnoreDependency~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewUpdatePackage_UnlistedPackage~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewUpdatePackagesAsync_MultiProjects~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacMan_PreviewUpdatePackagesAsync_MultiProjects_MultiDependencies~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManInstallPackageDowngrade~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManInstallPackageListedFromV3~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManInstallPackagePrerelease~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManInstallPackageUnlistedFromV3~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreview_InstallForPC_PackageNamespace_WithMultipleFeeds_ForTransitiveDepency_SecondarySourcesConsidered~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreview_InstallForPC_PackageNamespace_WithMultipleFeedsWithIdenticalPackages_RestoresCorrectPackage~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreview_InstallForPC_PackageNamespace_WithSingleFeed_Succeeds~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewInstallPackageFollowingForceUninstall~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewInstallPackageWithNonTargetDependency~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdateMulti~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdateMultiWithConflict~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdateMultiWithDowngradeConflict~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdatePackageALLPrereleaseInProject~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdatePackageFollowingForceUninstall~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdatePackageNotExistsInProject~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdatePackageWithTargetPrereleaseInProject~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManPreviewUpdatePrereleasePackageNoPreFlagSpecified~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManReinstallSpecificPackage~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.TestPacManUpdatePackagePreservePackagesConfigAttributes~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.NuGetPackageManagerTests.VerifyPreviewActionsTelemetryEvents_PackagesConfig(System.Collections.Generic.IEnumerable{System.String})")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_Basic~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_BasicGatherWithExtraPackages~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_DependenciesSpreadAcrossRepos~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_GatherWithNotFoundPackages~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_PackageNamespace_Fails(System.String,System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.ResolverGatherTests.ResolverGather_PackageNamespace_Succeed(System.String,System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Reliability", "CA2016:Forward the 'CancellationToken' parameter to methods", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.TestTimeoutDependencyInfo.ResolvePackage(NuGet.Packaging.Core.PackageIdentity,NuGet.Frameworks.NuGetFramework,NuGet.Protocol.Core.Types.SourceCacheContext,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.Protocol.Core.Types.SourcePackageDependencyInfo}")]
[assembly: SuppressMessage("Reliability", "CA2016:Forward the 'CancellationToken' parameter to methods", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.TestTimeoutDependencyInfo.ResolvePackages(System.String,NuGet.Frameworks.NuGetFramework,NuGet.Protocol.Core.Types.SourceCacheContext,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.SourcePackageDependencyInfo}}")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.V2V3ParityTests.Compare(System.Collections.Generic.IEnumerable{NuGet.PackageManagement.NuGetProjectAction},System.Collections.Generic.IEnumerable{NuGet.PackageManagement.NuGetProjectAction})~System.Boolean")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Test.V2V3ParityTests.PacManCleanInstall(NuGet.Protocol.Core.Types.SourceRepositoryProvider,NuGet.Packaging.Core.PackageIdentity)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{NuGet.PackageManagement.NuGetProjectAction}}")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:ProjectManagement.Test.PackagesConfigNuGetProjectTests.GetTestMetadata(NuGet.Frameworks.NuGetFramework,System.String)~System.Collections.Generic.Dictionary{System.String,System.Object}")]
