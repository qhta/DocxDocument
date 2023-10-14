namespace DocumentModel.Vml;


/// <summary>
///   Document Background.
/// </summary>
public partial class Background
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  public String? Fillcolor { get; set; }
  
  
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Target Screen Size
  /// </summary>
  public DocumentModel.Vml.Office.ScreenSizeKind? TargetScreenSize { get; set; }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill { get; set; }
  
}
