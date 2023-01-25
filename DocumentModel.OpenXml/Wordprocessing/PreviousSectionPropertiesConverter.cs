namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public static class PreviousSectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  private static UInt32? GetRsidRPr(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRPr.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidRPr(DXW.PreviousSectionProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      if (UInt32.Parse(openXmlElement.RsidRPr.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.RsidRPr?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidRPr", openXmlElement?.RsidRPr?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetRsidRPr(DXW.PreviousSectionProperties openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.RsidRPr = ((UInt32)value).ToString("X8");
    else
      openXmlElement.RsidRPr = null;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  private static UInt32? GetRsidDel(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return UInt32.Parse(openXmlElement.RsidDel.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidDel(DXW.PreviousSectionProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      if (UInt32.Parse(openXmlElement.RsidDel.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.RsidDel?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidDel", openXmlElement?.RsidDel?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetRsidDel(DXW.PreviousSectionProperties openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.RsidDel = ((UInt32)value).ToString("X8");
    else
      openXmlElement.RsidDel = null;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  private static UInt32? GetRsidR(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return UInt32.Parse(openXmlElement.RsidR.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidR(DXW.PreviousSectionProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidR?.Value != null)
      if (UInt32.Parse(openXmlElement.RsidR.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.RsidR?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidR", openXmlElement?.RsidR?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetRsidR(DXW.PreviousSectionProperties openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.RsidR = ((UInt32)value).ToString("X8");
    else
      openXmlElement.RsidR = null;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  private static UInt32? GetRsidSect(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return UInt32.Parse(openXmlElement.RsidSect.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidSect(DXW.PreviousSectionProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      if (UInt32.Parse(openXmlElement.RsidSect.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.RsidSect?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidSect", openXmlElement?.RsidSect?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetRsidSect(DXW.PreviousSectionProperties openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.RsidSect = ((UInt32)value).ToString("X8");
    else
      openXmlElement.RsidSect = null;
  }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  private static DMW.FootnoteProperties? GetFootnoteProperties(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.FootnotePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FootnoteProperties>());
  }
  
  private static bool CmpFootnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.FootnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFootnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.FootnoteProperties? value)
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
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  private static DMW.EndnoteProperties? GetEndnoteProperties(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.EndnotePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EndnoteProperties>());
  }
  
  private static bool CmpEndnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.EndnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.EndnoteProperties? value)
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
  
  /// <summary>
  /// SectionType.
  /// </summary>
  private static DMW.SectionMarkKind? GetSectionType(DXW.PreviousSectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value);
  }
  
  private static bool CmpSectionType(DXW.PreviousSectionProperties openXmlElement, DMW.SectionMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSectionType(DXW.PreviousSectionProperties openXmlElement, DMW.SectionMarkKind? value)
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
  
  /// <summary>
  /// PageSize.
  /// </summary>
  private static DMW.PageSize? GetPageSize(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.PageSizeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PageSize>());
  }
  
  private static bool CmpPageSize(DXW.PreviousSectionProperties openXmlElement, DMW.PageSize? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageSize>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPageSize(DXW.PreviousSectionProperties openXmlElement, DMW.PageSize? value)
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
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  private static DMW.PageMargin? GetPageMargin(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.PageMarginConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PageMargin>());
  }
  
  private static bool CmpPageMargin(DXW.PreviousSectionProperties openXmlElement, DMW.PageMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageMargin>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPageMargin(DXW.PreviousSectionProperties openXmlElement, DMW.PageMargin? value)
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
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  private static DMW.PaperSource? GetPaperSource(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.PaperSourceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PaperSource>());
  }
  
  private static bool CmpPaperSource(DXW.PreviousSectionProperties openXmlElement, DMW.PaperSource? value, DiffList? diffs, string? objName)
  {
    return DMXW.PaperSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PaperSource>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPaperSource(DXW.PreviousSectionProperties openXmlElement, DMW.PaperSource? value)
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
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  private static DMW.PageBorders? GetPageBorders(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.PageBordersConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PageBorders>());
  }
  
  private static bool CmpPageBorders(DXW.PreviousSectionProperties openXmlElement, DMW.PageBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPageBorders(DXW.PreviousSectionProperties openXmlElement, DMW.PageBorders? value)
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
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  private static DMW.LineNumberType? GetLineNumberType(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.LineNumberTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.LineNumberType>());
  }
  
  private static bool CmpLineNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.LineNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LineNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LineNumberType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.LineNumberType? value)
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
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  private static DMW.PageNumberType? GetPageNumberType(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.PageNumberTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PageNumberType>());
  }
  
  private static bool CmpPageNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.PageNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageNumberType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPageNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.PageNumberType? value)
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
  
  /// <summary>
  /// Columns.
  /// </summary>
  private static DMW.Columns? GetColumns(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.ColumnsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Columns>());
  }
  
  private static bool CmpColumns(DXW.PreviousSectionProperties openXmlElement, DMW.Columns? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Columns>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColumns(DXW.PreviousSectionProperties openXmlElement, DMW.Columns? value)
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
  
  /// <summary>
  /// FormProtection.
  /// </summary>
  private static Boolean? GetFormProtection(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.FormProtection>()?.Val?.Value;
  }
  
  private static bool CmpFormProtection(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.FormProtection>()?.Val?.Value == value;
  }
  
  private static void SetFormProtection(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  private static DMW.VerticalJustificationKind? GetVerticalTextAlignmentOnPage(DXW.PreviousSectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value);
  }
  
  private static bool CmpVerticalTextAlignmentOnPage(DXW.PreviousSectionProperties openXmlElement, DMW.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalTextAlignmentOnPage(DXW.PreviousSectionProperties openXmlElement, DMW.VerticalJustificationKind? value)
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
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  private static Boolean? GetNoEndnote(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.NoEndnote>()?.Val?.Value;
  }
  
  private static bool CmpNoEndnote(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.NoEndnote>()?.Val?.Value == value;
  }
  
  private static void SetNoEndnote(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  private static Boolean? GetTitlePage(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TitlePage>()?.Val?.Value;
  }
  
  private static bool CmpTitlePage(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.TitlePage>()?.Val?.Value == value;
  }
  
  private static void SetTitlePage(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  private static DMW.TextDirectionKind? GetTextDirection(DXW.PreviousSectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }
  
  private static bool CmpTextDirection(DXW.PreviousSectionProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextDirection(DXW.PreviousSectionProperties openXmlElement, DMW.TextDirectionKind? value)
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
  
  /// <summary>
  /// BiDi.
  /// </summary>
  private static Boolean? GetBiDi(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value;
  }
  
  private static bool CmpBiDi(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value == value;
  }
  
  private static void SetBiDi(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  private static Boolean? GetGutterOnRight(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.GutterOnRight>()?.Val?.Value;
  }
  
  private static bool CmpGutterOnRight(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.GutterOnRight>()?.Val?.Value == value;
  }
  
  private static void SetGutterOnRight(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  private static DMW.DocGrid? GetDocGrid(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.DocGridConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocGrid>());
  }
  
  private static bool CmpDocGrid(DXW.PreviousSectionProperties openXmlElement, DMW.DocGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocGrid>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocGrid(DXW.PreviousSectionProperties openXmlElement, DMW.DocGrid? value)
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
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  private static DMW.RelationshipType? GetPrinterSettingsReference(DXW.PreviousSectionProperties openXmlElement)
  {
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PrinterSettingsReference>());
  }
  
  private static bool CmpPrinterSettingsReference(DXW.PreviousSectionProperties openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PrinterSettingsReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPrinterSettingsReference(DXW.PreviousSectionProperties openXmlElement, DMW.RelationshipType? value)
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
  
  /// <summary>
  /// FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  private static Int32? GetFootnoteColumns(DXW.PreviousSectionProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>()?.Val?.Value;
  }
  
  private static bool CmpFootnoteColumns(DXW.PreviousSectionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2013W.FootnoteColumns", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetFootnoteColumns(DXW.PreviousSectionProperties openXmlElement, Int32? value)
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
  
  public static DMW.PreviousSectionProperties? CreateModelElement(DXW.PreviousSectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousSectionProperties();
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
  
  public static bool CompareModelElement(DXW.PreviousSectionProperties? openXmlElement, DMW.PreviousSectionProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidRPr(openXmlElement, value.RsidRPr, diffs, objName))
        ok = false;
      if (!CmpRsidDel(openXmlElement, value.RsidDel, diffs, objName))
        ok = false;
      if (!CmpRsidR(openXmlElement, value.RsidR, diffs, objName))
        ok = false;
      if (!CmpRsidSect(openXmlElement, value.RsidSect, diffs, objName))
        ok = false;
      if (!CmpFootnoteProperties(openXmlElement, value.FootnoteProperties, diffs, objName))
        ok = false;
      if (!CmpEndnoteProperties(openXmlElement, value.EndnoteProperties, diffs, objName))
        ok = false;
      if (!CmpSectionType(openXmlElement, value.SectionType, diffs, objName))
        ok = false;
      if (!CmpPageSize(openXmlElement, value.PageSize, diffs, objName))
        ok = false;
      if (!CmpPageMargin(openXmlElement, value.PageMargin, diffs, objName))
        ok = false;
      if (!CmpPaperSource(openXmlElement, value.PaperSource, diffs, objName))
        ok = false;
      if (!CmpPageBorders(openXmlElement, value.PageBorders, diffs, objName))
        ok = false;
      if (!CmpLineNumberType(openXmlElement, value.LineNumberType, diffs, objName))
        ok = false;
      if (!CmpPageNumberType(openXmlElement, value.PageNumberType, diffs, objName))
        ok = false;
      if (!CmpColumns(openXmlElement, value.Columns, diffs, objName))
        ok = false;
      if (!CmpFormProtection(openXmlElement, value.FormProtection, diffs, objName))
        ok = false;
      if (!CmpVerticalTextAlignmentOnPage(openXmlElement, value.VerticalTextAlignmentOnPage, diffs, objName))
        ok = false;
      if (!CmpNoEndnote(openXmlElement, value.NoEndnote, diffs, objName))
        ok = false;
      if (!CmpTitlePage(openXmlElement, value.TitlePage, diffs, objName))
        ok = false;
      if (!CmpTextDirection(openXmlElement, value.TextDirection, diffs, objName))
        ok = false;
      if (!CmpBiDi(openXmlElement, value.BiDi, diffs, objName))
        ok = false;
      if (!CmpGutterOnRight(openXmlElement, value.GutterOnRight, diffs, objName))
        ok = false;
      if (!CmpDocGrid(openXmlElement, value.DocGrid, diffs, objName))
        ok = false;
      if (!CmpPrinterSettingsReference(openXmlElement, value.PrinterSettingsReference, diffs, objName))
        ok = false;
      if (!CmpFootnoteColumns(openXmlElement, value.FootnoteColumns, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousSectionProperties? value)
    where OpenXmlElementType: DXW.PreviousSectionProperties, new()
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
