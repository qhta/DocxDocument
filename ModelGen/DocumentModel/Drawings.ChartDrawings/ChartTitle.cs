namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the ChartTitle Class.
/// </summary>
public partial class ChartTitle
{
  
  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Overlay { get; set; }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Text? Text { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
