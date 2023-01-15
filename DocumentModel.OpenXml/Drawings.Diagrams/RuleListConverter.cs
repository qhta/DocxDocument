using DocumentModel.Drawings.Diagrams;
using RuleList = DocumentFormat.OpenXml.Drawing.Diagrams.RuleList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Rule List.
/// </summary>
public static class RuleListConverter
{
  public static Collection<Rule>? GetRules(RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Rule>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>())
      {
        var newItem = RuleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRules(RuleList? openXmlElement, Collection<Rule>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RuleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.RuleList? CreateModelElement(RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.RuleList();
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.RuleList? value)
    where OpenXmlElementType : RuleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRules(openXmlElement, value?.Rules);
      return openXmlElement;
    }
    return default;
  }
}