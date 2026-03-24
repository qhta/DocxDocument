namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.encryptionproviderdetail?view=office-pia` for Office interop details.
/// </remarks>
public enum EncryptionProviderDetail
{
  /// <summary>
  /// encprovdetAlgorithm 1
  /// </summary>
  Url,
  /// <summary>
  /// encprovdetBlockCipher 2
  /// </summary>
  Algorithm,
  /// <summary>
  /// encprovdetCipherBlockSize 3
  /// </summary>
  BlockCipher,
  /// <summary>
  /// encprovdetCipherMode 4
  /// </summary>
  CipherBlockSize,
  /// <summary>
  /// Applies to Product Versions Office primary interop assembly Latest public enum class EncryptionProviderDetail
  /// ﾉ Expand table
  /// </summary>
  CipherMode
}
