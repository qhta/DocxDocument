namespace DocumentModel.Drawings;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public class ToAnchorImpl: DocumentModel.Drawings.MarkerTypeImpl, ToAnchor
{
  public new DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor?)_OpenXmlElement;
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
