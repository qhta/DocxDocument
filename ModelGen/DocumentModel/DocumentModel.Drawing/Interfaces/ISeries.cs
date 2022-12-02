namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Series Class.
/// </summary>
public interface ISeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.SeriesLayout? LayoutId { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? OwnerIdx { get ; set; }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? FormatIdx { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawing.IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public DocumentModel.Drawing.IValueColors? ValueColors { get ; set; }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public DocumentModel.Drawing.IValueColorPositions? ValueColorPositions { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt32? DataId { get ; set; }
  
  public DocumentModel.Drawing.ISeriesLayoutProperties? SeriesLayoutProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
