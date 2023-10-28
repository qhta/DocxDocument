namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Legend Class.
/// </summary>
public partial class Legend
{
  
  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Overlay { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDCD16.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public DMDCD16.TxPrTextBody? TxPrTextBody { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
