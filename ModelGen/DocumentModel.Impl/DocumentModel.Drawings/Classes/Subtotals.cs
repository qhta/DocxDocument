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
  
  public Collection<UInt32>? UnsignedIntegerTypes
  {
    get;
    set;
  }
  
}
