namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of a signature provider.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.SignatureProviderDetail")]
public enum SignatureProviderDetail
{
  /// <summary>
  /// The URL of the signature provider.
  /// </summary>
  [InteropEnumValue("sigprovdetUrl")]
  Url,
  /// <summary>
  /// Hash algorithm used to hash the data in the file.
  /// </summary>
  [InteropEnumValue("sigprovdetHashAlgorithm")]
  HashAlgorithm,
  /// <summary>
  /// Indicates that the signature provider only uses a custom user interface.
  /// </summary>
  [InteropEnumValue("sigprovdetUIOnly")]
  UIOnly,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("sigprovdetUseOfficeUI")]
  UseOfficeUI,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("sigprovdetUseOfficeStampUI")]
  UseOfficeStampUI
}
