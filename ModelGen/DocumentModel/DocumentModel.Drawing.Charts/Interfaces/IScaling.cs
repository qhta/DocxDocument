namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scaling.
/// </summary>
public interface IScaling // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public System.Double? LogBase { get ; set; }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public DocumentModel.Drawing.Charts.OrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public System.Double? MaxAxisValue { get ; set; }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public System.Double? MinAxisValue { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
