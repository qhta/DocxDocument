namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Rule ID
  /// </summary>
  private static String? GetId(DXVO.Rule openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVO.Rule openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXVO.Rule openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  private static DMV.RuleKind? GetType(DXVO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMV.RuleKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVO.Rule openXmlElement, DMV.RuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMV.RuleKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVO.Rule openXmlElement, DMV.RuleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMV.RuleKind>(value);
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  private static DMV.AlignmentKind? GetHow(DXVO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMV.AlignmentKind>(openXmlElement?.How?.Value);
  }
  
  private static bool CmpHow(DXVO.Rule openXmlElement, DMV.AlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMV.AlignmentKind>(openXmlElement?.How?.Value, value, diffs, objName);
  }
  
  private static void SetHow(DXVO.Rule openXmlElement, DMV.AlignmentKind? value)
  {
    openXmlElement.How = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMV.AlignmentKind>(value);
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  private static String? GetShapeReference(DXVO.Rule openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeReference);
  }
  
  private static bool CmpShapeReference(DXVO.Rule openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeReference, value, diffs, objName, "ShapeReference");
  }
  
  private static void SetShapeReference(DXVO.Rule openXmlElement, String? value)
  {
    openXmlElement.ShapeReference = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMV.Proxy>? GetProxies(DXVO.Rule openXmlElement)
  {
    var collection = new Collection<DMV.Proxy>();
    foreach (var item in openXmlElement.Elements<DXVO.Proxy>())
    {
      var newItem = DMXV.ProxyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpProxies(DXVO.Rule openXmlElement, Collection<DMV.Proxy>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXVO.Proxy>();
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
        if (!DMXV.ProxyConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetProxies(DXVO.Rule openXmlElement, Collection<DMV.Proxy>? value)
  {
    openXmlElement.RemoveAllChildren<DXVO.Proxy>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXV.ProxyConverter.CreateOpenXmlElement<DXVO.Proxy>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Rule? CreateModelElement(DXVO.Rule? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Rule? openXmlElement, DMV.Rule? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Rule value)
    where OpenXmlElementType: DXVO.Rule, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Rule openXmlElement, DMV.Rule value)
  {
    SetId(openXmlElement, value?.Id);
    SetType(openXmlElement, value?.Type);
    SetHow(openXmlElement, value?.How);
    SetShapeReference(openXmlElement, value?.ShapeReference);
    SetProxies(openXmlElement, value?.Proxies);
  }
}
