// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:Commands.Test.NugetPackageUtilsTests.PackageExpander_CleansExtraFiles~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:Commands.Test.NugetPackageUtilsTests.PackageExpander_ExpandsPackage_SkipsIfShaIsThere~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "<Pending>", Scope = "member", Target = "~M:Commands.Test.NugetPackageUtilsTests.PackageExpander_Recovers_WhenFileIsLocked~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1835:Prefer the 'Memory'-based overloads for 'ReadAsync' and 'WriteAsync'", Justification = "<Pending>", Scope = "member", Target = "~M:Commands.Test.NugetPackageUtilsTests.ThrowingPackageArchiveDownloader.CopyNupkgFileToAsync(System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Reliability", "CA2016:Forward the 'CancellationToken' parameter to methods", Justification = "<Pending>", Scope = "member", Target = "~M:Commands.Test.NugetPackageUtilsTests.ThrowingPackageArchiveDownloader.CopyNupkgFileToAsync(System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Client.Test.ContentModelBuildTests.ContentModel_BuildNoFilesAtRoot")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Client.Test.ContentModelContentFilesTests.ContentFiles_Empty")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Client.Test.ContentModelLibTests.ContentModel_LibRootIgnoreSubFolder")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Core.Test.NuspecCoreReaderTests.GetPackageType_GetsMultiplePackageTypes")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Core.Test.NuspecCoreReaderTests.GetPackageType_GetsMultiplePackageTypes")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Core.Test.NuspecCoreReaderTests.GetPackageType_ReadsPackageTypeFromManifest(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Core.Test.NuspecCoreReaderTests.GetPackageType_ReadsPackageTypeFromManifest(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Licenses.Test.LicenseExpressionTokenizerTests.LicenseExpressionTokenizer_TokenizesSimpleExpressionCorrectly(System.String,System.String)")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.AttributeUtilityTests.CreateAttributeCollection(System.Security.Cryptography.X509Certificates.X509Certificate2,System.Security.Cryptography.RSA,System.Action{Org.BouncyCastle.Asn1.Asn1EncodableVector})~System.Security.Cryptography.CryptographicAttributeObjectCollection")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.FrameworkReferenceGroupTests.FrameworkReferenceGroup_ThrowsForNullTargetFramework")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.InvalidUndottedFrameworkRuleTests.ValidateFiles")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.ManifestTest.AssertFile(NuGet.Packaging.ManifestFile,NuGet.Packaging.ManifestFile)")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.MessageImprintTests.Read_WithInvalidHashedMessage_Throws")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_BadLicenseVersionAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_BadLicenseVersionAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_InvalidVersionRangeInDependencyThrowsExceptionForStrictCheck(System.String)")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionBadAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionBadAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionBasicExplicitHighVersionAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionBasicExplicitHighVersionAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionMissingValueAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionMissingValueAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionNonStandardLicenseAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionNonStandardLicenseAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionNonStandardLicensesAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_LicenseExpressionNonStandardLicensesAddsMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_UnlicensedAddsAMessage")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.NuspecReaderTests.NuspecReaderTests_UnlicensedAddsAMessage")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetContentItems_ReturnsContentWithFrameworks")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetContentItems_ReturnsContentWithMixedFrameworks")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetContentItems_ReturnsContentWithNoFrameworks")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ReturnsStream")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ReturnsStreamForRootNuspec")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_SupportsEscapingInFileName")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ThrowsForMultipleRootNuspecs")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ThrowsForNoNuspec")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ThrowsForNoNuspecWithCorrectExtension")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetNuspec_ThrowsForNoRootNuspec")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsItemsWithNoNuspecEntries")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsLegacyFolders")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsNestedReferenceItems")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsNestedReferenceItemsMixed")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsReferencesWithGroups")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageArchiveReaderTests.GetReferenceItems_ReturnsReferencesWithoutGroups")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.CreatePackageFileOnPath(System.String,System.DateTime)~NuGet.Packaging.IPackageFile")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.GetManifestStream(System.IO.Stream)~System.IO.Stream")]
[assembly: SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.Icon_MultipleIconFilesResolved_ThrowsException")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.IdExceedingMaxLengthThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.MissingAuthorsThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.MissingDescriptionThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.MissingIdThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.MissingMetadataNodeThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.MissingVersionThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderRequireLicenseAcceptedWithLicenseDoesNotThrow")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderRequireLicenseAcceptedWithoutLicenseUrlThrows")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsIfXmlIsMalformed")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsWhenDependenciesHasMixedDependencyAndGroupChildren")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsWhenLicenseUrlIsMalformed")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsWhenLicenseUrlIsPresentButEmpty")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsWhenLicenseUrlIsWhiteSpace")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.PackageBuilderThrowsWhenLicenseUrlIsWhiteSpaceAndLicenseExpressionIsNotNull")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.ReferencesContainMixedElementsThrows")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.SavePackageAndAssertException(NuGet.Test.Utility.TestDirectoryBuilder,System.String)")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.SavePackageAndAssertIcon(NuGet.Test.Utility.TestDirectoryBuilder,System.String)")]
[assembly: SuppressMessage("Performance", "CA1806:Do not ignore method results", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageBuilderTest.WrongCaseIdThrows")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.ExtractPackageAsync_UnsignedPackage_RequireMode_ErrorAsync~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.ExtractPackageAsync_UnsignedPackage_RequireMode_OptInEnvVar_Error~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.ExtractPackageAsync_UnsignedPackage_WhenRepositorySaysAllPackagesSigned_ErrorAsync~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.ExtractPackageAsync_UnsignedPackage_WhenRepositorySaysAllPackagesSigned_OptInEnvVar_Error~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Reliability", "CA2016:Forward the 'CancellationToken' parameter to methods", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.PackageReader.CopyNupkgAsync(System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.PermissionWithUMaskApplied(System.String)~System.String")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageExtractorTests.StatPermissions(System.String)~System.String")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ReturnsStream")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ReturnsStreamForRootNuspec")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_SupportsEscapingInFileName")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ThrowsForMultipleRootNuspecs")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ThrowsForNoNuspec")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ThrowsForNoNuspecWithCorrectExtension")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackageFolderReaderTests.GetNuspec_ThrowsForNoRootNuspec")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackagesConfigWriterTests.PackagesConfigWriter_Remove")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackagesConfigWriterTests.PackagesConfigWriter_Update")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackagesConfigWriterTests.PackagesConfigWriter_UpdateAttributes")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.PackagesConfigWriterTests.PackagesConfigWriter_UpdateAttributesFromOriginalConfig")]
[assembly: SuppressMessage("Performance", "CA1835:Prefer the 'Memory'-based overloads for 'ReadAsync' and 'WriteAsync'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.ReadOnlyBufferedStreamTests.ReadAsync_Reads~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.ReferencesInNuspecMatchRefAssetsRuleTests.Compare_EmptyNuspecReferences_ShouldBeEmpty")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SignatureContentTests.Load_IfSigningSpecificationsIsNull_Throws")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SignedPackageArchiveIOUtilityTests.HashBytes_WithInputBytes_Hashes")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SignedPackageArchiveIOUtilityTests.ReadHashTest.GetHash~System.String")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SigningCertificateV2Tests.Read_WithNoEssCertIds_ReturnsSigningCertificateV2")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SigningUtilityTests.CreateSignedAttributes_RepositorySignPackageRequest_WhenChainListEmpty_Throws")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SigningUtilityTests.CreateSignedAttributes_SignPackageRequest_WhenChainListEmpty_Throws")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SigningUtilityTests.SignAsync_WhenPackageEntryCountWouldRequireZip64_FailsAsync~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.SigningUtilityTests.SignAsync_WithUntrustedSelfSignedCertificate_SucceedsAsync~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.TrustedSignersProviderTests.Remove_IgnoresAnyUnexistantTrustedSigner")]
[assembly: SuppressMessage("Performance", "CA1826:Do not use Enumerable methods on indexable collections", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.TrustedSignersProviderTests.Remove_SuccessfullyRemovesTrustedSigners")]
[assembly: SuppressMessage("Performance", "CA1834:Consider using 'StringBuilder.Append(char)' when applicable", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Packaging.Test.TstInfoTests.Test.GetGenTime~Org.BouncyCastle.Asn1.DerGeneralizedTime")]
[assembly: SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.RuntimeModel.Test.JsonObjectWriterTests.Dispose")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.RuntimeModel.Test.JsonRuntimeFormatTests.ParseRuntimeJsonString(System.String)~NuGet.RuntimeModel.RuntimeGraph")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Packaging.Test.CentralDirectoryHeader.DiskNumberStart")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Packaging.Test.EndOfCentralDirectoryRecord.NumberOfTheDiskWithTheStartOfTheCentralDirectory")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Packaging.Test.EndOfCentralDirectoryRecord.NumberOfThisDisk")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Packaging.Test.LocalFileHeader.CompressionMethod")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Packaging.Test.SignedPackageArchiveIOUtilityTests.ReadTest.Bytes")]
