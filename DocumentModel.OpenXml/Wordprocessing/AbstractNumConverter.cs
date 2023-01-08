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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAbstractNumberId(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public static DocumentModel.HexWord? GetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNsid(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.HexWord? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTemplateCode(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.HexWord? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public static String? GetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName");
  }
  
  public static void SetAbstractNumDefinitionName(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public static String? GetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.StyleLink");
  }
  
  public static void SetStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public static String? GetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink");
  }
  
  public static void SetNumberingStyleLink(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>? GetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevels(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Level>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
