namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public static class FontConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.Font openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXW.Font openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  private static String? GetAltName(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAltName(DXW.Font openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AltName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  private static Byte[]? GetPanose1Number(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Panose1Number>();
    if (itemElement != null)
      return DMX.HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  private static void SetPanose1Number(DXW.Font openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Panose1Number>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXW.Panose1Number>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  private static DMW.FontCharSet? GetFontCharSet(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FontCharSet>();
    if (itemElement != null)
      return DMXW.FontCharSetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontCharSet(DXW.Font openXmlElement, DMW.FontCharSet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontCharSet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontCharSetConverter.CreateOpenXmlElement<DXW.FontCharSet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  private static DMW.FontFamilyKind? GetFontFamily(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontFamily>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFontFamily(DXW.Font openXmlElement, DMW.FontFamilyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.FontFamily, DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  private static Boolean? GetNotTrueType(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NotTrueType>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNotTrueType(DXW.Font openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NotTrueType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NotTrueType();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  private static DMW.FontPitchKind? GetPitch(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Pitch>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPitch(DXW.Font openXmlElement, DMW.FontPitchKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Pitch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Pitch, DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  private static DMW.FontSignature? GetFontSignature(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FontSignature>();
    if (itemElement != null)
      return DMXW.FontSignatureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontSignature(DXW.Font openXmlElement, DMW.FontSignature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontSignature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontSignatureConverter.CreateOpenXmlElement<DXW.FontSignature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedRegularFont(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EmbedRegularFont>();
    if (itemElement != null)
      return DMXW.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedRegularFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedRegularFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedRegularFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedBoldFont(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EmbedBoldFont>();
    if (itemElement != null)
      return DMXW.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedBoldFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedBoldFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedItalicFont(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EmbedItalicFont>();
    if (itemElement != null)
      return DMXW.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedBoldItalicFont(DXW.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EmbedBoldItalicFont>();
    if (itemElement != null)
      return DMXW.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedBoldItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedBoldItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Font? CreateModelElement(DXW.Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Font();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Font? value)
    where OpenXmlElementType: DXW.Font, new()
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
