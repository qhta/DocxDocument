namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters for signature sets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosignaturesubset?view=office-pia` for Office interop details.
/// </remarks>
public enum SignatureSubset
{
  /// <summary>
  /// All non-visible signatures plus all signed signature lines.
  /// </summary>
  SignaturesAllSigs,
  /// <summary>
  /// All non-visible signatures.
  /// </summary>
  SignaturesNonVisible,
  /// <summary>
  /// All signature lines.
  /// </summary>
  SignatureLines,
  /// <summary>
  /// Signature lines that have been signed.
  /// </summary>
  SignatureLinesSigned,
  /// <summary>
  /// Signature lines that have not been signed.
  /// </summary>
  SignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  All
}
