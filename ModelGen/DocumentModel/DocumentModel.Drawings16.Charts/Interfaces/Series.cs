namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Series Class.
/// </summary>
public interface Series
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SeriesLayout? LayoutId { get ; set; }
  
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
  public DocumentModel.Drawings16.Charts.Text? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColors? ValueColors { get ; set; }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColorPositions? ValueColorPositions { get ; set; }
  
  public Collection<DocumentModel.Drawings16.Charts.DataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawings16.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt32? DataId { get ; set; }
  
  public DocumentModel.Drawings16.Charts.SeriesLayoutProperties? SeriesLayoutProperties { get ; set; }
  
  public Collection<System.String>? AxisIds { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
