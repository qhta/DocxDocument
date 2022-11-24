namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scaling.
/// </summary>
public interface IScaling // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public ILogBase? LogBase { get ; set; }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public IOrientation? Orientation { get ; set; }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public IMaxAxisValue? MaxAxisValue { get ; set; }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public IMinAxisValue? MinAxisValue { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
