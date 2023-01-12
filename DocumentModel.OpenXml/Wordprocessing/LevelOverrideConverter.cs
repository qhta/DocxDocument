namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public static class LevelOverrideConverter
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public static Int32? GetLevelIndex(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }
  
  public static void SetLevelIndex(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LevelIndex = value;
  }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public static Int32? GetStartOverrideNumberingValue(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetStartOverrideNumberingValue(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public static DocumentModel.Wordprocessing.Level? GetLevel(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLevel(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement, DocumentModel.Wordprocessing.Level? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Level>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.LevelOverride? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LevelOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LevelOverride();
      value.LevelIndex = GetLevelIndex(openXmlElement);
      value.StartOverrideNumberingValue = GetStartOverrideNumberingValue(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LevelOverride? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LevelOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLevelIndex(openXmlElement, value?.LevelIndex);
      SetStartOverrideNumberingValue(openXmlElement, value?.StartOverrideNumberingValue);
      SetLevel(openXmlElement, value?.Level);
      return openXmlElement;
    }
    return default;
  }
}
