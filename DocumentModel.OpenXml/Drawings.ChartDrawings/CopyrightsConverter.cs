namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Copyrights Class.
/// </summary>
public static class CopyrightsConverter
{
  private static Collection<String> GetCopyrightXsdstrings(DXO2016DrawChartDraw.Copyrights openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.CopyrightXsdstring>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static bool CmpCopyrightXsdstrings(DXO2016DrawChartDraw.Copyrights openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.CopyrightXsdstring>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCopyrightXsdstrings(DXO2016DrawChartDraw.Copyrights openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.CopyrightXsdstring>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.CopyrightXsdstring>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.Copyrights? CreateModelElement(DXO2016DrawChartDraw.Copyrights? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Copyrights();
      value.CopyrightXsdstrings = GetCopyrightXsdstrings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Copyrights? openXmlElement, DMDrawsChartDraws.Copyrights? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCopyrightXsdstrings(openXmlElement, value.CopyrightXsdstrings, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Copyrights? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Copyrights, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCopyrightXsdstrings(openXmlElement, value?.CopyrightXsdstrings);
      return openXmlElement;
    }
    return default;
  }
}
