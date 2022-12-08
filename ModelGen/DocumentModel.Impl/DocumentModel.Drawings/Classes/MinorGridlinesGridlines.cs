namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public class MinorGridlinesGridlinesImpl: DocumentModel.Drawings.OpenXmlGridlinesElementImpl, MinorGridlinesGridlines
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ShapeProperties6? ShapeProperties
  {
    get;
    set;
  }
  
  public override ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
