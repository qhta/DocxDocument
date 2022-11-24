namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
public interface IBackground // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? Fillcolor { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public ScreenSizeValues? TargetScreenSize { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public IFill? Fill { get ; set; }
  
}
