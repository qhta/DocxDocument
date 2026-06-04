namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies properties of a signature provider.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("SignatureProviderDetail")]
public enum SignatureProviderDetail
{
  /// <summary>
  /// The URL of the signature provider.
  /// </summary>
  [OfficeInteropEnumValue("sigprovdetUrl")]
  Url,
  /// <summary>
  /// Hash algorithm used to hash the data in the file.
  /// </summary>
  [OfficeInteropEnumValue("sigprovdetHashAlgorithm")]
  HashAlgorithm,
  /// <summary>
  /// Indicates that the signature provider only uses a custom user interface.
  /// </summary>
  [OfficeInteropEnumValue("sigprovdetUIOnly")]
  UIOnly,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("sigprovdetUseOfficeUI")]
  UseOfficeUI,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("sigprovdetUseOfficeStampUI")]
  UseOfficeStampUI
}
