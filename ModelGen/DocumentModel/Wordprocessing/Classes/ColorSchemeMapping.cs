namespace DocumentModel.Wordprocessing;


/// <summary>
///   Theme Color Mappings.
/// </summary>
public partial class ColorSchemeMapping
{
  
  /// <summary>
  ///   Background 1 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:bg1")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Background1 { get; set; }
  
  
  /// <summary>
  ///   Text 1 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:t1")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Text1 { get; set; }
  
  
  /// <summary>
  ///   Background 2 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:bg2")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Background2 { get; set; }
  
  
  /// <summary>
  ///   Text 2 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:t2")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Text2 { get; set; }
  
  
  /// <summary>
  ///   Accent 1 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent1")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent1 { get; set; }
  
  
  /// <summary>
  ///   Accent 2 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent2")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent2 { get; set; }
  
  
  /// <summary>
  ///   Accent3 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent3")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent3 { get; set; }
  
  
  /// <summary>
  ///   Accent4 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent4")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent4 { get; set; }
  
  
  /// <summary>
  ///   Accent5 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent5")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent5 { get; set; }
  
  
  /// <summary>
  ///   Accent6 Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:accent6")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Accent6 { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:hyperlink")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? Hyperlink { get; set; }
  
  
  /// <summary>
  ///   Followed Hyperlink Theme Color Mapping
  /// </summary>
  [SchemaAttr("w:followedHyperlink")]
  public DocumentModel.Wordprocessing.ColorSchemeIndexValues? FollowedHyperlink { get; set; }
  
}
