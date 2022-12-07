namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public class BinningImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>, Binning
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public IntervalClosedSide? IntervalClosed
  {
    get => (IntervalClosedSide?)OpenXmlElement?.IntervalClosed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IntervalClosed = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide?)value;
    }
  }
  
}
