namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public class MajorGridlinesGridlinesImpl: DocumentModel.Drawings.OpenXmlGridlinesElementImpl, MajorGridlinesGridlines
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines?)_OpenXmlElement;
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
