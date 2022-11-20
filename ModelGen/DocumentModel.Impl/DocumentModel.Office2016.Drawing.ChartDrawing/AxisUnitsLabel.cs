namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IText))]
public class AxisUnitsLabel: IAxisUnitsLabel
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IText? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public ITxPrTextBody? TxPrTextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
