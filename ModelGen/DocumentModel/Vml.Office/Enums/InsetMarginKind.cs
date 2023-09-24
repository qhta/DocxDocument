namespace DocumentModel.Vml.Office;


/// <summary>
///   Inset Margin Type
/// </summary>
public enum InsetMarginKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;.
  /// </summary>
  [EnumString("custom")]
  Custom,
  
}
