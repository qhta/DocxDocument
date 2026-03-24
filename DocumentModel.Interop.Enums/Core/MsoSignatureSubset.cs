namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters for signature sets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosignaturesubset?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoSignatureSubset
{
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  SignaturesAllSigs,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  SignaturesNonVisible,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  SignatureLines,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  SignatureLinesSigned,
  /// <summary>
  /// Specifies properties of the signature subset. These settings act as filters for signature sets.
  /// </summary>
  SignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  All
}
