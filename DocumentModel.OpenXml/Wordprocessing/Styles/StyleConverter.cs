namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// Style Type
  /// </summary>
  private static DMW.StyleKind? GetType(DXW.Style openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.Style openXmlElement, DMW.StyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.Style openXmlElement, DMW.StyleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.StyleValues, DMW.StyleKind>(value);
  }
  
  /// <summary>
  /// Style ID
  /// </summary>
  private static String? GetStyleId(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StyleId);
  }
  
  private static bool CmpStyleId(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StyleId, value, diffs, objName, "StyleId");
  }
  
  private static void SetStyleId(DXW.Style openXmlElement, String? value)
  {
    openXmlElement.StyleId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Default Style
  /// </summary>
  private static Boolean? GetIsDefault(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Default);
  }
  
  private static bool CmpIsDefault(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Default, value, diffs, objName, "Default");
  }
  
  private static void SetIsDefault(DXW.Style openXmlElement, Boolean? value)
  {
    openXmlElement.Default = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  private static Boolean? GetIsCustom(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.CustomStyle);
  }
  
  private static bool CmpIsCustom(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.CustomStyle, value, diffs, objName, "CustomStyle");
  }
  
  private static void SetIsCustom(DXW.Style openXmlElement, Boolean? value)
  {
    openXmlElement.CustomStyle = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  private static String? GetStyleName(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StyleName>()?.Val);
  }
  
  private static bool CmpStyleName(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StyleName>()?.Val, value, diffs, objName, "StyleName");
  }
  
  private static void SetStyleName(DXW.Style openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.StyleName>(openXmlElement, value);
  }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  private static String? GetAliases(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Aliases>()?.Val);
  }
  
  private static bool CmpAliases(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Aliases>()?.Val, value, diffs, objName, "Aliases");
  }
  
  private static void SetAliases(DXW.Style openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.Aliases>(openXmlElement, value);
  }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  private static String? GetBasedOn(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.BasedOn>()?.Val);
  }
  
  private static bool CmpBasedOn(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.BasedOn>()?.Val, value, diffs, objName, "BasedOn");
  }
  
  private static void SetBasedOn(DXW.Style openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.BasedOn>(openXmlElement, value);
  }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  private static String? GetNextParagraphStyle(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>()?.Val);
  }
  
  private static bool CmpNextParagraphStyle(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>()?.Val, value, diffs, objName, "NextParagraphStyle");
  }
  
  private static void SetNextParagraphStyle(DXW.Style openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.NextParagraphStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  private static String? GetLinkedStyle(DXW.Style openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LinkedStyle>()?.Val);
  }
  
  private static bool CmpLinkedStyle(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LinkedStyle>()?.Val, value, diffs, objName, "LinkedStyle");
  }
  
  private static void SetLinkedStyle(DXW.Style openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.LinkedStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  private static Boolean GetIsAutoRedefined(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoRedefine>());
  }
  
  private static bool CmpIsAutoRedefined(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoRedefine>(), value, diffs, objName);
  }
  
  private static void SetIsAutoRedefined(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.AutoRedefine>(openXmlElement, value);
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  private static Boolean GetIsHidden(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.StyleHidden>());
  }
  
  private static bool CmpIsHidden(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.StyleHidden>(), value, diffs, objName);
  }
  
  private static void SetIsHidden(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.StyleHidden>(openXmlElement, value);
  }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  private static Int32? GetUIPriority(DXW.Style openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.UIPriority>()?.Val);
  }
  
  private static bool CmpUIPriority(DXW.Style openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.UIPriority>()?.Val, value, diffs, objName, "UIPriority");
  }
  
  private static void SetUIPriority(DXW.Style openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.UIPriority,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  private static Boolean GetIsSemiHidden(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SemiHidden>());
  }
  
  private static bool CmpIsSemiHidden(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SemiHidden>(), value, diffs, objName);
  }
  
  private static void SetIsSemiHidden(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.SemiHidden>(openXmlElement, value);
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  private static Boolean GetIsUnhiddenWhenUsed(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>());
  }
  
  private static bool CmpIsUnhiddenWhenUsed(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>(), value, diffs, objName);
  }
  
  private static void SetIsUnhiddenWhenUsed(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.UnhideWhenUsed>(openXmlElement, value);
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  private static Boolean GetIsPrimary(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrimaryStyle>());
  }
  
  private static bool CmpIsPrimary(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrimaryStyle>(), value, diffs, objName);
  }
  
  private static void SetIsPrimary(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.PrimaryStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  private static Boolean GetIsLocked(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Locked>());
  }
  
  private static bool CmpIsLocked(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Locked>(), value, diffs, objName);
  }
  
  private static void SetIsLocked(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.Locked>(openXmlElement, value);
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  private static Boolean GetIsPersonal(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Personal>());
  }
  
  private static bool CmpIsPersonal(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Personal>(), value, diffs, objName);
  }
  
  private static void SetIsPersonal(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.Personal>(openXmlElement, value);
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  private static Boolean GetIsPersonalCompose(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PersonalCompose>());
  }
  
  private static bool CmpIsPersonalCompose(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalCompose>(), value, diffs, objName);
  }
  
  private static void SetIsPersonalCompose(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.PersonalCompose>(openXmlElement, value);
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  private static Boolean GetIsPersonalReply(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PersonalReply>());
  }
  
  private static bool CmpIsPersonalReply(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalReply>(), value, diffs, objName);
  }
  
  private static void SetIsPersonalReply(DXW.Style openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.PersonalReply>(openXmlElement, value);
  }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  private static DM.HexInt? GetRsid(DXW.Style openXmlElement)
  {
    return HexIntConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Rsid>()?.Val);
  }
  
  private static bool CmpRsid(DXW.Style openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Rsid>()?.Val, value, diffs, objName, "Rsid");
  }
  
  private static void SetRsid(DXW.Style openXmlElement, DM.HexInt? value)
  {
    HexIntConverter.SetValue<DXW.Rsid>(openXmlElement, value);
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  private static DMW.StyleParagraphProperties? GetStyleParagraphProperties(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>();
    if (element != null)
      return DMXW.StyleParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleParagraphProperties(DXW.Style openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetStyleParagraphProperties(DXW.Style openXmlElement, DMW.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMW.StyleRunProperties? GetStyleRunProperties(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StyleRunProperties>();
    if (element != null)
      return DMXW.StyleRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleRunProperties(DXW.Style openXmlElement, DMW.StyleRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleRunProperties>(), value, diffs, objName);
  }
  
  private static void SetStyleRunProperties(DXW.Style openXmlElement, DMW.StyleRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleRunPropertiesConverter.CreateOpenXmlElement<DXW.StyleRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  private static DMW.StyleTableProperties? GetStyleTableProperties(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StyleTableProperties>();
    if (element != null)
      return DMXW.StyleTablePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleTableProperties(DXW.Style openXmlElement, DMW.StyleTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleTableProperties>(), value, diffs, objName);
  }
  
  private static void SetStyleTableProperties(DXW.Style openXmlElement, DMW.StyleTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleTablePropertiesConverter.CreateOpenXmlElement<DXW.StyleTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  private static DMW.TableStyleConditionalRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement, DMW.TableStyleConditionalRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement, DMW.TableStyleConditionalRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  private static DMW.StyleTableCellProperties? GetStyleTableCellProperties(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StyleTableCellProperties>();
    if (element != null)
      return DMXW.StyleTableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleTableCellProperties(DXW.Style openXmlElement, DMW.StyleTableCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleTableCellProperties>(), value, diffs, objName);
  }
  
  private static void SetStyleTableCellProperties(DXW.Style openXmlElement, DMW.StyleTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleTableCellPropertiesConverter.CreateOpenXmlElement<DXW.StyleTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.TableStyleConditionalProperties? GetTableStyleProperties(DXW.Style openXmlElement)
  {
    var collection = new DMW.TableStyleConditionalProperties();
    foreach (var item in openXmlElement.Elements<DXW.TableStyleProperties>())
    {
      var newItem = DMXW.TableStylePropertiesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTableStyleProperties(DXW.Style openXmlElement, ICollection<DMW.TableStyleProperties>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.TableStyleProperties>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.TableStylePropertiesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTableStyleProperties(DXW.Style openXmlElement, ICollection<DMW.TableStyleProperties>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.TableStyleProperties>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.TableStylePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleProperties>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.Style? CreateModelElement(DXW.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Style();
      value.Type = GetType(openXmlElement);
      value.StyleId = GetStyleId(openXmlElement);
      value.IsDefault = GetIsDefault(openXmlElement);
      value.IsCustom = GetIsCustom(openXmlElement);
      value.StyleName = GetStyleName(openXmlElement);
      value.Aliases = GetAliases(openXmlElement);
      value.BasedOn = GetBasedOn(openXmlElement);
      value.NextParagraphStyle = GetNextParagraphStyle(openXmlElement);
      value.LinkedStyle = GetLinkedStyle(openXmlElement);
      value.IsAutoRedefined = GetIsAutoRedefined(openXmlElement);
      value.IsHidden = GetIsHidden(openXmlElement);
      value.UIPriority = GetUIPriority(openXmlElement);
      value.IsSemiHidden = GetIsSemiHidden(openXmlElement);
      value.IsUnhiddenWhenUsed = GetIsUnhiddenWhenUsed(openXmlElement);
      value.IsPrimary = GetIsPrimary(openXmlElement);
      value.IsLocked = GetIsLocked(openXmlElement);
      value.IsPersonal = GetIsPersonal(openXmlElement);
      value.IsPersonalCompose = GetIsPersonalCompose(openXmlElement);
      value.IsPersonalReply = GetIsPersonalReply(openXmlElement);
      value.Rsid = GetRsid(openXmlElement);
      value.StyleParagraphProperties = GetStyleParagraphProperties(openXmlElement);
      value.StyleRunProperties = GetStyleRunProperties(openXmlElement);
      value.StyleTableProperties = GetStyleTableProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      value.StyleTableCellProperties = GetStyleTableCellProperties(openXmlElement);
      value.TableStyleConditionalProperties = GetTableStyleProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Style? openXmlElement, DMW.Style? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpStyleId(openXmlElement, value.StyleId, diffs, objName))
        ok = false;
      if (!CmpIsDefault(openXmlElement, value.IsDefault, diffs, objName))
        ok = false;
      if (!CmpIsCustom(openXmlElement, value.IsCustom, diffs, objName))
        ok = false;
      if (!CmpStyleName(openXmlElement, value.StyleName, diffs, objName))
        ok = false;
      if (!CmpAliases(openXmlElement, value.Aliases, diffs, objName))
        ok = false;
      if (!CmpBasedOn(openXmlElement, value.BasedOn, diffs, objName))
        ok = false;
      if (!CmpNextParagraphStyle(openXmlElement, value.NextParagraphStyle, diffs, objName))
        ok = false;
      if (!CmpLinkedStyle(openXmlElement, value.LinkedStyle, diffs, objName))
        ok = false;
      if (!CmpIsAutoRedefined(openXmlElement, value.IsAutoRedefined, diffs, objName))
        ok = false;
      if (!CmpIsHidden(openXmlElement, value.IsHidden, diffs, objName))
        ok = false;
      if (!CmpUIPriority(openXmlElement, value.UIPriority, diffs, objName))
        ok = false;
      if (!CmpIsSemiHidden(openXmlElement, value.IsSemiHidden, diffs, objName))
        ok = false;
      if (!CmpIsUnhiddenWhenUsed(openXmlElement, value.IsUnhiddenWhenUsed, diffs, objName))
        ok = false;
      if (!CmpIsPrimary(openXmlElement, value.IsPrimary, diffs, objName))
        ok = false;
      if (!CmpIsLocked(openXmlElement, value.IsLocked, diffs, objName))
        ok = false;
      if (!CmpIsPersonal(openXmlElement, value.IsPersonal, diffs, objName))
        ok = false;
      if (!CmpIsPersonalCompose(openXmlElement, value.IsPersonalCompose, diffs, objName))
        ok = false;
      if (!CmpIsPersonalReply(openXmlElement, value.IsPersonalReply, diffs, objName))
        ok = false;
      if (!CmpRsid(openXmlElement, value.Rsid, diffs, objName))
        ok = false;
      if (!CmpStyleParagraphProperties(openXmlElement, value.StyleParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpStyleRunProperties(openXmlElement, value.StyleRunProperties, diffs, objName))
        ok = false;
      if (!CmpStyleTableProperties(openXmlElement, value.StyleTableProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableRowProperties(openXmlElement, value.TableStyleConditionalFormattingTableRowProperties, diffs, objName))
        ok = false;
      if (!CmpStyleTableCellProperties(openXmlElement, value.StyleTableCellProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleProperties(openXmlElement, value.TableStyleConditionalProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Style value)
    where OpenXmlElementType: DXW.Style, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Style openXmlElement, DMW.Style value)
  {
    SetType(openXmlElement, value?.Type);
    SetStyleId(openXmlElement, value?.StyleId);
    SetIsDefault(openXmlElement, value?.IsDefault);
    SetIsCustom(openXmlElement, value?.IsCustom);
    SetStyleName(openXmlElement, value?.StyleName);
    SetAliases(openXmlElement, value?.Aliases);
    SetBasedOn(openXmlElement, value?.BasedOn);
    SetNextParagraphStyle(openXmlElement, value?.NextParagraphStyle);
    SetLinkedStyle(openXmlElement, value?.LinkedStyle);
    SetIsAutoRedefined(openXmlElement, value?.IsAutoRedefined);
    SetIsHidden(openXmlElement, value?.IsHidden);
    SetUIPriority(openXmlElement, value?.UIPriority);
    SetIsSemiHidden(openXmlElement, value?.IsSemiHidden);
    SetIsUnhiddenWhenUsed(openXmlElement, value?.IsUnhiddenWhenUsed);
    SetIsPrimary(openXmlElement, value?.IsPrimary);
    SetIsLocked(openXmlElement, value?.IsLocked);
    SetIsPersonal(openXmlElement, value?.IsPersonal);
    SetIsPersonalCompose(openXmlElement, value?.IsPersonalCompose);
    SetIsPersonalReply(openXmlElement, value?.IsPersonalReply);
    SetRsid(openXmlElement, value?.Rsid);
    SetStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties);
    SetStyleRunProperties(openXmlElement, value?.StyleRunProperties);
    SetStyleTableProperties(openXmlElement, value?.StyleTableProperties);
    SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalFormattingTableRowProperties);
    SetStyleTableCellProperties(openXmlElement, value?.StyleTableCellProperties);
    SetTableStyleProperties(openXmlElement, value?.TableStyleConditionalProperties);
  }
}
