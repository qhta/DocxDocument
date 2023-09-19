namespace DXW;


/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
public enum CryptProviderValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rsaAES&quot;.
  /// </summary>
  [EnumString("rsaAES")]
  RsaAdvancedEncryptionStandard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rsaFull&quot;.
  /// </summary>
  [EnumString("rsaFull")]
  RsaFull,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("custom")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  Custom,
  
}
