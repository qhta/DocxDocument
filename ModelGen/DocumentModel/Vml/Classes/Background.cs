namespace DocumentModel.Vml;


/// <summary>
///   Document Background.
/// </summary>
public partial class Background
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [SchemaAttr("fill")]
  public Boolean? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [SchemaAttr("fillcolor")]
  public String? Fillcolor { get; set; }
  
  
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwmode")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwpure")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? PureBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwnormal")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? NormalBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Target Screen Size
  /// </summary>
  [SchemaAttr("o:targetscreensize")]
  public DocumentModel.Vml.Office.ScreenSizeValues? TargetScreenSize { get; set; }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill { get; set; }
  
}
