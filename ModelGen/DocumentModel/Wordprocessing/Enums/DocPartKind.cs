namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocPartValues enumeration.
/// </summary>
public enum DocPartKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;normal&quot;.
  /// </summary>
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autoExp&quot;.
  /// </summary>
  AutoExp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;toolbar&quot;.
  /// </summary>
  Toolbar,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;speller&quot;.
  /// </summary>
  Speller,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;formFld&quot;.
  /// </summary>
  FormField,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bbPlcHdr&quot;.
  /// </summary>
  SdtPlaceholder,
  
}
