namespace DocumentModel.Drawings;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public class FromAnchorImpl: DocumentModel.Drawings.MarkerTypeImpl, FromAnchor
{
  public new DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? XPosition
  {
    get;
    set;
  }
  
  public override String? YPosition
  {
    get;
    set;
  }
  
}
