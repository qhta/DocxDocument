namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Series Class.
/// </summary>
public interface ISeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx { get ; set; }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FormatIdx { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public IValueColors? ValueColors { get ; set; }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public IValueColorPositions? ValueColorPositions { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public UInt32? DataId { get ; set; }
  
  public ISeriesLayoutProperties? SeriesLayoutProperties { get ; set; }
  
  public Collection<String>? AxisIds { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
