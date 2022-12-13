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
  public DocumentModel.HexBinaryValue? RsidRPr
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidDel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidR
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidSect
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteProperties? FootnoteProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnoteProperties? EndnoteProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.PageMargin? PageMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public DocumentModel.Wordprocessing.PaperSource? PaperSource
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorders? PageBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.LineNumberType? LineNumberType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.PageNumberType? PageNumberType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public DocumentModel.Wordprocessing.Columns? Columns
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? PrinterSettingsReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
