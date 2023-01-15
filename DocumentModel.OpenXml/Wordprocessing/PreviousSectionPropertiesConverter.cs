using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Columns = DocumentModel.Wordprocessing.Columns;
using DocGrid = DocumentModel.Wordprocessing.DocGrid;
using EndnoteProperties = DocumentModel.Wordprocessing.EndnoteProperties;
using FootnoteProperties = DocumentModel.Wordprocessing.FootnoteProperties;
using LineNumberType = DocumentModel.Wordprocessing.LineNumberType;
using PageBorders = DocumentModel.Wordprocessing.PageBorders;
using PageMargin = DocumentModel.Wordprocessing.PageMargin;
using PageNumberType = DocumentModel.Wordprocessing.PageNumberType;
using PageSize = DocumentModel.Wordprocessing.PageSize;
using PaperSource = DocumentModel.Wordprocessing.PaperSource;
using PreviousSectionProperties = DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Previous Section Properties.
/// </summary>
public static class PreviousSectionPropertiesConverter
{
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public static Byte[]? GetRsidRPr(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidRPr.Value);
    return null;
  }

  public static void SetRsidRPr(PreviousSectionProperties? openXmlElement, Byte[]? value)
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
  public static Byte[]? GetRsidDel(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidDel.Value);
    return null;
  }

  public static void SetRsidDel(PreviousSectionProperties? openXmlElement, Byte[]? value)
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
  public static Byte[]? GetRsidR(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidR.Value);
    return null;
  }

  public static void SetRsidR(PreviousSectionProperties? openXmlElement, Byte[]? value)
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
  public static Byte[]? GetRsidSect(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidSect.Value);
    return null;
  }

  public static void SetRsidSect(PreviousSectionProperties? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidSect = Convert.ToHexString(value);
      else
        openXmlElement.RsidSect = null;
    }
  }

  /// <summary>
  ///   FootnoteProperties.
  /// </summary>
  public static FootnoteProperties? GetFootnoteProperties(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
    if (itemElement != null)
      return FootnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFootnoteProperties(PreviousSectionProperties? openXmlElement, FootnoteProperties? value)
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

  /// <summary>
  ///   EndnoteProperties.
  /// </summary>
  public static EndnoteProperties? GetEndnoteProperties(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
    if (itemElement != null)
      return EndnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndnoteProperties(PreviousSectionProperties? openXmlElement, EndnoteProperties? value)
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

  /// <summary>
  ///   SectionType.
  /// </summary>
  public static SectionMarkKind? GetSectionType(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SectionType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<SectionMarkValues, SectionMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSectionType(PreviousSectionProperties? openXmlElement, SectionMarkKind? value)
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

  /// <summary>
  ///   PageSize.
  /// </summary>
  public static PageSize? GetPageSize(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
    if (itemElement != null)
      return PageSizeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageSize(PreviousSectionProperties? openXmlElement, PageSize? value)
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

  /// <summary>
  ///   PageMargin.
  /// </summary>
  public static PageMargin? GetPageMargin(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
    if (itemElement != null)
      return PageMarginConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageMargin(PreviousSectionProperties? openXmlElement, PageMargin? value)
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

  /// <summary>
  ///   PaperSource.
  /// </summary>
  public static PaperSource? GetPaperSource(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
    if (itemElement != null)
      return PaperSourceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPaperSource(PreviousSectionProperties? openXmlElement, PaperSource? value)
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

  /// <summary>
  ///   PageBorders.
  /// </summary>
  public static PageBorders? GetPageBorders(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
    if (itemElement != null)
      return PageBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageBorders(PreviousSectionProperties? openXmlElement, PageBorders? value)
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

  /// <summary>
  ///   LineNumberType.
  /// </summary>
  public static LineNumberType? GetLineNumberType(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
    if (itemElement != null)
      return LineNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineNumberType(PreviousSectionProperties? openXmlElement, LineNumberType? value)
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

  /// <summary>
  ///   PageNumberType.
  /// </summary>
  public static PageNumberType? GetPageNumberType(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
    if (itemElement != null)
      return PageNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPageNumberType(PreviousSectionProperties? openXmlElement, PageNumberType? value)
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

  /// <summary>
  ///   Columns.
  /// </summary>
  public static Columns? GetColumns(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
    if (itemElement != null)
      return ColumnsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColumns(PreviousSectionProperties? openXmlElement, Columns? value)
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

  /// <summary>
  ///   FormProtection.
  /// </summary>
  public static Boolean? GetFormProtection(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormProtection>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFormProtection(PreviousSectionProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public static VerticalJustificationKind? GetVerticalTextAlignmentOnPage(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignmentOnPage>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalJustificationValues, VerticalJustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalTextAlignmentOnPage(PreviousSectionProperties? openXmlElement, VerticalJustificationKind? value)
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

  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public static Boolean? GetNoEndnote(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoEndnote>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoEndnote(PreviousSectionProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   TitlePage.
  /// </summary>
  public static Boolean? GetTitlePage(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TitlePage>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTitlePage(PreviousSectionProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   TextDirection.
  /// </summary>
  public static TextDirectionKind? GetTextDirection(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextDirectionValues, TextDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextDirection(PreviousSectionProperties? openXmlElement, TextDirectionKind? value)
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

  /// <summary>
  ///   BiDi.
  /// </summary>
  public static Boolean? GetBiDi(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBiDi(PreviousSectionProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public static Boolean? GetGutterOnRight(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GutterOnRight>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGutterOnRight(PreviousSectionProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   DocGrid.
  /// </summary>
  public static DocGrid? GetDocGrid(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
    if (itemElement != null)
      return DocGridConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocGrid(PreviousSectionProperties? openXmlElement, DocGrid? value)
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

  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public static RelationshipType? GetPrinterSettingsReference(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PrinterSettingsReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPrinterSettingsReference(PreviousSectionProperties? openXmlElement, RelationshipType? value)
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

  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public static Int32? GetFootnoteColumns(PreviousSectionProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FootnoteColumns>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFootnoteColumns(PreviousSectionProperties? openXmlElement, Int32? value)
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

  public static DocumentModel.Wordprocessing.PreviousSectionProperties? CreateModelElement(PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousSectionProperties();
      value.RsidRPr = GetRsidRPr(openXmlElement);
      value.RsidDel = GetRsidDel(openXmlElement);
      value.RsidR = GetRsidR(openXmlElement);
      value.RsidSect = GetRsidSect(openXmlElement);
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
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousSectionProperties? value)
    where OpenXmlElementType : PreviousSectionProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRPr(openXmlElement, value?.RsidRPr);
      SetRsidDel(openXmlElement, value?.RsidDel);
      SetRsidR(openXmlElement, value?.RsidR);
      SetRsidSect(openXmlElement, value?.RsidSect);
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
      return openXmlElement;
    }
    return default;
  }
}