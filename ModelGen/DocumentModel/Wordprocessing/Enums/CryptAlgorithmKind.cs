namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
public enum CryptAlgorithmKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;typeAny&quot;.
  /// </summary>
  [EnumString("typeAny")]
  TypeAny,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  [EnumString("custom")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  Custom,
  
}
