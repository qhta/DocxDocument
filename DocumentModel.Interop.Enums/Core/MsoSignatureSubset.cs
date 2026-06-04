namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters for signature sets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosignaturesubset?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSignatureSubset")]
public enum SignatureSubset
{
  /// <summary>
  /// All non-visible signatures plus all signed signature lines.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetSignaturesAllSigs")]
  SignaturesAllSigs,
  /// <summary>
  /// All non-visible signatures.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetSignaturesNonVisible")]
  SignaturesNonVisible,
  /// <summary>
  /// All signature lines.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetSignatureLines")]
  SignatureLines,
  /// <summary>
  /// Signature lines that have been signed.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetSignatureLinesSigned")]
  SignatureLinesSigned,
  /// <summary>
  /// Signature lines that have not been signed.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetSignatureLinesUnsigned")]
  SignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  [OfficeInteropEnumValue("msoSignatureSubsetAll")]
  All
}
