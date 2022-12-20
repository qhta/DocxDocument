namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public partial interface DataLabels
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelPos? Pos { get; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumberFormat? NumberFormat { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? DataLabelVisibilities { get; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring { get; set; }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? Items { get; set; }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? DataLabelHiddens { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
