namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public class SectionPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>, SectionProperties
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public String? RsidRPr
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public String? RsidDel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public String? RsidR
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public String? RsidSect
  {
    get;
    set;
  }
  
  public FootnoteProperties? FootnoteProperties
  {
    get;
    set;
  }
  
  public EndnoteProperties? EndnoteProperties
  {
    get;
    set;
  }
  
  public SectionMarkKind? SectionType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
        return (SectionMarkKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.SectionType{ Val = (DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public PageSize? PageSize
  {
    get;
    set;
  }
  
  public PageMargin? PageMargin
  {
    get;
    set;
  }
  
  public PaperSource? PaperSource
  {
    get;
    set;
  }
  
  public PageBorders? PageBorders
  {
    get;
    set;
  }
  
  public LineNumberType? LineNumberType
  {
    get;
    set;
  }
  
  public PageNumberType? PageNumberType
  {
    get;
    set;
  }
  
  public Columns? Columns
  {
    get;
    set;
  }
  
  public VerticalJustificationKind? VerticalTextAlignmentOnPage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
        return (VerticalJustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage{ Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public TextDirectionKind? TextDirection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
        return (TextDirectionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextDirection{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public DocGrid? DocGrid
  {
    get;
    set;
  }
  
  public SectionPropertiesChange? SectionPropertiesChange
  {
    get;
    set;
  }
  
}
