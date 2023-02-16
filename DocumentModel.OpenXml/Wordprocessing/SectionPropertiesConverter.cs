namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidRPr(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRPr.Value);
    return null;
  }
  
  private static bool CmpRsidRPr(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidRPr.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidRPr?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidRPr", openXmlElement?.RsidRPr?.Value, value);
    return false;
  }
  
  private static void SetRsidRPr(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRPr = value.ToString();
    else
      openXmlElement.RsidRPr = null;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidDel(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidDel.Value);
    return null;
  }
  
  private static bool CmpRsidDel(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidDel.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidDel?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidDel", openXmlElement?.RsidDel?.Value, value);
    return false;
  }
  
  private static void SetRsidDel(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidDel = value.ToString();
    else
      openXmlElement.RsidDel = null;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidR(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidR.Value);
    return null;
  }
  
  private static bool CmpRsidR(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidR?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidR.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidR?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidR", openXmlElement?.RsidR?.Value, value);
    return false;
  }
  
  private static void SetRsidR(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidR = value.ToString();
    else
      openXmlElement.RsidR = null;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  private static DM.HexInt? GetRsidSect(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidSect.Value);
    return null;
  }
  
  private static bool CmpRsidSect(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.RsidSect.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.RsidSect?.Value == null && value == null) return true;
    diffs?.Add(objName, "RsidSect", openXmlElement?.RsidSect?.Value, value);
    return false;
  }
  
  private static void SetRsidSect(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidSect = value.ToString();
    else
      openXmlElement.RsidSect = null;
  }
  
  private static DMW.HeaderFooterReferenceType? GetHeaderReference(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.HeaderReference>();
    if (element != null)
      return DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeaderReference(DXW.SectionProperties openXmlElement, DMW.HeaderFooterReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.HeaderFooterReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.HeaderReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.FooterReference>();
    if (element != null)
      return DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFooterReference(DXW.SectionProperties openXmlElement, DMW.HeaderFooterReferenceType? value, DiffList? diffs, string? objName)
  {
    return DMXW.HeaderFooterReferenceTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FooterReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteProperties>();
    if (element != null)
      return DMXW.FootnotePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFootnoteProperties(DXW.SectionProperties openXmlElement, DMW.FootnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteProperties>();
    if (element != null)
      return DMXW.EndnotePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndnoteProperties(DXW.SectionProperties openXmlElement, DMW.EndnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value);
  }
  
  private static bool CmpSectionType(DXW.SectionProperties openXmlElement, DMW.SectionMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PageSize>();
    if (element != null)
      return DMXW.PageSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageSize(DXW.SectionProperties openXmlElement, DMW.PageSize? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageSize>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PageMargin>();
    if (element != null)
      return DMXW.PageMarginConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageMargin(DXW.SectionProperties openXmlElement, DMW.PageMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageMargin>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PaperSource>();
    if (element != null)
      return DMXW.PaperSourceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPaperSource(DXW.SectionProperties openXmlElement, DMW.PaperSource? value, DiffList? diffs, string? objName)
  {
    return DMXW.PaperSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PaperSource>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PageBorders>();
    if (element != null)
      return DMXW.PageBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageBorders(DXW.SectionProperties openXmlElement, DMW.PageBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.LineNumberType>();
    if (element != null)
      return DMXW.LineNumberTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineNumberType(DXW.SectionProperties openXmlElement, DMW.LineNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LineNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LineNumberType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PageNumberType>();
    if (element != null)
      return DMXW.PageNumberTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageNumberType(DXW.SectionProperties openXmlElement, DMW.PageNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageNumberType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.Columns>();
    if (element != null)
      return DMXW.ColumnsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColumns(DXW.SectionProperties openXmlElement, DMW.Columns? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Columns>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement.GetFirstChild<DXW.FormProtection>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpFormProtection(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetFormProtection(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.FormProtection", val, value);
    return false;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value);
  }
  
  private static bool CmpVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement, DMW.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement.GetFirstChild<DXW.NoEndnote>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpNoEndnote(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetNoEndnote(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoEndnote", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.TitlePage>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpTitlePage(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetTitlePage(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.TitlePage", val, value);
    return false;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }
  
  private static bool CmpTextDirection(DXW.SectionProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement.GetFirstChild<DXW.BiDi>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBiDi(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBiDi(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BiDi", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.GutterOnRight>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpGutterOnRight(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetGutterOnRight(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.GutterOnRight", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.DocGrid>();
    if (element != null)
      return DMXW.DocGridConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocGrid(DXW.SectionProperties openXmlElement, DMW.DocGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocGrid>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXW.PrinterSettingsReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrinterSettingsReference(DXW.SectionProperties openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PrinterSettingsReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>()?.Val?.Value;
  }
  
  private static bool CmpFootnoteColumns(DXW.SectionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.FootnoteColumns>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2013W.FootnoteColumns", itemElement?.Val?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.SectionPropertiesChange>();
    if (element != null)
      return DMXW.SectionPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSectionPropertiesChange(DXW.SectionProperties openXmlElement, DMW.SectionPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.SectionPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SectionPropertiesChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.SectionProperties? CreateModelElement(DXW.SectionProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.SectionProperties? openXmlElement, DMW.SectionProperties? value, DiffList? diffs, string? objName)
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
      if (!CmpHeaderReference(openXmlElement, value.HeaderReference, diffs, objName))
        ok = false;
      if (!CmpFooterReference(openXmlElement, value.FooterReference, diffs, objName))
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
      if (!CmpSectionPropertiesChange(openXmlElement, value.SectionPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
