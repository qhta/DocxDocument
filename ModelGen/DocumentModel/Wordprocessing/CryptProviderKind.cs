namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
public enum CryptProviderKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rsaAES&quot;.
  /// </summary>
  RsaAdvancedEncryptionStandard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rsaFull&quot;.
  /// </summary>
  RsaFull,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  Custom,
  
}
