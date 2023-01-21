namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  private static UInt32? GetRsidRPr(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidRPr?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRPr.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidRPr(DXW.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidRPr = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidRPr = null;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  private static UInt32? GetRsidDel(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidDel?.Value != null)
      return UInt32.Parse(openXmlElement.RsidDel.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidDel(DXW.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidDel = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidDel = null;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  private static UInt32? GetRsidR(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidR?.Value != null)
      return UInt32.Parse(openXmlElement.RsidR.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidR(DXW.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidR = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidR = null;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  private static UInt32? GetRsidSect(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement.RsidSect?.Value != null)
      return UInt32.Parse(openXmlElement.RsidSect.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidSect(DXW.SectionProperties openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidSect = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidSect = null;
  }
  
  private static DMW.HeaderFooterReferenceType? GetHeaderReference(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.HeaderReference>();
    if (itemElement != null)
      return DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeaderReference(DXW.SectionProperties openXmlElement, DMW.HeaderFooterReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HeaderReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<DXW.HeaderReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.HeaderFooterReferenceType? GetFooterReference(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FooterReference>();
    if (itemElement != null)
      return DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFooterReference(DXW.SectionProperties openXmlElement, DMW.HeaderFooterReferenceType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FooterReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement<DXW.FooterReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FootnoteProperties? GetFootnoteProperties(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FootnoteProperties>();
    if (itemElement != null)
      return DMXW.FootnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFootnoteProperties(DXW.SectionProperties openXmlElement, DMW.FootnoteProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FootnotePropertiesConverter.CreateOpenXmlElement<DXW.FootnoteProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.EndnoteProperties? GetEndnoteProperties(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EndnoteProperties>();
    if (itemElement != null)
      return DMXW.EndnotePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndnoteProperties(DXW.SectionProperties openXmlElement, DMW.EndnoteProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnoteProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EndnotePropertiesConverter.CreateOpenXmlElement<DXW.EndnoteProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SectionMarkKind? GetSectionType(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSectionType(DXW.SectionProperties openXmlElement, DMW.SectionMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.SectionType, DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PageSize? GetPageSize(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PageSize>();
    if (itemElement != null)
      return DMXW.PageSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageSize(DXW.SectionProperties openXmlElement, DMW.PageSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PageSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PageSizeConverter.CreateOpenXmlElement<DXW.PageSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PageMargin? GetPageMargin(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PageMargin>();
    if (itemElement != null)
      return DMXW.PageMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageMargin(DXW.SectionProperties openXmlElement, DMW.PageMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PageMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PageMarginConverter.CreateOpenXmlElement<DXW.PageMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PaperSource? GetPaperSource(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PaperSource>();
    if (itemElement != null)
      return DMXW.PaperSourceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPaperSource(DXW.SectionProperties openXmlElement, DMW.PaperSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PaperSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PaperSourceConverter.CreateOpenXmlElement<DXW.PaperSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PageBorders? GetPageBorders(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PageBorders>();
    if (itemElement != null)
      return DMXW.PageBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageBorders(DXW.SectionProperties openXmlElement, DMW.PageBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PageBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PageBordersConverter.CreateOpenXmlElement<DXW.PageBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.LineNumberType? GetLineNumberType(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LineNumberType>();
    if (itemElement != null)
      return DMXW.LineNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineNumberType(DXW.SectionProperties openXmlElement, DMW.LineNumberType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LineNumberType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LineNumberTypeConverter.CreateOpenXmlElement<DXW.LineNumberType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PageNumberType? GetPageNumberType(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PageNumberType>();
    if (itemElement != null)
      return DMXW.PageNumberTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPageNumberType(DXW.SectionProperties openXmlElement, DMW.PageNumberType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PageNumberType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PageNumberTypeConverter.CreateOpenXmlElement<DXW.PageNumberType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Columns? GetColumns(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Columns>();
    if (itemElement != null)
      return DMXW.ColumnsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColumns(DXW.SectionProperties openXmlElement, DMW.Columns? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Columns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColumnsConverter.CreateOpenXmlElement<DXW.Columns>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetFormProtection(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FormProtection>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetFormProtection(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.FormProtection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.FormProtection();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.VerticalJustificationKind? GetVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement, DMW.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignmentOnPage, DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoEndnote(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoEndnote>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoEndnote(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoEndnote>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoEndnote();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTitlePage(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TitlePage>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetTitlePage(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TitlePage>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TitlePage();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextDirectionKind? GetTextDirection(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextDirection(DXW.SectionProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBiDi(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BiDi>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBiDi(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BiDi();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGutterOnRight(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.GutterOnRight>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetGutterOnRight(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.GutterOnRight>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.GutterOnRight();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DocGrid? GetDocGrid(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocGrid>();
    if (itemElement != null)
      return DMXW.DocGridConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocGrid(DXW.SectionProperties openXmlElement, DMW.DocGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocGridConverter.CreateOpenXmlElement<DXW.DocGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetPrinterSettingsReference(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PrinterSettingsReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrinterSettingsReference(DXW.SectionProperties openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrinterSettingsReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.PrinterSettingsReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetFootnoteColumns(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFootnoteColumns(DXW.SectionProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.FootnoteColumns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013W.FootnoteColumns{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SectionPropertiesChange? GetSectionPropertiesChange(DXW.SectionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SectionPropertiesChange>();
    if (itemElement != null)
      return DMXW.SectionPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSectionPropertiesChange(DXW.SectionProperties openXmlElement, DMW.SectionPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SectionPropertiesChangeConverter.CreateOpenXmlElement<DXW.SectionPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SectionProperties? CreateModelElement(DXW.SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SectionProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SectionProperties? value)
    where OpenXmlElementType: DXW.SectionProperties, new()
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
