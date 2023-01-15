using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Columns = DocumentModel.Wordprocessing.Columns;
using DocGrid = DocumentModel.Wordprocessing.DocGrid;
using EndnoteProperties = DocumentModel.Wordprocessing.EndnoteProperties;
using FootnoteProperties = DocumentModel.Wordprocessing.FootnoteProperties;
using HeaderFooterReferenceType = DocumentModel.Wordprocessing.HeaderFooterReferenceType;
using LineNumberType = DocumentModel.Wordprocessing.LineNumberType;
using PageBorders = DocumentModel.Wordprocessing.PageBorders;
using PageMargin = DocumentModel.Wordprocessing.PageMargin;
using PageNumberType = DocumentModel.Wordprocessing.PageNumberType;
using PageSize = DocumentModel.Wordprocessing.PageSize;
using PaperSource = DocumentModel.Wordprocessing.PaperSource;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;
using SectionProperties = DocumentFormat.OpenXml.Wordprocessing.SectionProperties;
using SectionPropertiesChange = DocumentModel.Wordprocessing.SectionPropertiesChange;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public static Byte[]? GetRsidRPr(SectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRPr.Value);
    return null;
  }

  public static void SetRsidRPr(SectionProperties? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidRPr = Convert.ToHexString(value);
      else
        openXmlElement.RsidRPr = null;
    }
  }

  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  public static Byte[]? GetRsidDel(SectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidDel.Value);
    return null;
  }

  public static void SetRsidDel(SectionProperties? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidDel = Convert.ToHexString(value);
      else
        openXmlElement.RsidDel = null;
    }
  }

  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  public static Byte[]? GetRsidR(SectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidR.Value);
    return null;
  }

  public static void SetRsidR(SectionProperties? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidR = Convert.ToHexString(value);
      else
        openXmlElement.RsidR = null;
    }
  }

  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  public static Byte[]? GetRsidSect(SectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidSect.Value);
    return null;
  }

  public static void SetRsidSect(SectionProperties? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidSect = Convert.ToHexString(value);
      else
        openXmlElement.RsidSect = null;
    }
  }

  public static HeaderFooterReferenceType? GetHeaderReference(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HeaderReference>();
    if (itemElement != null)
      return HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeaderReference(SectionProperties? openXmlElement, HeaderFooterReferenceType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeaderReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<HeaderReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HeaderFooterReferenceType? GetFooterReference(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FooterReference>();
    if (itemElement != null)
      return HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFooterReference(SectionProperties? openXmlElement, HeaderFooterReferenceType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FooterReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<FooterReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FootnoteProperties? GetFootnoteProperties(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
    if (itemElement != null)
      return FootnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFootnoteProperties(SectionProperties? openXmlElement, FootnoteProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnotePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EndnoteProperties? GetEndnoteProperties(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
    if (itemElement != null)
      return EndnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndnoteProperties(SectionProperties? openXmlElement, EndnoteProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndnotePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SectionMarkKind? GetSectionType(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SectionType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<SectionMarkValues, SectionMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSectionType(SectionProperties? openXmlElement, SectionMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SectionType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SectionType, SectionMarkValues, SectionMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PageSize? GetPageSize(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
    if (itemElement != null)
      return PageSizeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageSize(SectionProperties? openXmlElement, PageSize? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageSize>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PageMargin? GetPageMargin(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
    if (itemElement != null)
      return PageMarginConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageMargin(SectionProperties? openXmlElement, PageMargin? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PaperSource? GetPaperSource(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
    if (itemElement != null)
      return PaperSourceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPaperSource(SectionProperties? openXmlElement, PaperSource? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PaperSourceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PaperSource>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PageBorders? GetPageBorders(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
    if (itemElement != null)
      return PageBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageBorders(SectionProperties? openXmlElement, PageBorders? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageBorders>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineNumberType? GetLineNumberType(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
    if (itemElement != null)
      return LineNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineNumberType(SectionProperties? openXmlElement, LineNumberType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineNumberTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PageNumberType? GetPageNumberType(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
    if (itemElement != null)
      return PageNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageNumberType(SectionProperties? openXmlElement, PageNumberType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageNumberTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Columns? GetColumns(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
    if (itemElement != null)
      return ColumnsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColumns(SectionProperties? openXmlElement, Columns? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Columns>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetFormProtection(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormProtection>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFormProtection(SectionProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<FormProtection>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new FormProtection();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static VerticalJustificationKind? GetVerticalTextAlignmentOnPage(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignmentOnPage>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalJustificationValues, VerticalJustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalTextAlignmentOnPage(SectionProperties? openXmlElement, VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignmentOnPage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<VerticalTextAlignmentOnPage, VerticalJustificationValues, VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoEndnote(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoEndnote>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoEndnote(SectionProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoEndnote>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoEndnote();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTitlePage(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TitlePage>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTitlePage(SectionProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TitlePage>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TitlePage();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextDirectionKind? GetTextDirection(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextDirectionValues, TextDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextDirection(SectionProperties? openXmlElement, TextDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextDirection, TextDirectionValues, TextDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBiDi(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBiDi(SectionProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BiDi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BiDi();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetGutterOnRight(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GutterOnRight>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGutterOnRight(SectionProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<GutterOnRight>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new GutterOnRight();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocGrid? GetDocGrid(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
    if (itemElement != null)
      return DocGridConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocGrid(SectionProperties? openXmlElement, DocGrid? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocGridConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelationshipType? GetPrinterSettingsReference(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PrinterSettingsReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPrinterSettingsReference(SectionProperties? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrinterSettingsReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<PrinterSettingsReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetFootnoteColumns(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FootnoteColumns>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFootnoteColumns(SectionProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FootnoteColumns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FootnoteColumns { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SectionPropertiesChange? GetSectionPropertiesChange(SectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>();
    if (itemElement != null)
      return SectionPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSectionPropertiesChange(SectionProperties? openXmlElement, SectionPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SectionPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SectionProperties? CreateModelElement(SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SectionProperties();
      value.RsidRPr = GetRsidRPr(openXmlElement);
      value.RsidDel = GetRsidDel(openXmlElement);
      value.RsidR = GetRsidR(openXmlElement);
      value.RsidSect = GetRsidSect(openXmlElement);
      value.HeaderReference = GetHeaderReference(openXmlElement);
      value.FooterReference = GetFooterReference(openXmlElement);
      value.FootnoteProperties = GetFootnoteProperties(openXmlElement);
      value.EndnoteProperties = GetEndnoteProperties(openXmlElement);
      value.SectionType = GetSectionType(openXmlElement);
      value.PageSize = GetPageSize(openXmlElement);
      value.PageMargin = GetPageMargin(openXmlElement);
      value.PaperSource = GetPaperSource(openXmlElement);
      value.PageBorders = GetPageBorders(openXmlElement);
      value.LineNumberType = GetLineNumberType(openXmlElement);
      value.PageNumberType = GetPageNumberType(openXmlElement);
      value.Columns = GetColumns(openXmlElement);
      value.FormProtection = GetFormProtection(openXmlElement);
      value.VerticalTextAlignmentOnPage = GetVerticalTextAlignmentOnPage(openXmlElement);
      value.NoEndnote = GetNoEndnote(openXmlElement);
      value.TitlePage = GetTitlePage(openXmlElement);
      value.TextDirection = GetTextDirection(openXmlElement);
      value.BiDi = GetBiDi(openXmlElement);
      value.GutterOnRight = GetGutterOnRight(openXmlElement);
      value.DocGrid = GetDocGrid(openXmlElement);
      value.PrinterSettingsReference = GetPrinterSettingsReference(openXmlElement);
      value.FootnoteColumns = GetFootnoteColumns(openXmlElement);
      value.SectionPropertiesChange = GetSectionPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SectionProperties? value)
    where OpenXmlElementType : SectionProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRPr(openXmlElement, value?.RsidRPr);
      SetRsidDel(openXmlElement, value?.RsidDel);
      SetRsidR(openXmlElement, value?.RsidR);
      SetRsidSect(openXmlElement, value?.RsidSect);
      SetHeaderReference(openXmlElement, value?.HeaderReference);
      SetFooterReference(openXmlElement, value?.FooterReference);
      SetFootnoteProperties(openXmlElement, value?.FootnoteProperties);
      SetEndnoteProperties(openXmlElement, value?.EndnoteProperties);
      SetSectionType(openXmlElement, value?.SectionType);
      SetPageSize(openXmlElement, value?.PageSize);
      SetPageMargin(openXmlElement, value?.PageMargin);
      SetPaperSource(openXmlElement, value?.PaperSource);
      SetPageBorders(openXmlElement, value?.PageBorders);
      SetLineNumberType(openXmlElement, value?.LineNumberType);
      SetPageNumberType(openXmlElement, value?.PageNumberType);
      SetColumns(openXmlElement, value?.Columns);
      SetFormProtection(openXmlElement, value?.FormProtection);
      SetVerticalTextAlignmentOnPage(openXmlElement, value?.VerticalTextAlignmentOnPage);
      SetNoEndnote(openXmlElement, value?.NoEndnote);
      SetTitlePage(openXmlElement, value?.TitlePage);
      SetTextDirection(openXmlElement, value?.TextDirection);
      SetBiDi(openXmlElement, value?.BiDi);
      SetGutterOnRight(openXmlElement, value?.GutterOnRight);
      SetDocGrid(openXmlElement, value?.DocGrid);
      SetPrinterSettingsReference(openXmlElement, value?.PrinterSettingsReference);
      SetFootnoteColumns(openXmlElement, value?.FootnoteColumns);
      SetSectionPropertiesChange(openXmlElement, value?.SectionPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}