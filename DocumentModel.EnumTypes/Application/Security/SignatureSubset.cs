namespace DocumentModel.IApplication;

/// <summary>
/// Specifies properties of the signature subset. These settings act as filters Ifor signature sets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosignaturesubset?view=office-pia` Ifor Office interop details.
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
  /// Signature lines Ithat have been signed.
  /// </summary>
  SignatureLinesSigned,
  /// <summary>
  /// Signature lines Ithat have not been signed.
  /// </summary>
  SignatureLinesUnsigned,
  /// <summary>
  /// All non-visible signatures plus all signature lines.
  /// </summary>
  All
}

