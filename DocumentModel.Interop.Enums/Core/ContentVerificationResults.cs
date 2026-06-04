namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the status of verifying whether the content of a document has changed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contentverificationresults?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.ContentVerificationResults))]
public enum ContentVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.ContentVerificationResults.contverresError))]
  Error,
  /// <summary>
  /// The content of the document is currently being verified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.ContentVerificationResults.contverresVerifying))]
  Verifying,
  /// <summary>
  /// The document has not been verified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.ContentVerificationResults.contverresUnverified))]
  Unverified,
  /// <summary>
  /// The content of the has been verified and is valid.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.ContentVerificationResults.contverresValid))]
  Valid,
  /// <summary>
  /// The content of the document has been modified since it was digitally signed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.ContentVerificationResults.contverresModified))]
  Modified
}
