namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextDirectionValues enumeration.
/// </summary>
public enum TextDirectionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrTb&quot;.
  /// </summary>
  LefToRightTopToBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tb&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  LeftToRightTopToBottom2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbRl&quot;.
  /// </summary>
  TopToBottomRightToLeft,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rl&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  TopToBottomRightToLeft2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;btLr&quot;.
  /// </summary>
  BottomToTopLeftToRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lr&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  BottomToTopLeftToRight2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrTbV&quot;.
  /// </summary>
  LefttoRightTopToBottomRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  LeftToRightTopToBottomRotated2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbRlV&quot;.
  /// </summary>
  TopToBottomRightToLeftRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rlV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  TopToBottomRightToLeftRotated2010,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbLrV&quot;.
  /// </summary>
  TopToBottomLeftToRightRotated,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lrV&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  TopToBottomLeftToRightRotated2010,
  
}
