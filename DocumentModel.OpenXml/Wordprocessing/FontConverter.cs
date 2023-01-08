namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public static class FontConverter
{
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
  
}
