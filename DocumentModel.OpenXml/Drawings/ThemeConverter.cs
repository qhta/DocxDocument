using DocumentFormat.OpenXml.Drawing;
using CustomColorList = DocumentModel.Drawings.CustomColorList;
using ExtraColorSchemeList = DocumentModel.Drawings.ExtraColorSchemeList;
using ObjectDefaults = DocumentModel.Drawings.ObjectDefaults;
using OfficeStyleSheetExtensionList = DocumentModel.Drawings.OfficeStyleSheetExtensionList;
using ThemeElements = DocumentModel.Drawings.ThemeElements;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Theme.
/// </summary>
public static class ThemeConverter
{
  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(Theme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(Theme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetThemeId(Theme? openXmlElement)
  {
    return openXmlElement?.ThemeId?.Value;
  }

  public static void SetThemeId(Theme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeId = new StringValue { Value = value };
      else
        openXmlElement.ThemeId = null;
  }

  /// <summary>
  ///   ThemeElements.
  /// </summary>
  public static ThemeElements? GetThemeElements(Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
    if (itemElement != null)
      return ThemeElementsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetThemeElements(Theme? openXmlElement, ThemeElements? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ThemeElementsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ThemeElements>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ObjectDefaults.
  /// </summary>
  public static ObjectDefaults? GetObjectDefaults(Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
    if (itemElement != null)
      return ObjectDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetObjectDefaults(Theme? openXmlElement, ObjectDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ObjectDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtraColorSchemeList.
  /// </summary>
  public static ExtraColorSchemeList? GetExtraColorSchemeList(Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
    if (itemElement != null)
      return ExtraColorSchemeListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtraColorSchemeList(Theme? openXmlElement, ExtraColorSchemeList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtraColorSchemeListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   CustomColorList.
  /// </summary>
  public static CustomColorList? GetCustomColorList(Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
    if (itemElement != null)
      return CustomColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomColorList(Theme? openXmlElement, CustomColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeStyleSheetExtensionList.
  /// </summary>
  public static OfficeStyleSheetExtensionList? GetOfficeStyleSheetExtensionList(Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      return OfficeStyleSheetExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeStyleSheetExtensionList(Theme? openXmlElement, OfficeStyleSheetExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Theme? CreateModelElement(Theme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Theme();
      value.Name = GetName(openXmlElement);
      value.ThemeId = GetThemeId(openXmlElement);
      value.ThemeElements = GetThemeElements(openXmlElement);
      value.ObjectDefaults = GetObjectDefaults(openXmlElement);
      value.ExtraColorSchemeList = GetExtraColorSchemeList(openXmlElement);
      value.CustomColorList = GetCustomColorList(openXmlElement);
      value.OfficeStyleSheetExtensionList = GetOfficeStyleSheetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Theme? value)
    where OpenXmlElementType : Theme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetThemeId(openXmlElement, value?.ThemeId);
      SetThemeElements(openXmlElement, value?.ThemeElements);
      SetObjectDefaults(openXmlElement, value?.ObjectDefaults);
      SetExtraColorSchemeList(openXmlElement, value?.ExtraColorSchemeList);
      SetCustomColorList(openXmlElement, value?.CustomColorList);
      SetOfficeStyleSheetExtensionList(openXmlElement, value?.OfficeStyleSheetExtensionList);
      return openXmlElement;
    }
    return default;
  }
}