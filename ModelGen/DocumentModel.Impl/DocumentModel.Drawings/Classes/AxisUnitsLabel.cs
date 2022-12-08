namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public class AxisUnitsLabelImpl: ModelElementImpl, AxisUnitsLabel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text1? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody
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
