namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public static class FontConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  private static String? GetAltName(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAltName(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.AltName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  private static Byte[]? GetPanose1Number(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Panose1Number>();
    if (itemElement != null)
      return DocumentModel.OpenXml.HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  private static void SetPanose1Number(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Panose1Number>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.HexBinaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Panose1Number>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontCharSet? GetFontCharSet(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontCharSetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontCharSet(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontCharSet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontCharSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontFamilyKind? GetFontFamily(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontFamily>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DocumentModel.Wordprocessing.FontFamilyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFontFamily(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontFamilyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontFamily, DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DocumentModel.Wordprocessing.FontFamilyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  private static Boolean? GetNotTrueType(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNotTrueType(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NotTrueType();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontPitchKind? GetPitch(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Pitch>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DocumentModel.Wordprocessing.FontPitchKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPitch(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontPitchKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Pitch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Pitch, DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DocumentModel.Wordprocessing.FontPitchKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontSignature? GetFontSignature(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontSignatureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontSignature(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontSignature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontSignatureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FontSignature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedRegularFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedRegularFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedRegularFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedRegularFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbedRegularFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedBoldFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedBoldFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedItalicFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbedItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  private static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedBoldItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldItalicFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEmbedBoldItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FontRelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmbedBoldItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Font? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Font, new()
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
