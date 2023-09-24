namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
public enum CryptAlgorithmClassKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hash&quot;.
  /// </summary>
  [EnumString("hash")]
  Hash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("custom")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  Custom,
  
}
