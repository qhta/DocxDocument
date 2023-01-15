using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Rules = DocumentFormat.OpenXml.Vml.Office.Rules;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Rule Set.
/// </summary>
public static class RulesConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Rules? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Rules? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  public static Collection<Rule>? GetItems(Rules? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Rule>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Rule>())
      {
        var newItem = RuleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Rules? openXmlElement, Collection<Rule>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Rule>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RuleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Rule>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.Rules? CreateModelElement(Rules? openXmlElement)
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
    where OpenXmlElementType : Rules, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}