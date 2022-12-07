namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public class OpenXmlGridlinesElementImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement>, OpenXmlGridlinesElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
