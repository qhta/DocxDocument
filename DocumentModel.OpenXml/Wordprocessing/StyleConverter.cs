using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Style = DocumentFormat.OpenXml.Wordprocessing.Style;
using StyleParagraphProperties = DocumentModel.Wordprocessing.StyleParagraphProperties;
using StyleRunProperties = DocumentModel.Wordprocessing.StyleRunProperties;
using StyleTableCellProperties = DocumentModel.Wordprocessing.StyleTableCellProperties;
using StyleTableProperties = DocumentModel.Wordprocessing.StyleTableProperties;
using TableStyleConditionalFormattingTableRowProperties = DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties;
using TableStyleProperties = DocumentModel.Wordprocessing.TableStyleProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Style Definition.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  ///   Style Type
  /// </summary>
  public static DocumentModel.Wordprocessing.StyleKind? GetType(Style? openXmlElement)
  {
    return EnumValueConverter.GetValue<StyleValues, DocumentModel.Wordprocessing.StyleKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Style? openXmlElement, DocumentModel.Wordprocessing.StyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<StyleValues, DocumentModel.Wordprocessing.StyleKind>(value);
  }

  /// <summary>
  ///   Style ID
  /// </summary>
  public static String? GetStyleId(Style? openXmlElement)
  {
    return openXmlElement?.StyleId?.Value;
  }

  public static void SetStyleId(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StyleId = new StringValue { Value = value };
      else
        openXmlElement.StyleId = null;
  }

  /// <summary>
  ///   Default Style
  /// </summary>
  public static Boolean? GetDefault(Style? openXmlElement)
  {
    return openXmlElement?.Default?.Value;
  }

  public static void SetDefault(Style? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Default = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Default = null;
  }

  /// <summary>
  ///   User-Defined Style
  /// </summary>
  public static Boolean? GetCustomStyle(Style? openXmlElement)
  {
    return openXmlElement?.CustomStyle?.Value;
  }

  public static void SetCustomStyle(Style? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CustomStyle = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.CustomStyle = null;
  }

  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public static String? GetStyleName(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StyleName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStyleName(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StyleName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StyleName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  public static String? GetAliases(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Aliases>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAliases(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Aliases>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Aliases { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  public static String? GetBasedOn(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BasedOn>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBasedOn(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BasedOn>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BasedOn { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  public static String? GetNextParagraphStyle(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NextParagraphStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNextParagraphStyle(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NextParagraphStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NextParagraphStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  public static String? GetLinkedStyle(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LinkedStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLinkedStyle(Style? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkedStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LinkedStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public static OnOffOnlyKind? GetAutoRedefine(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoRedefine>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAutoRedefine(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoRedefine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<AutoRedefine, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  public static OnOffOnlyKind? GetStyleHidden(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StyleHidden>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetStyleHidden(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StyleHidden>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<StyleHidden, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  public static Int32? GetUIPriority(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UIPriority>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetUIPriority(Style? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UIPriority>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new UIPriority { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  public static OnOffOnlyKind? GetSemiHidden(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SemiHidden>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSemiHidden(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SemiHidden>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SemiHidden, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public static OnOffOnlyKind? GetUnhideWhenUsed(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnhideWhenUsed>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetUnhideWhenUsed(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnhideWhenUsed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<UnhideWhenUsed, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Primary Style.
  /// </summary>
  public static OnOffOnlyKind? GetPrimaryStyle(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrimaryStyle>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPrimaryStyle(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrimaryStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PrimaryStyle, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  public static OnOffOnlyKind? GetLocked(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Locked>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLocked(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Locked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Locked, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  public static OnOffOnlyKind? GetPersonal(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Personal>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPersonal(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Personal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Personal, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  public static OnOffOnlyKind? GetPersonalCompose(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PersonalCompose>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPersonalCompose(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PersonalCompose>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PersonalCompose, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  public static OnOffOnlyKind? GetPersonalReply(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PersonalReply>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPersonalReply(Style? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PersonalReply>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PersonalReply, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  public static NumId? GetRsid(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Rsid>();
    if (itemElement != null)
      return NumIdConverter.GetValue(itemElement);
    return null;
  }

  public static void SetRsid(Style? openXmlElement, NumId? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Rsid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumIdConverter.CreateOpenXmlElement<Rsid>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  public static StyleParagraphProperties? GetStyleParagraphProperties(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      return StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleParagraphProperties(Style? openXmlElement, StyleParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  public static StyleRunProperties? GetStyleRunProperties(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
    if (itemElement != null)
      return StyleRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleRunProperties(Style? openXmlElement, StyleRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  public static StyleTableProperties? GetStyleTableProperties(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
    if (itemElement != null)
      return StyleTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleTableProperties(Style? openXmlElement, StyleTableProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  public static TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableStyleConditionalFormattingTableRowProperties(Style? openXmlElement, TableStyleConditionalFormattingTableRowProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  public static StyleTableCellProperties? GetStyleTableCellProperties(Style? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
    if (itemElement != null)
      return StyleTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleTableCellProperties(Style? openXmlElement, StyleTableCellProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<TableStyleProperties>? GetTableStylePropertieses(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TableStyleProperties>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>())
      {
        var newItem = TableStylePropertiesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTableStylePropertieses(Style? openXmlElement, Collection<TableStyleProperties>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TableStylePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Style? CreateModelElement(Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Style();
      value.Type = GetType(openXmlElement);
      value.StyleId = GetStyleId(openXmlElement);
      value.Default = GetDefault(openXmlElement);
      value.CustomStyle = GetCustomStyle(openXmlElement);
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
      value.TableStylePropertieses = GetTableStylePropertieses(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Style? value)
    where OpenXmlElementType : Style, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStyleId(openXmlElement, value?.StyleId);
      SetDefault(openXmlElement, value?.Default);
      SetCustomStyle(openXmlElement, value?.CustomStyle);
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
      SetTableStylePropertieses(openXmlElement, value?.TableStylePropertieses);
      return openXmlElement;
    }
    return default;
  }
}