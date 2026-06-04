namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("EncryptionProviderDetail")]
public enum EncryptionProviderDetail
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("encprovdetUrl")]
  Url,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("encprovdetAlgorithm")]
  Algorithm,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("encprovdetBlockCipher")]
  BlockCipher,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("encprovdetCipherBlockSize")]
  CipherBlockSize,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("encprovdetCipherMode")]
  CipherMode
}
