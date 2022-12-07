namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public class DataPoint3Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>, DataPoint3
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
