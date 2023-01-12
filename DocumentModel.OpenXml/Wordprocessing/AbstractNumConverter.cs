namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  public static Int32? GetAbstractNumberId(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    return openXmlElement?.AbstractNumberId?.Value;
  }
  
  public static void SetAbstractNumberId(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.AbstractNumberId = value;
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public static DocumentModel.HexWord? GetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Nsid>();
    if (itemElement != null)
      return HexWordConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.HexWord? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Nsid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexWordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Nsid>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MultiLevelKind? GetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DocumentModel.Wordprocessing.MultiLevelKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.Wordprocessing.MultiLevelKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public static DocumentModel.HexWord? GetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TemplateCode>();
    if (itemElement != null)
      return HexWordConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.HexWord? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TemplateCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexWordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TemplateCode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public static String? GetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName");
  }
  
  public static void SetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName");
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public static String? GetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.StyleLink");
  }
  
  public static void SetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.StyleLink");
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public static String? GetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink");
  }
  
  public static void SetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>? GetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>? value)
  {
    if (openXmlElement != null)
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
      return openXmlElement;
    }
    return default;
  }
}
