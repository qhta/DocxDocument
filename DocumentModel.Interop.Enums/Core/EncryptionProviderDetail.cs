namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.EncryptionProviderDetail))]
public enum EncryptionProviderDetail
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.EncryptionProviderDetail.encprovdetUrl))]
  Url,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.EncryptionProviderDetail.encprovdetAlgorithm))]
  Algorithm,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.EncryptionProviderDetail.encprovdetBlockCipher))]
  BlockCipher,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.EncryptionProviderDetail.encprovdetCipherBlockSize))]
  CipherBlockSize,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.EncryptionProviderDetail.encprovdetCipherMode))]
  CipherMode
}
