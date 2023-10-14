namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the DataLabels Class.
/// </summary>
public partial class DataLabels
{
  
  /// <summary>
  ///   pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelPos? Pos { get; set; }
  
  
  /// <summary>
  ///   NumberFormat.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumberFormat? NumberFormat { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  
  /// <summary>
  ///   DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? DataLabelVisibilities { get; set; }
  
  
  /// <summary>
  ///   SeparatorXsdstring.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.SeparatorXsdstring? SeparatorXsdstring { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
