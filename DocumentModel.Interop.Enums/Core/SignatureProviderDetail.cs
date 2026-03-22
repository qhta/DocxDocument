namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of a signature provider.
/// </summary>
public enum SignatureProviderDetail
{
  /// <summary>
  /// The URL of the signature provider. sigprovdetHashAlgorithm1 Hash algorithm used to hash the data in the file.
  /// </summary>
  sigprovdetUrl,
  /// <summary>
  /// Specifies properties of a signature provider.
  /// </summary>
  sigprovdetHashAlgorithm,
  /// <summary>
  /// Indicates that the signature provider only uses a custom user interface.
  /// </summary>
  sigprovdetUIOnly,
  /// <summary>
  /// sigprovdetUseOfficeStampUI4
  /// </summary>
  sigprovdetUseOfficeUI,
  /// <summary>
  /// Specifies properties of a signature provider.
  /// </summary>
  sigprovdetUseOfficeStampUI
}
