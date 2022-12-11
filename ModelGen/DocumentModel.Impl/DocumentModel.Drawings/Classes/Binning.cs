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
  
  public BinningImpl(): base() {}
  
  public BinningImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get => (String?)OpenXmlElement?.Underflow?.Value;
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
    get => (String?)OpenXmlElement?.Overflow?.Value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public String? BinCountXsdunsignedInt
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
