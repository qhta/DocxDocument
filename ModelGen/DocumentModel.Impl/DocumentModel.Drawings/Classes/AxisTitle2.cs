namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public class AxisTitle2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>, AxisTitle2
{
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
  public ShapeProperties2? ShapeProperties
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
