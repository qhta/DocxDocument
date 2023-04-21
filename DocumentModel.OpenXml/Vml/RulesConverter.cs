namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public static class RulesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Rules openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Rules openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVO.Rules openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  private static Collection<DMV.Rule>? GetItems(DXVO.Rules openXmlElement)
  {
    var collection = new Collection<DMV.Rule>();
    foreach (var item in openXmlElement.Elements<DXVO.Rule>())
    {
      var newItem = DMXV.RuleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXVO.Rules openXmlElement, Collection<DMV.Rule>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXVO.Rule>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXV.RuleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXVO.Rules openXmlElement, Collection<DMV.Rule>? value)
  {
    openXmlElement.RemoveAllChildren<DXVO.Rule>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXV.RuleConverter.CreateOpenXmlElement<DXVO.Rule>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Rules? CreateModelElement(DXVO.Rules? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Rules? openXmlElement, DMV.Rules? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Rules value)
    where OpenXmlElementType: DXVO.Rules, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Rules openXmlElement, DMV.Rules value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetItems(openXmlElement, value?.Items);
  }
}
