namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleConverter
{
  /// <summary>
  /// Style Type
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleKind? GetType(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StyleValues, DocumentModel.Wordprocessing.StyleKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.StyleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StyleValues, DocumentModel.Wordprocessing.StyleKind>(value);
  }
  
  /// <summary>
  /// Style ID
  /// </summary>
  private static String? GetStyleId(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    return openXmlElement?.StyleId?.Value;
  }
  
  private static void SetStyleId(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StyleId = new StringValue { Value = value };
    else
      openXmlElement.StyleId = null;
  }
  
  /// <summary>
  /// Default Style
  /// </summary>
  private static Boolean? GetDefault(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    return openXmlElement?.Default?.Value;
  }
  
  private static void SetDefault(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Default = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Default = null;
  }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  private static Boolean? GetCustomStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    return openXmlElement?.CustomStyle?.Value;
  }
  
  private static void SetCustomStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomStyle = null;
  }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  private static String? GetStyleName(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyleName(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.StyleName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  private static String? GetAliases(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Aliases>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAliases(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Aliases>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Aliases { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  private static String? GetBasedOn(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BasedOn>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBasedOn(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BasedOn>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.BasedOn { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  private static String? GetNextParagraphStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NextParagraphStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNextParagraphStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NextParagraphStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.NextParagraphStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  private static String? GetLinkedStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLinkedStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.LinkedStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetAutoRedefine(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoRedefine>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAutoRedefine(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoRedefine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AutoRedefine, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetStyleHidden(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleHidden>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStyleHidden(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleHidden, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  private static Int32? GetUIPriority(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UIPriority>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetUIPriority(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UIPriority>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.UIPriority{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetSemiHidden(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SemiHidden>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSemiHidden(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SemiHidden>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SemiHidden, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetLocked(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Locked>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLocked(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Locked>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Locked, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetPersonal(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Personal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPersonal(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Personal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Personal, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetPersonalCompose(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalCompose>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPersonalCompose(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalCompose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PersonalCompose, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetPersonalReply(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalReply>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPersonalReply(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalReply>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PersonalReply, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  private static UInt32? GetRsid(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    if (openXmlElement.Rsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Rsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsid(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.Rsid = new DocumentFormat.OpenXml.Wordprocessing.Rsid { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.Rsid = null;
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleParagraphProperties? GetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StyleParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleRunProperties? GetStyleRunProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StyleRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleRunProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.StyleRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StyleRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleTableProperties? GetStyleTableProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StyleTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleTableProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.StyleTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StyleTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleTableCellProperties? GetStyleTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StyleTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, DocumentModel.Wordprocessing.StyleTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StyleTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableStyleProperties> GetTableStylePropertieses(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableStyleProperties>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.TableStylePropertiesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTableStylePropertieses(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableStyleProperties>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.TableStylePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Style? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Style? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Style();
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
      value.TableStylePropertieses = GetTableStylePropertieses(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Style? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Style, new()
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
      SetTableStylePropertieses(openXmlElement, value?.TableStylePropertieses);
      return openXmlElement;
    }
    return default;
  }
}
