namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.IFill))]
public interface IBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public string? Fillcolor { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public ScreenSize? TargetScreenSize { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
}
