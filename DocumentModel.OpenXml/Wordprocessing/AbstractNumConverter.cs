namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  private static Int32? GetAbstractNumberId(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    return openXmlElement.AbstractNumberId?.Value;
  }
  
  private static void SetAbstractNumberId(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, Int32? value)
  {
    openXmlElement.AbstractNumberId = value;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  private static UInt32? GetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    if (openXmlElement.Nsid?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.Nsid.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.Nsid = new DocumentFormat.OpenXml.Wordprocessing.Nsid { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.Nsid = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  private static DocumentModel.Wordprocessing.MultiLevelKind? GetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DocumentModel.Wordprocessing.MultiLevelKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, DocumentModel.Wordprocessing.MultiLevelKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DocumentModel.Wordprocessing.MultiLevelKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  private static UInt32? GetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    if (openXmlElement.TemplateCode?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.TemplateCode.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.TemplateCode = new DocumentFormat.OpenXml.Wordprocessing.TemplateCode { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.TemplateCode = null;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  private static String? GetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  private static String? GetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.StyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  private static String? GetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level> GetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Level>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Level>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Level>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AbstractNum? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AbstractNum();
      value.AbstractNumberId = GetAbstractNumberId(openXmlElement);
      value.Nsid = GetNsid(openXmlElement);
      value.MultiLevelType = GetMultiLevelType(openXmlElement);
      value.TemplateCode = GetTemplateCode(openXmlElement);
      value.AbstractNumDefinitionName = GetAbstractNumDefinitionName(openXmlElement);
      value.StyleLink = GetStyleLink(openXmlElement);
      value.NumberingStyleLink = GetNumberingStyleLink(openXmlElement);
      value.Levels = GetLevels(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AbstractNum? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.AbstractNum, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAbstractNumberId(openXmlElement, value?.AbstractNumberId);
      SetNsid(openXmlElement, value?.Nsid);
      SetMultiLevelType(openXmlElement, value?.MultiLevelType);
      SetTemplateCode(openXmlElement, value?.TemplateCode);
      SetAbstractNumDefinitionName(openXmlElement, value?.AbstractNumDefinitionName);
      SetStyleLink(openXmlElement, value?.StyleLink);
      SetNumberingStyleLink(openXmlElement, value?.NumberingStyleLink);
      SetLevels(openXmlElement, value?.Levels);
      return openXmlElement;
    }
    return default;
  }
}
