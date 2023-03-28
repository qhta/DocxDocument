namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Rule ID
  /// </summary>
  private static String? GetId(DXVmlO.Rule openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVmlO.Rule openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVmlO.Rule openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  private static DMVml.RuleKind? GetType(DXVmlO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMVml.RuleKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVmlO.Rule openXmlElement, DMVml.RuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMVml.RuleKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVmlO.Rule openXmlElement, DMVml.RuleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMVml.RuleKind>(value);
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  private static DMVml.AlignmentKind? GetHow(DXVmlO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMVml.AlignmentKind>(openXmlElement?.How?.Value);
  }
  
  private static bool CmpHow(DXVmlO.Rule openXmlElement, DMVml.AlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMVml.AlignmentKind>(openXmlElement?.How?.Value, value, diffs, objName);
  }
  
  private static void SetHow(DXVmlO.Rule openXmlElement, DMVml.AlignmentKind? value)
  {
    openXmlElement.How = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMVml.AlignmentKind>(value);
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  private static String? GetShapeReference(DXVmlO.Rule openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeReference);
  }
  
  private static bool CmpShapeReference(DXVmlO.Rule openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeReference, value, diffs, objName, "ShapeReference");
  }
  
  private static void SetShapeReference(DXVmlO.Rule openXmlElement, String? value)
  {
    openXmlElement.ShapeReference = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMVml.Proxy>? GetProxies(DXVmlO.Rule openXmlElement)
  {
    var collection = new Collection<DMVml.Proxy>();
    foreach (var item in openXmlElement.Elements<DXVmlO.Proxy>())
    {
      var newItem = DMXVml.ProxyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpProxies(DXVmlO.Rule openXmlElement, Collection<DMVml.Proxy>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXVmlO.Proxy>();
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
        if (!DMXVml.ProxyConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetProxies(DXVmlO.Rule openXmlElement, Collection<DMVml.Proxy>? value)
  {
    openXmlElement.RemoveAllChildren<DXVmlO.Proxy>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.ProxyConverter.CreateOpenXmlElement<DXVmlO.Proxy>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Rule? CreateModelElement(DXVmlO.Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Rule();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.How = GetHow(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.Proxies = GetProxies(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Rule? openXmlElement, DMVml.Rule? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpHow(openXmlElement, value.How, diffs, objName))
        ok = false;
      if (!CmpShapeReference(openXmlElement, value.ShapeReference, diffs, objName))
        ok = false;
      if (!CmpProxies(openXmlElement, value.Proxies, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Rule value)
    where OpenXmlElementType: DXVmlO.Rule, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Rule openXmlElement, DMVml.Rule value)
  {
    SetId(openXmlElement, value?.Id);
    SetType(openXmlElement, value?.Type);
    SetHow(openXmlElement, value?.How);
    SetShapeReference(openXmlElement, value?.ShapeReference);
    SetProxies(openXmlElement, value?.Proxies);
  }
}
