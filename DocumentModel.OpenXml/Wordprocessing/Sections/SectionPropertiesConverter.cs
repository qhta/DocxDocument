using System.Net.WebSockets;

using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  #region Physical Section Mark Character Revision ID conversion
  private static DM.HexInt? GetRsidRPr(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidRPr?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRPr.Value);
    return null;
  }

  private static bool CmpRsidRPr(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRPr?.Value, value, diffs, objName, "RsidRPr");
  }

  private static void SetRsidRPr(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRPr = value.ToString();
    else
      openXmlElement.RsidRPr = null;
  }
  #endregion

  #region Section Deletion Revision ID conversion
  private static DM.HexInt? GetRsidDel(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidDel?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidDel.Value);
    return null;
  }

  private static bool CmpRsidDel(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidDel?.Value, value, diffs, objName, "RsidDel");
  }

  private static void SetRsidDel(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidDel = value.ToString();
    else
      openXmlElement.RsidDel = null;
  }
  #endregion

  #region Section Addition Revision ID conversion
  private static DM.HexInt? GetRsidR(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidR?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidR.Value);
    return null;
  }

  private static bool CmpRsidR(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidR?.Value, value, diffs, objName, "RsidR");
  }

  private static void SetRsidR(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidR = value.ToString();
    else
      openXmlElement.RsidR = null;
  }
  #endregion

  #region Section Properties Revision ID conversion
  private static DM.HexInt? GetRsidSect(DXW.SectionProperties openXmlElement)
  {
    if (openXmlElement?.RsidSect?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidSect.Value);
    return null;
  }

  private static bool CmpRsidSect(DXW.SectionProperties openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidSect?.Value, value, diffs, objName, "RsidSect");
  }

  private static void SetRsidSect(DXW.SectionProperties openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidSect = value.ToString();
    else
      openXmlElement.RsidSect = null;
  }
  #endregion

  #region HeaderReferences conversion
  private static DMW.HeaderReferences? GetHeaderReference(DXW.SectionProperties openXmlElement)
  {
    var elements = openXmlElement.Elements<DXW.HeaderReference>();
    if (elements.Any())
    {
      var result = new DMW.HeaderReferences();
      foreach (var element in elements)
      {
        var item = DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(element);
        if (item != null)
          result.Add(item);
      }
      return result;
    }
    return null;
  }
  private static bool CmpHeaderReferences(DXW.SectionProperties openXmlElement, DMW.HeaderReferences? value, DiffList? diffs, string? objName)
  {
    var elements = openXmlElement.Elements<DXW.HeaderReference>().ToArray();
    var elementsCount = elements?.Count() ?? 0;
    var itemsCount = value?.Count() ?? 0;
    if (elements != null && value != null)
    {
      var ok = true;
      var items = value.ToArray();
      for (int i = 0; i < System.Math.Min(elements.Count(), items.Count()); i++)
      {
        var element = elements[i];
        var item = items[i];
        if (!DMXW.HeaderFooterReferenceTypeConverter.CompareModelElement(element, item, diffs, objName))
          ok = false;
      }
      if (!ok) return ok;
    }
    return Int32ValueConverter.CmpValue(elementsCount, itemsCount, diffs, objName, "Count");
  }

  private static void SetHeaderReferences(DXW.SectionProperties openXmlElement, DMW.HeaderReferences? value)
  {
    openXmlElement.RemoveAllChildren<DXW.HeaderReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var itemElement = DMXW.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement(item);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  #endregion

  #region FooterReferences conversion
  private static DMW.FooterReferences? GetFooterReference(DXW.SectionProperties openXmlElement)
  {
    var elements = openXmlElement.Elements<DXW.FooterReference>();
    if (elements.Any())
    {
      var result = new DMW.FooterReferences();
      foreach (var element in elements)
      {
        var item = DMXW.HeaderFooterReferenceTypeConverter.CreateModelElement(element);
        if (item != null)
          result.Add(item);
      }
      return result;
    }
    return null;
  }

  private static bool CmpFooterReferences(DXW.SectionProperties openXmlElement, DMW.FooterReferences? value, DiffList? diffs, string? objName)
  {
    var elements = openXmlElement.Elements<DXW.FooterReference>().ToArray();
    var elementsCount = elements?.Count() ?? 0;
    var itemsCount = value?.Count() ?? 0;
    if (elements != null && value != null)
    {
      var ok = true;
      var items = value.ToArray();
      for (int i = 0; i < System.Math.Min(elements.Count(), items.Count()); i++)
      {
        var element = elements[i];
        var item = items[i];
        if (!DMXW.HeaderFooterReferenceTypeConverter.CompareModelElement(element, item, diffs, objName))
          ok = false;
      }
      if (!ok) return ok;
    }
    return Int32ValueConverter.CmpValue(elementsCount, itemsCount, diffs, objName, "Count");
  }

  private static void SetFooterReferences(DXW.SectionProperties openXmlElement, DMW.FooterReferences? value)
  {
    openXmlElement.RemoveAllChildren<DXW.FooterReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var itemElement = DMXW.HeaderFooterReferenceTypeConverter.CreateOpenXmlElement(item);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  #endregion

  #region FootnoteProperties conversion
  private static DMW.FootnoteProperties? GetFootnoteProperties(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteProperties>();
    if (element != null)
      return DMXW.FootnotePropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpFootnoteProperties(DXW.SectionProperties openXmlElement, DMW.FootnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteProperties>(), value, diffs, objName);
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
  #endregion

  #region EndnoteProperties conversion
  private static DMW.EndnoteProperties? GetEndnoteProperties(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteProperties>();
    if (element != null)
      return DMXW.EndnotePropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpEndnoteProperties(DXW.SectionProperties openXmlElement, DMW.EndnoteProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnotePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteProperties>(), value, diffs, objName);
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
  #endregion

  #region SectionType conversion
  private static DMW.SectionMarkKind? GetSectionType(DXW.SectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value);
  }

  private static bool CmpSectionType(DXW.SectionProperties openXmlElement, DMW.SectionMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.SectionMarkValues, DMW.SectionMarkKind>(openXmlElement.GetFirstChild<DXW.SectionType>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetSectionType(DXW.SectionProperties openXmlElement, DMW.SectionMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.SectionMarkValues, DMW.SectionMarkKind>(itemElement, (DMW.SectionMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.SectionType, DXW.SectionMarkValues, DMW.SectionMarkKind>((DMW.SectionMarkKind)value));
  }
  #endregion

  #region PageSize conversion
  private static DMW.PageSize? GetPageSize(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PageSize>();
    if (element != null)
      return DMXW.PageSizeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPageSize(DXW.SectionProperties openXmlElement, DMW.PageSize? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageSize>(), value, diffs, objName);
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
  #endregion

  #region PageMarginConversion
  private static DMW.PageMargin? GetPageMargin(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PageMargin>();
    if (element != null)
      return DMXW.PageMarginConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPageMargin(DXW.SectionProperties openXmlElement, DMW.PageMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageMargin>(), value, diffs, objName);
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
  #endregion

  #region PaperSource conversion
  private static DMW.PaperSource? GetPaperSource(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PaperSource>();
    if (element != null)
      return DMXW.PaperSourceConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPaperSource(DXW.SectionProperties openXmlElement, DMW.PaperSource? value, DiffList? diffs, string? objName)
  {
    return DMXW.PaperSourceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PaperSource>(), value, diffs, objName);
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
  #endregion

  #region PageBorders conversion
  private static DMW.PageBorders? GetPageBorders(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PageBorders>();
    if (element != null)
      return DMXW.PageBordersConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPageBorders(DXW.SectionProperties openXmlElement, DMW.PageBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageBorders>(), value, diffs, objName);
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
  #endregion

  #region LineNumberType conversion
  private static DMW.LineNumberType? GetLineNumberType(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LineNumberType>();
    if (element != null)
      return DMXW.LineNumberTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpLineNumberType(DXW.SectionProperties openXmlElement, DMW.LineNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LineNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LineNumberType>(), value, diffs, objName);
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
  #endregion

  #region PageNumberType conversion
  private static DMW.PageNumberType? GetPageNumberType(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PageNumberType>();
    if (element != null)
      return DMXW.PageNumberTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPageNumberType(DXW.SectionProperties openXmlElement, DMW.PageNumberType? value, DiffList? diffs, string? objName)
  {
    return DMXW.PageNumberTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PageNumberType>(), value, diffs, objName);
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
  #endregion

  #region Columns conversion
  private static DMW.Columns? GetColumns(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Columns>();
    if (element != null)
      return DMXW.ColumnsConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpColumns(DXW.SectionProperties openXmlElement, DMW.Columns? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Columns>(), value, diffs, objName);
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
  #endregion

  #region FormProtection conversion
  private static Boolean? GetFormProtection(DXW.SectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FormProtection>());
  }

  private static bool CmpFormProtection(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FormProtection>(), value, diffs, objName);
  }

  private static void SetFormProtection(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.FormProtection>(openXmlElement, value);
  }
  #endregion

  #region VerticalTextAlignmentOnPage conversion
  private static DMW.VerticalJustificationKind? GetVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value);
  }

  private static bool CmpVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement, DMW.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalJustificationValues, DMW.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetVerticalTextAlignmentOnPage(DXW.SectionProperties openXmlElement, DMW.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.VerticalJustificationValues, DMW.VerticalJustificationKind>(itemElement, (DMW.VerticalJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignmentOnPage, DXW.VerticalJustificationValues, DMW.VerticalJustificationKind>((DMW.VerticalJustificationKind)value));
  }
  #endregion

  #region NoEndnote conversion
  private static Boolean? GetNoEndnote(DXW.SectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoEndnote>());
  }

  private static bool CmpNoEndnote(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoEndnote>(), value, diffs, objName);
  }

  private static void SetNoEndnote(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoEndnote>(openXmlElement, value);
  }
  #endregion

  #region TitlePage conversion
  private static Boolean? GetTitlePage(DXW.SectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TitlePage>());
  }

  private static bool CmpTitlePage(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TitlePage>(), value, diffs, objName);
  }

  private static void SetTitlePage(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TitlePage>(openXmlElement, value);
  }
  #endregion

  #region TextDirection conversion
  private static DMW.TextDirectionKind? GetTextDirection(DXW.SectionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }

  private static bool CmpTextDirection(DXW.SectionProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTextDirection(DXW.SectionProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DXW.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
  }
  #endregion

  #region BiDi conversion
  private static Boolean? GetBiDi(DXW.SectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDi>());
  }

  private static bool CmpBiDi(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDi>(), value, diffs, objName);
  }

  private static void SetBiDi(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BiDi>(openXmlElement, value);
  }
  #endregion

  #region GutterOnRight conversion
  private static Boolean? GetGutterOnRight(DXW.SectionProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.GutterOnRight>());
  }

  private static bool CmpGutterOnRight(DXW.SectionProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.GutterOnRight>(), value, diffs, objName);
  }

  private static void SetGutterOnRight(DXW.SectionProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.GutterOnRight>(openXmlElement, value);
  }
  #endregion

  #region DocGrid conversion
  private static DMW.DocGrid? GetDocGrid(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocGrid>();
    if (element != null)
      return DMXW.DocGridConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpDocGrid(DXW.SectionProperties openXmlElement, DMW.DocGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocGrid>(), value, diffs, objName);
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
  #endregion

  #region PrinterSettingsReference conversion
  private static DMW.PrinterSettingsReference? GetPrinterSettingsReference(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PrinterSettingsReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement<DMW.PrinterSettingsReference>(element);
    return null;
  }

  private static bool CmpPrinterSettingsReference(DXW.SectionProperties openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PrinterSettingsReference>(), value, diffs, objName);
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
  #endregion

  #region FootnoteColumns conversion
  private static Int32? GetFootnoteColumns(DXW.SectionProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO13W.FootnoteColumns>()?.Val);
  }

  private static bool CmpFootnoteColumns(DXW.SectionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO13W.FootnoteColumns>()?.Val, value, diffs, objName, "FootnoteColumns");
  }

  private static void SetFootnoteColumns(DXW.SectionProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO13W.FootnoteColumns, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region SectionPropertiesChange conversion
  private static DMW.SectionPropertiesChange? GetSectionPropertiesChange(DXW.SectionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SectionPropertiesChange>();
    if (element != null)
      return DMXW.SectionPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpSectionPropertiesChange(DXW.SectionProperties openXmlElement, DMW.SectionPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.SectionPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SectionPropertiesChange>(), value, diffs, objName);
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
  #endregion

  #region Main SectionProperties conversion
  public static DMW.SectionProperties? CreateModelElement(DXW.SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SectionProperties();
      value.RsidRPr = GetRsidRPr(openXmlElement);
      value.RsidDel = GetRsidDel(openXmlElement);
      value.RsidR = GetRsidR(openXmlElement);
      value.RsidSect = GetRsidSect(openXmlElement);
      value.HeaderReferences = GetHeaderReference(openXmlElement);
      value.FooterReferences = GetFooterReference(openXmlElement);
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
      if (!CmpHeaderReferences(openXmlElement, value.HeaderReferences, diffs, objName))
        ok = false;
      if (!CmpFooterReferences(openXmlElement, value.FooterReferences, diffs, objName))
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

  public static DXW.SectionProperties CreateOpenXmlElement(DMW.SectionProperties value)
  {
    var openXmlElement = new DXW.SectionProperties();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.SectionProperties openXmlElement, DMW.SectionProperties value)
  {
    SetRsidRPr(openXmlElement, value?.RsidRPr);
    SetRsidDel(openXmlElement, value?.RsidDel);
    SetRsidR(openXmlElement, value?.RsidR);
    SetRsidSect(openXmlElement, value?.RsidSect);
    SetHeaderReferences(openXmlElement, value?.HeaderReferences);
    SetFooterReferences(openXmlElement, value?.FooterReferences);
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
  }
  #endregion
}
