namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of a signature provider.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
public enum SignatureProviderDetail
{
  /// <summary>
  /// The URL of the signature provider. sigprovdetHashAlgorithm1 Hash algorithm used to hash the data in the file.
  /// </summary>
  Url,
  /// <summary>
  /// Specifies properties of a signature provider.
  /// </summary>
  HashAlgorithm,
  /// <summary>
  /// Indicates that the signature provider only uses a custom user interface.
  /// </summary>
  UIOnly,
  /// <summary>
  /// sigprovdetUseOfficeStampUI4
  /// </summary>
  UseOfficeUI,
  /// <summary>
  /// Specifies properties of a signature provider.
  /// </summary>
  UseOfficeStampUI
}
