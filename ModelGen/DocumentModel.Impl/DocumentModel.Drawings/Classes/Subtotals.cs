namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Subtotals Class.
/// </summary>
public class SubtotalsImpl: ModelElementImpl, Subtotals
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubtotalsImpl(): base() {}
  
  public SubtotalsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<UInt32>? UnsignedIntegerTypes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
