namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public static class FontConverter
{
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public static String? GetAltName(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    return openXmlElement?.AltName?.Val?.Value;
  }
  
  public static void SetAltName(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public static DocumentModel.HexBinary? GetPanose1Number(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPanose1Number(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontCharSet? GetFontCharSet(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFontCharSet(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontCharSet? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontFamilyKind? GetFontFamily(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontFamily>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DocumentModel.Wordprocessing.FontFamilyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFontFamily(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontFamilyKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public static Boolean? GetNotTrueType(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNotTrueType(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontPitchKind? GetPitch(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Pitch>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DocumentModel.Wordprocessing.FontPitchKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPitch(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontPitchKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontSignature? GetFontSignature(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFontSignature(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontSignature? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedRegularFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedRegularFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedBoldFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedBoldFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public static DocumentModel.Wordprocessing.FontRelationshipType? GetEmbedBoldItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedBoldItalicFont(DocumentFormat.OpenXml.Wordprocessing.Font? openXmlElement, DocumentModel.Wordprocessing.FontRelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
