namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public partial class HeaderFooterImpl: ModelElementImpl, HeaderFooter
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HeaderFooterImpl(): base() {}
  
  public HeaderFooterImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AlignWithMargins
  {
    get => (System.Boolean?)OpenXmlElement?.AlignWithMargins?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlignWithMargins = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentOddEven
  {
    get => (System.Boolean?)OpenXmlElement?.DifferentOddEven?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DifferentOddEven = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? DifferentFirst
  {
    get => (System.Boolean?)OpenXmlElement?.DifferentFirst?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DifferentFirst = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  public String? OddHeaderXsdstring
  {
    get => (System.String?)OpenXmlElement?.OddHeaderXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OddHeaderXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.OddHeaderXsdstring.Text = value;
          else
            OpenXmlElement.OddHeaderXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OddHeaderXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public String? OddFooterXsdstring
  {
    get => (System.String?)OpenXmlElement?.OddFooterXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OddFooterXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.OddFooterXsdstring.Text = value;
          else
            OpenXmlElement.OddFooterXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OddFooterXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public String? EvenHeaderXsdstring
  {
    get => (System.String?)OpenXmlElement?.EvenHeaderXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EvenHeaderXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.EvenHeaderXsdstring.Text = value;
          else
            OpenXmlElement.EvenHeaderXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EvenHeaderXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public String? EvenFooterXsdstring
  {
    get => (System.String?)OpenXmlElement?.EvenFooterXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EvenFooterXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.EvenFooterXsdstring.Text = value;
          else
            OpenXmlElement.EvenFooterXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EvenFooterXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public String? FirstHeaderXsdstring
  {
    get => (System.String?)OpenXmlElement?.FirstHeaderXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FirstHeaderXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.FirstHeaderXsdstring.Text = value;
          else
            OpenXmlElement.FirstHeaderXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FirstHeaderXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public String? FirstFooterXsdstring
  {
    get => (System.String?)OpenXmlElement?.FirstFooterXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FirstFooterXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.FirstFooterXsdstring.Text = value;
          else
            OpenXmlElement.FirstFooterXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FirstFooterXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring{ Text = value };
        }
      }
    }
  }
  
}
