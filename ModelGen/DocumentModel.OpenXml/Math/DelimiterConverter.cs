namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public static class DelimiterConverter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  private static DMMath.DelimiterProperties? GetDelimiterProperties(DXMath.Delimiter openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.DelimiterProperties>();
    if (element != null)
      return DMXMath.DelimiterPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiterProperties(DXMath.Delimiter openXmlElement, DMMath.DelimiterProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.DelimiterProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDelimiterProperties(DXMath.Delimiter openXmlElement, DMMath.DelimiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DelimiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterPropertiesConverter.CreateOpenXmlElement<DXMath.DelimiterProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMMath.Base>? GetBases(DXMath.Delimiter openXmlElement)
  {
    var collection = new Collection<DMMath.Base>();
    foreach (var item in openXmlElement.Elements<DXMath.Base>())
    {
      var newItem = DMXMath.BaseConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBases(DXMath.Delimiter openXmlElement, Collection<DMMath.Base>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXMath.Base>();
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
        if (!DMXMath.BaseConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBases(DXMath.Delimiter openXmlElement, Collection<DMMath.Base>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.Base>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Math.Delimiter? CreateModelElement(DXMath.Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Delimiter();
      value.DelimiterProperties = GetDelimiterProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Delimiter? openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDelimiterProperties(openXmlElement, value.DelimiterProperties, diffs, objName))
        ok = false;
      if (!CmpBases(openXmlElement, value.Bases, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Delimiter value)
    where OpenXmlElementType: DXMath.Delimiter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Delimiter openXmlElement, DMMath.Delimiter value)
  {
    SetDelimiterProperties(openXmlElement, value?.DelimiterProperties);
    SetBases(openXmlElement, value?.Bases);
  }
}
