namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint
{
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDCD16.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
