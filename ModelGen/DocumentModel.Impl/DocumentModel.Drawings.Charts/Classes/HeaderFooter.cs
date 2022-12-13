namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public class HeaderFooterImpl: ModelElementImpl, HeaderFooter
{
  public DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HeaderFooterImpl(): base() {}
  
  public HeaderFooterImpl(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Align With Margins
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
  /// Different Odd Even
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
  /// Different First
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
  /// Odd Header.
  /// </summary>
  public String? OddHeader
  {
    get => (System.String?)OpenXmlElement?.OddHeader?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OddHeader != null)
        {
          if (value is not null)
            OpenXmlElement.OddHeader.Text = value;
          else
            OpenXmlElement.OddHeader = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OddHeader = new DocumentFormat.OpenXml.Drawing.Charts.OddHeader{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public String? OddFooter
  {
    get => (System.String?)OpenXmlElement?.OddFooter?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OddFooter != null)
        {
          if (value is not null)
            OpenXmlElement.OddFooter.Text = value;
          else
            OpenXmlElement.OddFooter = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OddFooter = new DocumentFormat.OpenXml.Drawing.Charts.OddFooter{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public String? EvenHeader
  {
    get => (System.String?)OpenXmlElement?.EvenHeader?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EvenHeader != null)
        {
          if (value is not null)
            OpenXmlElement.EvenHeader.Text = value;
          else
            OpenXmlElement.EvenHeader = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EvenHeader = new DocumentFormat.OpenXml.Drawing.Charts.EvenHeader{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public String? EvenFooter
  {
    get => (System.String?)OpenXmlElement?.EvenFooter?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EvenFooter != null)
        {
          if (value is not null)
            OpenXmlElement.EvenFooter.Text = value;
          else
            OpenXmlElement.EvenFooter = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EvenFooter = new DocumentFormat.OpenXml.Drawing.Charts.EvenFooter{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public String? FirstHeader
  {
    get => (System.String?)OpenXmlElement?.FirstHeader?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FirstHeader != null)
        {
          if (value is not null)
            OpenXmlElement.FirstHeader.Text = value;
          else
            OpenXmlElement.FirstHeader = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FirstHeader = new DocumentFormat.OpenXml.Drawing.Charts.FirstHeader{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public String? FirstFooter
  {
    get => (System.String?)OpenXmlElement?.FirstFooter?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FirstFooter != null)
        {
          if (value is not null)
            OpenXmlElement.FirstFooter.Text = value;
          else
            OpenXmlElement.FirstFooter = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FirstFooter = new DocumentFormat.OpenXml.Drawing.Charts.FirstFooter{ Text = value };
        }
      }
    }
  }
  
}
