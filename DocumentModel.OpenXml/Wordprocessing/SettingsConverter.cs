namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public static class SettingsConverter
{
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.ViewKind? GetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ViewKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.Zoom? GetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Zoom? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DocumentKind? GetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CharacterSpacingKind? GetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.CharacterSpacingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ConflictMode, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
