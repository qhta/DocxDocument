namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  private static UInt32? GetRsidRPr(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidRPr?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRPr.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidRPr(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidRPr = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidRPr = null;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  private static UInt32? GetRsidDel(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidDel?.Value != null)
      return UInt32.Parse(openXmlElement.RsidDel.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidDel(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidDel = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidDel = null;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  private static UInt32? GetRsidR(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidR?.Value != null)
      return UInt32.Parse(openXmlElement.RsidR.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidR(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidR = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidR = null;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  private static UInt32? GetRsidSect(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidSect?.Value != null)
      return UInt32.Parse(openXmlElement.RsidSect.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidSect(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidSect = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidSect = null;
  }
  
  private static DocumentModel.Wordprocessing.HeaderFooterReferenceType? GetHeaderReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeaderReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HeaderReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.HeaderFooterReferenceType? GetFooterReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FooterReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFooterReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FooterReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FooterReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.FootnoteProperties? GetFootnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFootnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.FootnoteProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FootnotePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.EndnoteProperties? GetEndnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EndnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.EndnoteProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.EndnotePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SectionMarkKind? GetSectionType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DocumentModel.Wordprocessing.SectionMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSectionType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.SectionMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionType, DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DocumentModel.Wordprocessing.SectionMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PageSize? GetPageSize(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PageSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageSize(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.PageSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PageSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PageMargin? GetPageMargin(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PageMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageMargin(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.PageMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PageMarginConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PaperSource? GetPaperSource(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PaperSourceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPaperSource(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.PaperSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PaperSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PaperSourceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PaperSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PageBorders? GetPageBorders(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PageBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageBorders(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.PageBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PageBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.LineNumberType? GetLineNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LineNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.LineNumberType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.LineNumberTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PageNumberType? GetPageNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PageNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.PageNumberType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PageNumberTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Columns? GetColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColumnsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.Columns? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Columns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ColumnsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Columns>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetFormProtection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormProtection>();
    return itemElement != null;
  }
  
  private static void SetFormProtection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormProtection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.FormProtection();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.VerticalJustificationKind? GetVerticalTextAlignmentOnPage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DocumentModel.Wordprocessing.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalTextAlignmentOnPage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage, DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DocumentModel.Wordprocessing.VerticalJustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoEndnote(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoEndnote>();
    return itemElement != null;
  }
  
  private static void SetNoEndnote(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoEndnote>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoEndnote();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTitlePage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TitlePage>();
    return itemElement != null;
  }
  
  private static void SetTitlePage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TitlePage>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TitlePage();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextDirectionKind? GetTextDirection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextDirection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBiDi(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
    return itemElement != null;
  }
  
  private static void SetBiDi(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BiDi();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGutterOnRight(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>();
    return itemElement != null;
  }
  
  private static void SetGutterOnRight(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterOnRight>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.GutterOnRight();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DocGrid? GetDocGrid(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocGridConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocGrid(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.DocGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocGridConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.RelationshipType? GetPrinterSettingsReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrinterSettingsReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrinterSettingsReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrinterSettingsReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PrinterSettingsReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetFootnoteColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.FootnoteColumns>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFootnoteColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.FootnoteColumns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2013.Word.FootnoteColumns{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SectionPropertiesChange? GetSectionPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SectionPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSectionPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.SectionProperties openXmlElement, DocumentModel.Wordprocessing.SectionPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SectionPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SectionProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SectionProperties, new()
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
