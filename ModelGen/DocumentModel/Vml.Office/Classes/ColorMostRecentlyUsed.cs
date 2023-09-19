namespace DocumentModel.Vml.Office;


/// <summary>
///   Most Recently Used Colors.
/// </summary>
public partial class ColorMostRecentlyUsed
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Recent colors
  /// </summary>
  [SchemaAttr("colors")]
  public String? Colors { get; set; }
  
}
