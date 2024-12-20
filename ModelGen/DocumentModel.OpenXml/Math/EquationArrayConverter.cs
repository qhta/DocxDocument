namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public static class EquationArrayConverter
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  private static DMMath.EquationArrayProperties? GetEquationArrayProperties(DXMath.EquationArray openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.EquationArrayProperties>();
    if (element != null)
      return DMXMath.EquationArrayPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArrayProperties(DXMath.EquationArray openXmlElement, DMMath.EquationArrayProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.EquationArrayProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEquationArrayProperties(DXMath.EquationArray openXmlElement, DMMath.EquationArrayProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArrayProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayPropertiesConverter.CreateOpenXmlElement<DXMath.EquationArrayProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMMath.Base>? GetBases(DXMath.EquationArray openXmlElement)
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
  
  private static bool CmpBases(DXMath.EquationArray openXmlElement, Collection<DMMath.Base>? value, DiffList? diffs, string? objName)
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
  
  private static void SetBases(DXMath.EquationArray openXmlElement, Collection<DMMath.Base>? value)
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
  
  public static DocumentModel.Math.EquationArray? CreateModelElement(DXMath.EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.EquationArray();
      value.EquationArrayProperties = GetEquationArrayProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.EquationArray? openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEquationArrayProperties(openXmlElement, value.EquationArrayProperties, diffs, objName))
        ok = false;
      if (!CmpBases(openXmlElement, value.Bases, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.EquationArray value)
    where OpenXmlElementType: DXMath.EquationArray, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.EquationArray openXmlElement, DMMath.EquationArray value)
  {
    SetEquationArrayProperties(openXmlElement, value?.EquationArrayProperties);
    SetBases(openXmlElement, value?.Bases);
  }
}
