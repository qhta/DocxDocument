namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public static class RulesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Rules? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Rules? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Rule>? GetItems(DocumentFormat.OpenXml.Vml.Office.Rules? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.Rule>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Rule>())
      {
        var newItem = DocumentModel.OpenXml.Vml.RuleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Vml.Office.Rules? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Rule>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Rule>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Vml.RuleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Rule>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Vml.Rules? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Rules? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Rules();
      value.Extension = GetExtension(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Rules? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Rules, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      return openXmlElement;
    }
    return default;
  }
}
