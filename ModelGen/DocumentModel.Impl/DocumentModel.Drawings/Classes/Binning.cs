namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public class BinningImpl: ModelElementImpl, Binning
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Underflow
  {
    get;
    set;
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Overflow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  public String? Xsddouble
  {
    get;
    set;
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public String? BinCountXsdunsignedInt
  {
    get;
    set;
  }
  
}
