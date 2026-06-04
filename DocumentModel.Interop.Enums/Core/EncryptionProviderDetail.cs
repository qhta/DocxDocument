namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.EncryptionProviderDetail")]
public enum EncryptionProviderDetail
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("encprovdetUrl")]
  Url,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("encprovdetAlgorithm")]
  Algorithm,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("encprovdetBlockCipher")]
  BlockCipher,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("encprovdetCipherBlockSize")]
  CipherBlockSize,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("encprovdetCipherMode")]
  CipherMode
}
