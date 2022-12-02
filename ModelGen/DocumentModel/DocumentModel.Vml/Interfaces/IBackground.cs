namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
public interface IBackground // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public System.Boolean? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public System.String? Fillcolor { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public DocumentModel.Vml.ScreenSizeKind? TargetScreenSize { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
}
