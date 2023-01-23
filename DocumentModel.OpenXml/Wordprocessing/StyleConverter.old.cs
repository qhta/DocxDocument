using System.ComponentModel;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Style Definition.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  ///   Style Type
  /// </summary>
  private static DMW.StyleKind? GetType(DXW.Style openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value);
  }

  private static bool CmpType(DXW.Style openXmlElement, DMW.StyleKind? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  {
    return EnumValueConverter.CmpValue<DXW.StyleValues, DMW.StyleKind>(openXmlElement?.Type, value, diffs, callerName);
  }

  private static void SetType(DXW.Style openXmlElement, DMW.StyleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.StyleValues, DMW.StyleKind>(value);
  }

  /// <summary>
  ///   Style ID
  /// </summary>
  private static String? GetStyleId(DXW.Style openXmlElement)
  {
    return openXmlElement?.StyleId?.Value;
  }

  private static bool CmpStyleId(DXW.Style openXmlElement, String? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  {
    if (openXmlElement?.StyleId?.Value == value)
      return true;
    diffs?.Add(callerName, "StyleId", openXmlElement?.StyleId?.Value, value);
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
  ///   Default Style
  /// </summary>
  private static Boolean? GetDefault(DXW.Style openXmlElement)
  {
    return openXmlElement?.Default?.Value;
  }

  private static bool CmpDefault(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  {
    return openXmlElement?.Default?.Value == value;
  }

  private static void SetDefault(DXW.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Default = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Default = null;
  }

  /// <summary>
  ///   User-Defined Style
  /// </summary>
  private static Boolean? GetCustomStyle(DXW.Style openXmlElement)
  {
    return openXmlElement?.CustomStyle?.Value;
  }

  private static bool CmpCustomStyle(DXW.Style openXmlElement, Boolean? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  {
    return openXmlElement?.CustomStyle?.Value == value;
  }

  private static void SetCustomStyle(DXW.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomStyle = null;
  }

  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  private static String? GetStyleName(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.StyleName>()?.Val?.Value;
  }

  private static bool CmpStyleName(DXW.Style openXmlElement, String? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
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
  ///   Alternate Style Names.
  /// </summary>
  private static String? GetAliases(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.Aliases>()?.Val?.Value;
  }

  private static bool CmpAliases(DXW.Style openXmlElement, String? value)
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
  ///   Parent Style ID.
  /// </summary>
  private static String? GetBasedOn(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.BasedOn>()?.Val?.Value;
  }

  private static bool CmpBasedOn(DXW.Style openXmlElement, String? value)
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
  ///   Style For Next Paragraph.
  /// </summary>
  private static String? GetNextParagraphStyle(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>()?.Val?.Value;
  }

  private static bool CmpNextParagraphStyle(DXW.Style openXmlElement, String? value)
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
  ///   Linked Style Reference.
  /// </summary>
  private static String? GetLinkedStyle(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.LinkedStyle>()?.Val?.Value;
  }

  private static bool CmpLinkedStyle(DXW.Style openXmlElement, String? value)
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
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  private static Boolean? GetAutoRedefine(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoRedefine>());
  }

  private static bool CmpAutoRedefine(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoRedefine>(), value);
  }

  private static void SetAutoRedefine(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoRedefine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.AutoRedefine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  private static Boolean? GetStyleHidden(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.StyleHidden>());
  }

  private static bool CmpStyleHidden(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.StyleHidden>(), value);
  }

  private static void SetStyleHidden(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.StyleHidden>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  private static Int32? GetUIPriority(DXW.Style openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.UIPriority>()?.Val?.Value;
  }

  private static bool CmpUIPriority(DXW.Style openXmlElement, Int32? value)
  {
    return openXmlElement?.GetFirstChild<DXW.UIPriority>()?.Val?.Value == value;
  }

  private static void SetUIPriority(DXW.Style openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UIPriority>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.UIPriority { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  private static Boolean? GetSemiHidden(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SemiHidden>());
  }

  private static bool CmpSemiHidden(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SemiHidden>(), value);
  }

  private static void SetSemiHidden(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SemiHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.SemiHidden>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  private static Boolean? GetUnhideWhenUsed(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>());
  }

  private static bool CmpUnhideWhenUsed(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>(), value);
  }

  private static void SetUnhideWhenUsed(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.UnhideWhenUsed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Primary Style.
  /// </summary>
  private static Boolean? GetPrimaryStyle(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrimaryStyle>());
  }

  private static bool CmpPrimaryStyle(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrimaryStyle>(), value);
  }

  private static void SetPrimaryStyle(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrimaryStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.PrimaryStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  private static Boolean? GetLocked(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Locked>());
  }

  private static bool CmpLocked(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Locked>(), value);
  }

  private static void SetLocked(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Locked>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.Locked>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  private static Boolean? GetPersonal(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Personal>());
  }

  private static bool CmpPersonal(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Personal>(), value);
  }

  private static void SetPersonal(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Personal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.Personal>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  private static Boolean? GetPersonalCompose(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PersonalCompose>());
  }

  private static bool CmpPersonalCompose(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalCompose>(), value);
  }

  private static void SetPersonalCompose(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalCompose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.PersonalCompose>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  private static Boolean? GetPersonalReply(DXW.Style openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PersonalReply>());
  }

  private static bool CmpPersonalReply(DXW.Style openXmlElement, Boolean? value)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PersonalReply>(), value);
  }

  private static void SetPersonalReply(DXW.Style openXmlElement, Boolean? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalReply>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = BooleanValueConverter.CreateOpenXmlElement<DXW.PersonalReply>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  private static UInt32? GetRsid(DXW.Style openXmlElement)
  {
    if (openXmlElement.Rsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Rsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  private static bool CmpRsid(DXW.Style openXmlElement, UInt32? value)
  {
    if (openXmlElement.Rsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Rsid.Val.Value, NumberStyles.HexNumber) == value;
    return value == null;
  }

  private static void SetRsid(DXW.Style openXmlElement, UInt32? value)
  {
    if (value != null)
      openXmlElement.Rsid = new DXW.Rsid { Val = ((UInt32)value).ToString("X8") };
    else
      openXmlElement.Rsid = null;
  }

  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  private static DMW.StyleParagraphProperties? GetStyleParagraphProperties(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      return StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetStyleParagraphProperties(DXW.Style openXmlElement, DMW.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  private static DMW.StyleRunProperties? GetStyleRunProperties(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleRunProperties>();
    if (itemElement != null)
      return StyleRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetStyleRunProperties(DXW.Style openXmlElement, DMW.StyleRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = StyleRunPropertiesConverter.CreateOpenXmlElement<DXW.StyleRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  private static DMW.StyleTableProperties? GetStyleTableProperties(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleTableProperties>();
    if (itemElement != null)
      return StyleTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetStyleTableProperties(DXW.Style openXmlElement, DMW.StyleTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = StyleTablePropertiesConverter.CreateOpenXmlElement<DXW.StyleTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  private static DMW.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.Style openXmlElement, DMW.TableStyleConditionalFormattingTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  private static DMW.StyleTableCellProperties? GetStyleTableCellProperties(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleTableCellProperties>();
    if (itemElement != null)
      return StyleTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetStyleTableCellProperties(DXW.Style openXmlElement, DMW.StyleTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = StyleTableCellPropertiesConverter.CreateOpenXmlElement<DXW.StyleTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static Collection<DMW.TableStyleProperties> GetTableStyleProperties(DXW.Style openXmlElement)
  {
    var collection = new Collection<DMW.TableStyleProperties>();
    foreach (var item in openXmlElement.Elements<DXW.TableStyleProperties>())
    {
      var newItem = TableStylePropertiesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }

  private static void SetTableStyleProperties(DXW.Style openXmlElement, Collection<DMW.TableStyleProperties>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.TableStyleProperties>();
    if (value != null)
      foreach (var item in value)
      {
        var newItem = TableStylePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleProperties>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
  }

  public static DMW.Style? CreateModelElement(DXW.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Style();
      value.Type = GetType(openXmlElement);
      value.StyleId = GetStyleId(openXmlElement);
      value.Default = GetDefault(openXmlElement);
      value.CustomStyle = GetCustomStyle(openXmlElement);
      value.Name = GetStyleName(openXmlElement);
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

  public static bool CompareModelElement(DXW.Style? openXmlElement, DMW.Style? value, DiffList diffs)
  {
    if (openXmlElement != null && value != null)
    {
      bool ok = true;
      if (!CmpType(openXmlElement, value?.Type, diffs)) ok = false;
      if (!CmpStyleId(openXmlElement, value?.StyleId)) return false;
      if (!CmpDefault(openXmlElement, value?.Default)) return false;
      if (!CmpCustomStyle(openXmlElement, value?.CustomStyle)) return false;
      if (!CmpStyleName(openXmlElement, value?.Name)) return false;
      if (!CmpAliases(openXmlElement, value?.Aliases)) return false;
      if (!CmpBasedOn(openXmlElement, value?.BasedOn)) return false;
      if (!CmpNextParagraphStyle(openXmlElement, value?.NextParagraphStyle)) return false;
      if (!CmpLinkedStyle(openXmlElement, value?.LinkedStyle)) return false;
      if (!CmpAutoRedefine(openXmlElement, value?.AutoRedefine)) return false;
      if (!CmpStyleHidden(openXmlElement, value?.StyleHidden)) return false;
      if (!CmpUIPriority(openXmlElement, value?.UIPriority)) return false;
      if (!CmpSemiHidden(openXmlElement, value?.SemiHidden)) return false;
      if (!CmpUnhideWhenUsed(openXmlElement, value?.UnhideWhenUsed)) return false;
      if (!CmpPrimaryStyle(openXmlElement, value?.PrimaryStyle)) return false;
      if (!CmpLocked(openXmlElement, value?.Locked)) return false;
      if (!CmpPersonal(openXmlElement, value?.Personal)) return false;
      if (!CmpPersonalCompose(openXmlElement, value?.PersonalCompose)) return false;
      if (!CmpPersonalReply(openXmlElement, value?.PersonalReply)) return false;
      if (!CmpRsid(openXmlElement, value?.Rsid)) return false;
      if (!CmpStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties)) return false;
      if (!CmpStyleRunProperties(openXmlElement, value?.StyleRunProperties)) return false;
      if (!CmpStyleTableProperties(openXmlElement, value?.StyleTableProperties)) return false;
      if (!CmpTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalFormattingTableRowProperties)) return false;
      if (!CmpStyleTableCellProperties(openXmlElement, value?.StyleTableCellProperties)) return false;
      if (!CmpTableStyleProperties(openXmlElement, value?.TableStyleProperties)) return false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Style? value)
    where OpenXmlElementType : DXW.Style, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStyleId(openXmlElement, value?.StyleId);
      SetDefault(openXmlElement, value?.Default);
      SetCustomStyle(openXmlElement, value?.CustomStyle);
      SetStyleName(openXmlElement, value?.Name);
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