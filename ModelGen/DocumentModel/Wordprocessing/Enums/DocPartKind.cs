namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocPartValues enumeration.
/// </summary>
public enum DocPartKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  [EnumString("normal")]
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autoExp&quot;.
  /// </summary>
  [EnumString("autoExp")]
  AutoExp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;toolbar&quot;.
  /// </summary>
  [EnumString("toolbar")]
  Toolbar,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;speller&quot;.
  /// </summary>
  [EnumString("speller")]
  Speller,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;formFld&quot;.
  /// </summary>
  [EnumString("formFld")]
  FormField,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bbPlcHdr&quot;.
  /// </summary>
  [EnumString("bbPlcHdr")]
  SdtPlaceholder,
  
}
