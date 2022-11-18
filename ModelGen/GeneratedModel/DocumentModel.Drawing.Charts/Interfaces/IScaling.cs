namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scaling.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMaxAxisValue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinAxisValue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILogBase))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrientation))]
public interface IScaling // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
