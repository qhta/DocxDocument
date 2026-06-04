namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters for signature sets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosignaturesubset?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSignatureSubset")]
public enum SignatureSubset
{
  /// <summary>
  /// All non-visible signatures plus all signed signature lines.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetSignaturesAllSigs")]
  SignaturesAllSigs,
  /// <summary>
  /// All non-visible signatures.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetSignaturesNonVisible")]
  SignaturesNonVisible,
  /// <summary>
  /// All signature lines.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetSignatureLines")]
  SignatureLines,
  /// <summary>
  /// Signature lines that have been signed.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetSignatureLinesSigned")]
  SignatureLinesSigned,
  /// <summary>
  /// Signature lines that have not been signed.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetSignatureLinesUnsigned")]
  SignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  [InteropEnumValue("msoSignatureSubsetAll")]
  All
}
