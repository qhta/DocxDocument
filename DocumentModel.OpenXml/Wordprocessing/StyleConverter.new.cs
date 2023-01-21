using DXW = DocumentFormat.OpenXml.Wordprocessing;
using DMW = DocumentModel.Wordprocessing;

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

  private static bool CmpType(DXW.Style openXmlElement, DMW.StyleKind? value)
  {
    return EnumValueConverter.CmpValue<DXW.StyleValues, DMW.StyleKind>(openXmlElement?.Type?.Value, value);
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Aliases>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BasedOn>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.NextParagraphStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.LinkedStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
  private static DMW.OnOffOnlyKind? GetAutoRedefine(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoRedefine>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetAutoRedefine(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoRedefine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.AutoRedefine, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetStyleHidden(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleHidden>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetStyleHidden(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.StyleHidden, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  private static Int32? GetUIPriority(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.UIPriority>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
  private static DMW.OnOffOnlyKind? GetSemiHidden(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SemiHidden>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetSemiHidden(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SemiHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.SemiHidden, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetUnhideWhenUsed(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetUnhideWhenUsed(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UnhideWhenUsed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.UnhideWhenUsed, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Primary Style.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetPrimaryStyle(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrimaryStyle>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetPrimaryStyle(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PrimaryStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.PrimaryStyle, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetLocked(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Locked>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetLocked(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Locked>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Locked, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetPersonal(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Personal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetPersonal(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Personal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Personal, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetPersonalCompose(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalCompose>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetPersonalCompose(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalCompose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.PersonalCompose, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetPersonalReply(DXW.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalReply>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }

  private static void SetPersonalReply(DXW.Style openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PersonalReply>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.PersonalReply, DXW.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
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