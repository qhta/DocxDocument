using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Font = DocumentFormat.OpenXml.Wordprocessing.Font;
using FontCharSet = DocumentModel.Wordprocessing.FontCharSet;
using FontRelationshipType = DocumentModel.Wordprocessing.FontRelationshipType;
using FontSignature = DocumentModel.Wordprocessing.FontSignature;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Properties for a Single Font.
/// </summary>
public static class FontConverter
{
  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(Font? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(Font? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   AltName.
  /// </summary>
  public static String? GetAltName(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AltName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAltName(Font? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AltName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AltName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Panose1Number.
  /// </summary>
  public static Byte[]? GetPanose1Number(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Panose1Number>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }

  public static void SetPanose1Number(Font? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Panose1Number>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<Panose1Number>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontCharSet.
  /// </summary>
  public static FontCharSet? GetFontCharSet(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
    if (itemElement != null)
      return FontCharSetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFontCharSet(Font? openXmlElement, FontCharSet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontCharSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontFamily.
  /// </summary>
  public static FontFamilyKind? GetFontFamily(Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FontFamily>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FontFamilyValues, FontFamilyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetFontFamily(Font? openXmlElement, FontFamilyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FontFamily>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<FontFamily, FontFamilyValues, FontFamilyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NotTrueType.
  /// </summary>
  public static Boolean? GetNotTrueType(Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NotTrueType>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNotTrueType(Font? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NotTrueType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NotTrueType();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Pitch.
  /// </summary>
  public static FontPitchKind? GetPitch(Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Pitch>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<FontPitchValues, FontPitchKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPitch(Font? openXmlElement, FontPitchKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Pitch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Pitch, FontPitchValues, FontPitchKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontSignature.
  /// </summary>
  public static FontSignature? GetFontSignature(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
    if (itemElement != null)
      return FontSignatureConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFontSignature(Font? openXmlElement, FontSignature? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSignatureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontSignature>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  public static FontRelationshipType? GetEmbedRegularFont(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EmbedRegularFont>();
    if (itemElement != null)
      return FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEmbedRegularFont(Font? openXmlElement, FontRelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedRegularFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontRelationshipTypeConverter.CreateOpenXmlElement<EmbedRegularFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  public static FontRelationshipType? GetEmbedBoldFont(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EmbedBoldFont>();
    if (itemElement != null)
      return FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEmbedBoldFont(Font? openXmlElement, FontRelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedBoldFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontRelationshipTypeConverter.CreateOpenXmlElement<EmbedBoldFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  public static FontRelationshipType? GetEmbedItalicFont(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EmbedItalicFont>();
    if (itemElement != null)
      return FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEmbedItalicFont(Font? openXmlElement, FontRelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedItalicFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontRelationshipTypeConverter.CreateOpenXmlElement<EmbedItalicFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  public static FontRelationshipType? GetEmbedBoldItalicFont(Font? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EmbedBoldItalicFont>();
    if (itemElement != null)
      return FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEmbedBoldItalicFont(Font? openXmlElement, FontRelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedBoldItalicFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontRelationshipTypeConverter.CreateOpenXmlElement<EmbedBoldItalicFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Font? CreateModelElement(Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Font();
      value.Name = GetName(openXmlElement);
      value.AltName = GetAltName(openXmlElement);
      value.Panose1Number = GetPanose1Number(openXmlElement);
      value.FontCharSet = GetFontCharSet(openXmlElement);
      value.FontFamily = GetFontFamily(openXmlElement);
      value.NotTrueType = GetNotTrueType(openXmlElement);
      value.Pitch = GetPitch(openXmlElement);
      value.FontSignature = GetFontSignature(openXmlElement);
      value.EmbedRegularFont = GetEmbedRegularFont(openXmlElement);
      value.EmbedBoldFont = GetEmbedBoldFont(openXmlElement);
      value.EmbedItalicFont = GetEmbedItalicFont(openXmlElement);
      value.EmbedBoldItalicFont = GetEmbedBoldItalicFont(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Font? value)
    where OpenXmlElementType : Font, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAltName(openXmlElement, value?.AltName);
      SetPanose1Number(openXmlElement, value?.Panose1Number);
      SetFontCharSet(openXmlElement, value?.FontCharSet);
      SetFontFamily(openXmlElement, value?.FontFamily);
      SetNotTrueType(openXmlElement, value?.NotTrueType);
      SetPitch(openXmlElement, value?.Pitch);
      SetFontSignature(openXmlElement, value?.FontSignature);
      SetEmbedRegularFont(openXmlElement, value?.EmbedRegularFont);
      SetEmbedBoldFont(openXmlElement, value?.EmbedBoldFont);
      SetEmbedItalicFont(openXmlElement, value?.EmbedItalicFont);
      SetEmbedBoldItalicFont(openXmlElement, value?.EmbedBoldItalicFont);
      return openXmlElement;
    }
    return default;
  }
}