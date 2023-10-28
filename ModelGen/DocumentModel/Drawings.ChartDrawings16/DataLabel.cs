namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public partial class DataLabel
{
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }
  
  
  /// <summary>
  ///   NumberFormat.
  /// </summary>
  public DMDCD16.NumberFormat? NumberFormat { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDCD16.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public DMDCD16.TxPrTextBody? TxPrTextBody { get; set; }
  
  
  /// <summary>
  ///   DataLabelVisibilities.
  /// </summary>
  public DMDCD16.DataLabelVisibilities? DataLabelVisibilities { get; set; }
  
  
  /// <summary>
  ///   SeparatorXsdstring.
  /// </summary>
  public DMDCD16.SeparatorXsdstring? SeparatorXsdstring { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
