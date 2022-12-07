namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public class PreviousSectionPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>, PreviousSectionProperties
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
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public FootnoteProperties? FootnoteProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public EndnoteProperties? EndnoteProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// SectionType.
  /// </summary>
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
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public PageSize? PageSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public PageMargin? PageMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public PaperSource? PaperSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public PageBorders? PageBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public LineNumberType? LineNumberType
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public PageNumberType? PageNumberType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public Columns? Columns
  {
    get;
    set;
  }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
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
  
  /// <summary>
  /// TextDirection.
  /// </summary>
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
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public DocGrid? DocGrid
  {
    get;
    set;
  }
  
}
