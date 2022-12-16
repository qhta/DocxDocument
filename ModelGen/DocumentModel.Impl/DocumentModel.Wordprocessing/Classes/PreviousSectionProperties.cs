namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public class PreviousSectionPropertiesImpl: ModelElementImpl, PreviousSectionProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreviousSectionPropertiesImpl(): base() {}
  
  public PreviousSectionPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public DocumentModel.HexBinary? RsidRPr
  {
    get
    {
      if (OpenXmlElement?.RsidRPr?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.RsidRPr.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.RsidRPr = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.RsidRPr = null;
      }
    }
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public DocumentModel.HexBinary? RsidDel
  {
    get
    {
      if (OpenXmlElement?.RsidDel?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.RsidDel.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.RsidDel = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.RsidDel = null;
      }
    }
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public DocumentModel.HexBinary? RsidR
  {
    get
    {
      if (OpenXmlElement?.RsidR?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.RsidR.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.RsidR = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.RsidR = null;
      }
    }
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public DocumentModel.HexBinary? RsidSect
  {
    get
    {
      if (OpenXmlElement?.RsidSect?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.RsidSect.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.RsidSect = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.RsidSect = null;
      }
    }
  }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteProperties? FootnoteProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FootnotePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FootnotePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnoteProperties? EndnoteProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.EndnotePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.EndnotePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SectionType.
  /// </summary>
  public DocumentModel.Wordprocessing.SectionMarkKind? SectionType
  {
    get => (DocumentModel.Wordprocessing.SectionMarkKind?)OpenXmlElement?.SectionType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SectionType != null)
        {
          if (value is not null)
            OpenXmlElement.SectionType.Val = (DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues?)value;
          else
            OpenXmlElement.SectionType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SectionType = new DocumentFormat.OpenXml.Wordprocessing.SectionType{ Val = (DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public DocumentModel.Wordprocessing.PageSize? PageSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PageSizeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PageSizeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.PageMargin? PageMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PageMarginImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PageMarginImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public DocumentModel.Wordprocessing.PaperSource? PaperSource
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PaperSourceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PaperSourceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorders? PageBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PageBordersImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PageBordersImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.LineNumberType? LineNumberType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LineNumberTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LineNumberTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.PageNumberType? PageNumberType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PageNumberTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PageNumberTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public DocumentModel.Wordprocessing.Columns? Columns
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ColumnsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ColumnsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// FormProtection.
  /// </summary>
  public Boolean? FormProtection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormProtection>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormProtection>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FormProtection();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage
  {
    get => (DocumentModel.Wordprocessing.VerticalJustificationKind?)OpenXmlElement?.VerticalTextAlignmentOnPage?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.VerticalTextAlignmentOnPage != null)
        {
          if (value is not null)
            OpenXmlElement.VerticalTextAlignmentOnPage.Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues?)value;
          else
            OpenXmlElement.VerticalTextAlignmentOnPage = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.VerticalTextAlignmentOnPage = new DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage{ Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  public Boolean? NoEndnote
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoEndnote>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoEndnote>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoEndnote();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  public Boolean? TitlePage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TitlePage>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TitlePage>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TitlePage();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection
  {
    get => (DocumentModel.Wordprocessing.TextDirectionKind?)OpenXmlElement?.TextDirection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextDirection != null)
        {
          if (value is not null)
            OpenXmlElement.TextDirection.Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value;
          else
            OpenXmlElement.TextDirection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextDirection = new DocumentFormat.OpenXml.Wordprocessing.TextDirection{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public Boolean? BiDi
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BiDi();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  public Boolean? GutterOnRight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.GutterOnRight();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.DocGrid? DocGrid
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocGridImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocGridImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? PrinterSettingsReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns
  {
    get => (System.Int32?)OpenXmlElement?.FootnoteColumns?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FootnoteColumns != null)
        {
          if (value is not null)
            OpenXmlElement.FootnoteColumns.Val = (System.Int32?)value;
          else
            OpenXmlElement.FootnoteColumns = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FootnoteColumns = new DocumentFormat.OpenXml.Office2013.Word.FootnoteColumns{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
}
