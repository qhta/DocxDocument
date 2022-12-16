namespace DocumentModel.Drawings.ChartDrawings;

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
  
  public BinningImpl(): base() {}
  
  public BinningImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.IntervalClosedSide? IntervalClosed
  {
    get => (DocumentModel.Drawings.ChartDrawings.IntervalClosedSide?)OpenXmlElement?.IntervalClosed?.Value;
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
    get => (System.String?)OpenXmlElement?.Underflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Underflow = (System.String?)value;
    }
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Overflow
  {
    get => (System.String?)OpenXmlElement?.Overflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Overflow = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  public String? Xsddouble
  {
    get => (System.String?)OpenXmlElement?.Xsddouble?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Xsddouble != null)
        {
          if (value is not null)
            OpenXmlElement.Xsddouble.Text = value;
          else
            OpenXmlElement.Xsddouble = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Xsddouble = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public String? BinCountXsdunsignedInt
  {
    get => (System.String?)OpenXmlElement?.BinCountXsdunsignedInt?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BinCountXsdunsignedInt != null)
        {
          if (value is not null)
            OpenXmlElement.BinCountXsdunsignedInt.Text = value;
          else
            OpenXmlElement.BinCountXsdunsignedInt = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BinCountXsdunsignedInt = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt{ Text = value };
        }
      }
    }
  }
  
}
