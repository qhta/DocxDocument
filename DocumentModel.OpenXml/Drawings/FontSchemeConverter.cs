using DocumentFormat.OpenXml.Drawing;
using MajorFont = DocumentModel.Drawings.MajorFont;
using MinorFont = DocumentModel.Drawings.MinorFont;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Font Scheme.
/// </summary>
public static class FontSchemeConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(FontScheme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(FontScheme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Major Font.
  /// </summary>
  public static MajorFont? GetMajorFont(FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MajorFont>();
    if (itemElement != null)
      return MajorFontConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorFont(FontScheme? openXmlElement, MajorFont? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MajorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorFontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MajorFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Minor fonts.
  /// </summary>
  public static MinorFont? GetMinorFont(FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MinorFont>();
    if (itemElement != null)
      return MinorFontConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorFont(FontScheme? openXmlElement, MinorFont? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MinorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorFontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MinorFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(FontScheme? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.FontScheme? CreateModelElement(FontScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FontScheme();
      value.Name = GetName(openXmlElement);
      value.MajorFont = GetMajorFont(openXmlElement);
      value.MinorFont = GetMinorFont(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FontScheme? value)
    where OpenXmlElementType : FontScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetMajorFont(openXmlElement, value?.MajorFont);
      SetMinorFont(openXmlElement, value?.MinorFont);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}