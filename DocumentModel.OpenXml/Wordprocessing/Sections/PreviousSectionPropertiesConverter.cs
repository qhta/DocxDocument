namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public static class PreviousSectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidRPr(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRPr.Value);
    return null;
  }
  
  private static bool CmpRsidRPr(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRPr?.Value, value, diffs, objName, "RsidRPr");
  }
  
  private static void SetRsidRPr(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRPr = value.ToString();
    else
      openXmlElement.RsidRPr = null;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidDel(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidDel.Value);
    return null;
  }
  
  private static bool CmpRsidDel(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidDel?.Value, value, diffs, objName, "RsidDel");
  }
  
  private static void SetRsidDel(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidDel = value.ToString();
    else
      openXmlElement.RsidDel = null;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidR(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidR.Value);
    return null;
  }
  
  private static bool CmpRsidR(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidR?.Value, value, diffs, objName, "RsidR");
  }
  
  private static void SetRsidR(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidR = value.ToString();
    else
      openXmlElement.RsidR = null;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidSect(DXW.PreviousSectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidSect.Value);
    return null;
  }
  
  private static bool CmpRsidSect(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidSect?.Value, value, diffs, objName, "RsidSect");
  }
  
  private static void SetRsidSect(DXW.PreviousSectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidSect = value.ToString();
    else
      openXmlElement.RsidSect = null;
  }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  private static DMW.FootnoteProperties? GetFootnoteProperties(DXW.PreviousSectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteProperties>();
    if (element != null)
      return DMXW.FootnotePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFootnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.FootnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteProperties>();
    if (element != null)
      return DMXW.EndnotePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndnoteProperties(DXW.PreviousSectionProperties openXmlElement, DMW.EndnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteProperties>(), value, diffs, objName);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSectionType(DXW.PreviousSectionProperties openXmlElement, DMW.SectionMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(itemElement, (DMW.SectionMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.SectionType, DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>((DMW.SectionMarkKind)value));
  }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  private static DMW.PageSize? GetPageSize(DXW.PreviousSectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PageSize>();
    if (element != null)
      return DMXW.PageSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageSize(DXW.PreviousSectionProperties openXmlElement, DMW.PageSize? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageSize>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.PageMargin>();
    if (element != null)
      return DMXW.PageMarginConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageMargin(DXW.PreviousSectionProperties openXmlElement, DMW.PageMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageMargin>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.PaperSource>();
    if (element != null)
      return DMXW.PaperSourceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPaperSource(DXW.PreviousSectionProperties openXmlElement, DMW.PaperSource? value, DiffList? diffs, string? objName)
  {
    return DMXW.PaperSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PaperSource>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.PageBorders>();
    if (element != null)
      return DMXW.PageBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageBorders(DXW.PreviousSectionProperties openXmlElement, DMW.PageBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageBorders>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.LineNumberType>();
    if (element != null)
      return DMXW.LineNumberTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.LineNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LineNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LineNumberType>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.PageNumberType>();
    if (element != null)
      return DMXW.PageNumberTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageNumberType(DXW.PreviousSectionProperties openXmlElement, DMW.PageNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageNumberType>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.Columns>();
    if (element != null)
      return DMXW.ColumnsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColumns(DXW.PreviousSectionProperties openXmlElement, DMW.Columns? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Columns>(), value, diffs, objName);
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
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FormProtection>());
  }
  
  private static bool CmpFormProtection(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FormProtection>(), value, diffs, objName);
  }
  
  private static void SetFormProtection(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.FormProtection>(openXmlElement, value);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVerticalTextAlignmentOnPage(DXW.PreviousSectionProperties openXmlElement, DMW.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(itemElement, (DMW.VerticalJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignmentOnPage, DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>((DMW.VerticalJustificationKind)value));
  }
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  private static Boolean? GetNoEndnote(DXW.PreviousSectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoEndnote>());
  }
  
  private static bool CmpNoEndnote(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoEndnote>(), value, diffs, objName);
  }
  
  private static void SetNoEndnote(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoEndnote>(openXmlElement, value);
  }
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  private static Boolean? GetTitlePage(DXW.PreviousSectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TitlePage>());
  }
  
  private static bool CmpTitlePage(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TitlePage>(), value, diffs, objName);
  }
  
  private static void SetTitlePage(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TitlePage>(openXmlElement, value);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTextDirection(DXW.PreviousSectionProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  private static Boolean? GetBiDi(DXW.PreviousSectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDi>());
  }
  
  private static bool CmpBiDi(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDi>(), value, diffs, objName);
  }
  
  private static void SetBiDi(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BiDi>(openXmlElement, value);
  }
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  private static Boolean? GetGutterOnRight(DXW.PreviousSectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.GutterOnRight>());
  }
  
  private static bool CmpGutterOnRight(DXW.PreviousSectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.GutterOnRight>(), value, diffs, objName);
  }
  
  private static void SetGutterOnRight(DXW.PreviousSectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.GutterOnRight>(openXmlElement, value);
  }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  private static DMW.DocGrid? GetDocGrid(DXW.PreviousSectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocGrid>();
    if (element != null)
      return DMXW.DocGridConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocGrid(DXW.PreviousSectionProperties openXmlElement, DMW.DocGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocGrid>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.PrinterSettingsReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrinterSettingsReference(DXW.PreviousSectionProperties openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PrinterSettingsReference>(), value, diffs, objName);
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>()?.Val);
  }
  
  private static bool CmpFootnoteColumns(DXW.PreviousSectionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>()?.Val, value, diffs, objName, "FootnoteColumns");
  }
  
  private static void SetFootnoteColumns(DXW.PreviousSectionProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2013W.FootnoteColumns,System.Int32>(openXmlElement, value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousSectionProperties value)
    where OpenXmlElementType: DXW.PreviousSectionProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousSectionProperties openXmlElement, DMW.PreviousSectionProperties value)
  {
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
  }
}
