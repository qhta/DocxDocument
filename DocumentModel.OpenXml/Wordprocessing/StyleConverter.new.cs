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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.Style openXmlElement, DMW.StyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.Style openXmlElement, DMW.StyleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StyleValues, DMW.StyleKind>(value);
  }
  
  /// <summary>
  /// Style ID
  /// </summary>
  private static String? GetStyleId(DXW.Style openXmlElement)
  {
    return openXmlElement?.StyleId?.Value;
  }
  
  private static bool CmpStyleId(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StyleId?.Value == value) return true;
    diffs?.Add(objName, "StyleId", openXmlElement?.StyleId?.Value, value);
    return false;
  }
  
  private static void SetStyleId(DXW.Style openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StyleId = new StringValue { Value = value };
    else
      openXmlElement.StyleId = null;
  }
  
  /// <summary>
  /// Default Style
  /// </summary>
  private static Boolean? GetDefault(DXW.Style openXmlElement)
  {
    return openXmlElement?.Default?.Value;
  }
  
  private static bool CmpDefault(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Default?.Value == value) return true;
    diffs?.Add(objName, "Default", openXmlElement?.Default?.Value, value);
    return false;
  }
  
  private static void SetDefault(DXW.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Default = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Default = null;
  }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  private static Boolean GetCustomStyle(DXW.Style openXmlElement)
  {
    var element = openXmlElement?.CustomStyle;
    if (element is null)
      return false;
    if (element?.Value != null) return element.Value;
    return true;
  }
  
  private static bool CmpCustomStyle(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetCustomStyle(openXmlElement);
    if (val == value)
      return true;
    diffs?.Add(objName, "CustomStyle", openXmlElement?.CustomStyle?.Value, value);
    return false;
  }
  
  private static void SetCustomStyle(DXW.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomStyle = null;
  }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  private static String? GetStyleName(DXW.Style openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.StyleName>()?.Val?.Value;
  }
  
  private static bool CmpStyleName(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.StyleName>()?.Val?.Value == value;
  }
  
  private static void SetStyleName(DXW.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StyleName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  private static String? GetAliases(DXW.Style openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.Aliases>()?.Val?.Value;
  }
  
  private static bool CmpAliases(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.Aliases>()?.Val?.Value == value;
  }
  
  private static void SetAliases(DXW.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Aliases>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Aliases { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  private static String? GetBasedOn(DXW.Style openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.BasedOn>()?.Val?.Value;
  }
  
  private static bool CmpBasedOn(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.BasedOn>()?.Val?.Value == value;
  }
  
  private static void SetBasedOn(DXW.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BasedOn>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.BasedOn { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  private static String? GetNextParagraphStyle(DXW.Style openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>()?.Val?.Value;
  }
  
  private static bool CmpNextParagraphStyle(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>()?.Val?.Value == value;
  }
  
  private static void SetNextParagraphStyle(DXW.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NextParagraphStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NextParagraphStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  private static String? GetLinkedStyle(DXW.Style openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.LinkedStyle>()?.Val?.Value;
  }
  
  private static bool CmpLinkedStyle(DXW.Style openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.LinkedStyle>()?.Val?.Value == value;
  }
  
  private static void SetLinkedStyle(DXW.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkedStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LinkedStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  private static Boolean? GetAutoRedefine(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoRedefine>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpAutoRedefine(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoRedefine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAutoRedefine(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoRedefine>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoRedefine();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  private static Boolean? GetStyleHidden(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleHidden>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpStyleHidden(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.StyleHidden>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyleHidden(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.StyleHidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.StyleHidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  private static Int32? GetUIPriority(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.UIPriority>()?.Val?.Value;
  }
  
  private static bool CmpUIPriority(DXW.Style openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.UIPriority>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.UIPriority", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetUIPriority(DXW.Style openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UIPriority>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.UIPriority{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  private static Boolean? GetSemiHidden(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SemiHidden>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpSemiHidden(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SemiHidden>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSemiHidden(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SemiHidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SemiHidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  private static Boolean? GetUnhideWhenUsed(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpUnhideWhenUsed(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnhideWhenUsed(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UnhideWhenUsed();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  private static Boolean? GetPrimaryStyle(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrimaryStyle>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpPrimaryStyle(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrimaryStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPrimaryStyle(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrimaryStyle>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrimaryStyle();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  private static Boolean? GetLocked(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Locked>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpLocked(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Locked>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLocked(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Locked>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Locked();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  private static Boolean? GetPersonal(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Personal>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpPersonal(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Personal>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPersonal(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Personal>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Personal();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  private static Boolean? GetPersonalCompose(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalCompose>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpPersonalCompose(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalCompose>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPersonalCompose(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PersonalCompose>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PersonalCompose();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  private static Boolean? GetPersonalReply(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalReply>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpPersonalReply(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalReply>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPersonalReply(DXW.Style openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PersonalReply>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PersonalReply();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  private static UInt32? GetRsid(DXW.Style openXmlElement)
  {
    if (openXmlElement?.Rsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Rsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsid(DXW.Style openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rsid?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Rsid.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.Rsid?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Rsid", openXmlElement?.Rsid?.Val?.Value, value?.ToString("x8"));
    return false;
  }
  
  private static void SetRsid(DXW.Style openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.Rsid = new DXW.Rsid { Val = ((UInt32)value).ToString("X8") };
    else
      openXmlElement.Rsid = null;
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  private static DMW.StyleParagraphProperties? GetStyleParagraphProperties(DXW.Style openXmlElement)
  {
    return DMXW.StyleParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>());
  }
  
  private static bool CmpStyleParagraphProperties(DXW.Style openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMW.StyleRunProperties? GetStyleRunProperties(DXW.Style openXmlElement)
  {
    return DMXW.StyleRunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StyleRunProperties>());
  }
  
  private static bool CmpStyleRunProperties(DXW.Style openXmlElement, DMW.StyleRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  private static DMW.StyleTableProperties? GetStyleTableProperties(DXW.Style openXmlElement)
  {
    return DMXW.StyleTablePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StyleTableProperties>());
  }
  
  private static bool CmpStyleTableProperties(DXW.Style openXmlElement, DMW.StyleTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleTableProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  private static DMW.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement)
  {
    return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>());
  }
  
  private static bool CmpTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement, DMW.TableStyleConditionalFormattingTableRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement, DMW.TableStyleConditionalFormattingTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  private static DMW.StyleTableCellProperties? GetStyleTableCellProperties(DXW.Style openXmlElement)
  {
    return DMXW.StyleTableCellPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StyleTableCellProperties>());
  }
  
  private static bool CmpStyleTableCellProperties(DXW.Style openXmlElement, DMW.StyleTableCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleTableCellProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.TableStyleProperties>? GetTableStyleProperties(DXW.Style openXmlElement)
  {
    var collection = new Collection<DMW.TableStyleProperties>();
    foreach (var item in openXmlElement.Elements<DXW.TableStyleProperties>())
    {
      var newItem = DMXW.TableStylePropertiesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }
  
  private static bool CmpTableStyleProperties(DXW.Style openXmlElement, Collection<DMW.TableStyleProperties>? value, DiffList? diffs, string? objName)
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
  
  private static void SetTableStyleProperties(DXW.Style openXmlElement, Collection<DMW.TableStyleProperties>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.TableStyleProperties>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.TableStylePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleProperties>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
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
      value.IsDefault = GetDefault(openXmlElement);
      value.IsCustom = GetCustomStyle(openXmlElement);
      value.StyleName = GetStyleName(openXmlElement);
      value.Aliases = GetAliases(openXmlElement);
      value.BasedOn = GetBasedOn(openXmlElement);
      value.NextParagraphStyle = GetNextParagraphStyle(openXmlElement);
      value.LinkedStyle = GetLinkedStyle(openXmlElement);
      value.AutoRedefine = GetAutoRedefine(openXmlElement);
      value.StyleHidden = GetStyleHidden(openXmlElement);
      value.UIPriority = GetUIPriority(openXmlElement);
      value.SemiHidden = GetSemiHidden(openXmlElement);
      value.UnhideWhenUsed = GetUnhideWhenUsed(openXmlElement);
      value.PrimaryStyle = GetPrimaryStyle(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.Personal = GetPersonal(openXmlElement);
      value.PersonalCompose = GetPersonalCompose(openXmlElement);
      value.PersonalReply = GetPersonalReply(openXmlElement);
      value.Rsid = GetRsid(openXmlElement);
      value.StyleParagraphProperties = GetStyleParagraphProperties(openXmlElement);
      value.StyleRunProperties = GetStyleRunProperties(openXmlElement);
      value.StyleTableProperties = GetStyleTableProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      value.StyleTableCellProperties = GetStyleTableCellProperties(openXmlElement);
      value.TableStyleProperties = GetTableStyleProperties(openXmlElement);
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
      if (!CmpDefault(openXmlElement, value.IsDefault, diffs, objName))
        ok = false;
      if (!CmpCustomStyle(openXmlElement, value.IsCustom, diffs, objName))
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
      if (!CmpAutoRedefine(openXmlElement, value.AutoRedefine, diffs, objName))
        ok = false;
      if (!CmpStyleHidden(openXmlElement, value.StyleHidden, diffs, objName))
        ok = false;
      if (!CmpUIPriority(openXmlElement, value.UIPriority, diffs, objName))
        ok = false;
      if (!CmpSemiHidden(openXmlElement, value.SemiHidden, diffs, objName))
        ok = false;
      if (!CmpUnhideWhenUsed(openXmlElement, value.UnhideWhenUsed, diffs, objName))
        ok = false;
      if (!CmpPrimaryStyle(openXmlElement, value.PrimaryStyle, diffs, objName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName))
        ok = false;
      if (!CmpPersonal(openXmlElement, value.Personal, diffs, objName))
        ok = false;
      if (!CmpPersonalCompose(openXmlElement, value.PersonalCompose, diffs, objName))
        ok = false;
      if (!CmpPersonalReply(openXmlElement, value.PersonalReply, diffs, objName))
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
      if (!CmpTableStyleProperties(openXmlElement, value.TableStyleProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Style? value)
    where OpenXmlElementType: DXW.Style, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStyleId(openXmlElement, value?.StyleId);
      SetDefault(openXmlElement, value?.IsDefault);
      SetCustomStyle(openXmlElement, value?.IsCustom);
      SetStyleName(openXmlElement, value?.StyleName);
      SetAliases(openXmlElement, value?.Aliases);
      SetBasedOn(openXmlElement, value?.BasedOn);
      SetNextParagraphStyle(openXmlElement, value?.NextParagraphStyle);
      SetLinkedStyle(openXmlElement, value?.LinkedStyle);
      SetAutoRedefine(openXmlElement, value?.AutoRedefine);
      SetStyleHidden(openXmlElement, value?.StyleHidden);
      SetUIPriority(openXmlElement, value?.UIPriority);
      SetSemiHidden(openXmlElement, value?.SemiHidden);
      SetUnhideWhenUsed(openXmlElement, value?.UnhideWhenUsed);
      SetPrimaryStyle(openXmlElement, value?.PrimaryStyle);
      SetLocked(openXmlElement, value?.Locked);
      SetPersonal(openXmlElement, value?.Personal);
      SetPersonalCompose(openXmlElement, value?.PersonalCompose);
      SetPersonalReply(openXmlElement, value?.PersonalReply);
      SetRsid(openXmlElement, value?.Rsid);
      SetStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties);
      SetStyleRunProperties(openXmlElement, value?.StyleRunProperties);
      SetStyleTableProperties(openXmlElement, value?.StyleTableProperties);
      SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalFormattingTableRowProperties);
      SetStyleTableCellProperties(openXmlElement, value?.StyleTableCellProperties);
      SetTableStyleProperties(openXmlElement, value?.TableStyleProperties);
      return openXmlElement;
    }
    return default;
  }
}
