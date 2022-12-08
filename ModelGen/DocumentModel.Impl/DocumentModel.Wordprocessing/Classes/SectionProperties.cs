namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public class SectionPropertiesImpl: ModelElementImpl, SectionProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.SectionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SectionProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRPr
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidDel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidR
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidSect
  {
    get;
    set;
  }
  
  public Collection<HeaderFooterReferenceType>? HeaderReferences
  {
    get;
    set;
  }
  
  public Collection<HeaderFooterReferenceType>? FooterReferences
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
  
  public Boolean? FormProtection
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
  
  public Boolean? NoEndnote
  {
    get;
    set;
  }
  
  public Boolean? TitlePage
  {
    get;
    set;
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
  
  public Boolean? BiDi
  {
    get;
    set;
  }
  
  public Boolean? GutterOnRight
  {
    get;
    set;
  }
  
  public DocGrid? DocGrid
  {
    get;
    set;
  }
  
  public RelationshipType? PrinterSettingsReference
  {
    get;
    set;
  }
  
  public Int32? FootnoteColumns
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
