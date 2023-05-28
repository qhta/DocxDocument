namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public static class AlgorithmConverter
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  private static DMDD.AlgorithmKind? GetType(DXDD.Algorithm openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDD.AlgorithmKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDD.Algorithm openXmlElement, DMDD.AlgorithmKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDD.AlgorithmKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXDD.Algorithm openXmlElement, DMDD.AlgorithmKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDD.AlgorithmKind>(value);
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  private static UInt32? GetRevision(DXDD.Algorithm openXmlElement)
  {
    return openXmlElement?.Revision?.Value;
  }
  
  private static bool CmpRevision(DXDD.Algorithm openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Revision?.Value == value) return true;
    diffs?.Add(objName, "Revision", openXmlElement?.Revision?.Value, value);
    return false;
  }
  
  private static void SetRevision(DXDD.Algorithm openXmlElement, UInt32? value)
  {
    openXmlElement.Revision = value;
  }
  
  private static Collection<DMDD.Parameter>? GetParameters(DXDD.Algorithm openXmlElement)
  {
    var collection = new Collection<DMDD.Parameter>();
    foreach (var item in openXmlElement.Elements<DXDD.Parameter>())
    {
      var newItem = DMXDD.ParameterConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpParameters(DXDD.Algorithm openXmlElement, Collection<DMDD.Parameter>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.Parameter>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDD.ParameterConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetParameters(DXDD.Algorithm openXmlElement, Collection<DMDD.Parameter>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Parameter>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ParameterConverter.CreateOpenXmlElement<DXDD.Parameter>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.Algorithm openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.Algorithm openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.Algorithm openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.Algorithm? CreateModelElement(DXDD.Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Algorithm();
      value.Type = GetType(openXmlElement);
      value.Revision = GetRevision(openXmlElement);
      value.Parameters = GetParameters(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Algorithm? openXmlElement, DMDD.Algorithm? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpRevision(openXmlElement, value.Revision, diffs, objName, propName))
        ok = false;
      if (!CmpParameters(openXmlElement, value.Parameters, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Algorithm value)
    where OpenXmlElementType: DXDD.Algorithm, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Algorithm openXmlElement, DMDD.Algorithm value)
  {
    SetType(openXmlElement, value?.Type);
    SetRevision(openXmlElement, value?.Revision);
    SetParameters(openXmlElement, value?.Parameters);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
