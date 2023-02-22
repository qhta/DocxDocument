namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public static class AlgorithmConverter
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  private static DMDrawsDgms.AlgorithmKind? GetType(DXDrawDgms.Algorithm openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDrawsDgms.AlgorithmKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.AlgorithmKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDrawsDgms.AlgorithmKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.AlgorithmKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDrawsDgms.AlgorithmKind>(value);
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  private static UInt32? GetRevision(DXDrawDgms.Algorithm openXmlElement)
  {
    return openXmlElement?.Revision?.Value;
  }
  
  private static bool CmpRevision(DXDrawDgms.Algorithm openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Revision?.Value == value) return true;
    diffs?.Add(objName, "Revision", openXmlElement?.Revision?.Value, value);
    return false;
  }
  
  private static void SetRevision(DXDrawDgms.Algorithm openXmlElement, UInt32? value)
  {
    openXmlElement.Revision = value;
  }
  
  private static Collection<DMDrawsDgms.Parameter>? GetParameters(DXDrawDgms.Algorithm openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Parameter>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Parameter>())
    {
      var newItem = DMXDrawsDgms.ParameterConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpParameters(DXDrawDgms.Algorithm openXmlElement, Collection<DMDrawsDgms.Parameter>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Parameter>();
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
        if (!DMXDrawsDgms.ParameterConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetParameters(DXDrawDgms.Algorithm openXmlElement, Collection<DMDrawsDgms.Parameter>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Parameter>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ParameterConverter.CreateOpenXmlElement<DXDrawDgms.Parameter>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Algorithm openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? CreateModelElement(DXDrawDgms.Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Algorithm();
      value.Type = GetType(openXmlElement);
      value.Revision = GetRevision(openXmlElement);
      value.Parameters = GetParameters(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Algorithm? openXmlElement, DMDrawsDgms.Algorithm? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpRevision(openXmlElement, value.Revision, diffs, objName))
        ok = false;
      if (!CmpParameters(openXmlElement, value.Parameters, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Algorithm value)
    where OpenXmlElementType: DXDrawDgms.Algorithm, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.Algorithm value)
  {
    SetType(openXmlElement, value?.Type);
    SetRevision(openXmlElement, value?.Revision);
    SetParameters(openXmlElement, value?.Parameters);
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
