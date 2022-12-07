namespace DocumentModel.Vml;

/// <summary>
/// Shape Definition.
/// </summary>
public interface Shape
{
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public ConnectorKind? ConnectorType { get ; set; }
  
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
  
}
