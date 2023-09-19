namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public partial class ColorMappingType
{
  
  /// <summary>
  ///   Background 1
  /// </summary>
  [SchemaAttr("bg1")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Background1 { get; set; }
  
  
  /// <summary>
  ///   Text 1
  /// </summary>
  [SchemaAttr("tx1")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Text1 { get; set; }
  
  
  /// <summary>
  ///   Background 2
  /// </summary>
  [SchemaAttr("bg2")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Background2 { get; set; }
  
  
  /// <summary>
  ///   Text 2
  /// </summary>
  [SchemaAttr("tx2")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Text2 { get; set; }
  
  
  /// <summary>
  ///   Accent 1
  /// </summary>
  [SchemaAttr("accent1")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent1 { get; set; }
  
  
  /// <summary>
  ///   Accent 2
  /// </summary>
  [SchemaAttr("accent2")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent2 { get; set; }
  
  
  /// <summary>
  ///   Accent 3
  /// </summary>
  [SchemaAttr("accent3")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent3 { get; set; }
  
  
  /// <summary>
  ///   Accent 4
  /// </summary>
  [SchemaAttr("accent4")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent4 { get; set; }
  
  
  /// <summary>
  ///   Accent 5
  /// </summary>
  [SchemaAttr("accent5")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent5 { get; set; }
  
  
  /// <summary>
  ///   Accent 6
  /// </summary>
  [SchemaAttr("accent6")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Accent6 { get; set; }
  
  
  /// <summary>
  ///   Hyperlink
  /// </summary>
  [SchemaAttr("hlink")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? Hyperlink { get; set; }
  
  
  /// <summary>
  ///   Followed Hyperlink
  /// </summary>
  [SchemaAttr("folHlink")]
  public DocumentModel.Drawings.ColorSchemeIndexValues? FollowedHyperlink { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
