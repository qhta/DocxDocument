namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters for signature sets.
/// </summary>
public enum MsoSignatureSubset
{
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  msoSignatureSubsetSignaturesAllSigs,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  msoSignatureSubsetSignaturesNonVisible,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  msoSignatureSubsetSignatureLines,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  msoSignatureSubsetSignatureLinesSigned,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  msoSignatureSubsetSignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  msoSignatureSubsetAll
}
