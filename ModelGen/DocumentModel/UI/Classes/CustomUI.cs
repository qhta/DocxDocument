namespace DocumentModel.UI;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI
{
  
  /// <summary>
  ///   onLoad
  /// </summary>
  [SchemaAttr("onLoad")]
  public String? OnLoad { get; set; }
  
  
  /// <summary>
  ///   loadImage
  /// </summary>
  [SchemaAttr("loadImage")]
  public String? LoadImage { get; set; }
  
  
  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  public DocumentModel.UI.RepurposedCommands? RepurposedCommands { get; set; }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  public DocumentModel.UI.Ribbon? Ribbon { get; set; }
  
}
