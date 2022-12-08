namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public class OpenXmlGridlinesElementImpl: ModelElementImpl, OpenXmlGridlinesElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual ShapeProperties6? ShapeProperties
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
