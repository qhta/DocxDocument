namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Series Class.
/// </summary>
public partial class Series
{
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get; set; }
  
  
  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx { get; set; }
  
  
  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? UniqueId { get; set; }
  
  
  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FormatIdx { get; set; }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  public DMDCD16.Text? Text { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDCD16.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   ValueColors.
  /// </summary>
  public DMDCD16.ValueColors? ValueColors { get; set; }
  
  
  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  public DMDCD16.ValueColorPositions? ValueColorPositions { get; set; }
  
  public DMDCD16.DataLabels? DataLabels { get; set; }
  
  public UInt32? DataId { get; set; }
  
  public DMDCD16.SeriesLayoutProperties? SeriesLayoutProperties { get; set; }
  
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
