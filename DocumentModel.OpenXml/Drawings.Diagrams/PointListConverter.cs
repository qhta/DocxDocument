namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public static class PointListConverter
{
  private static Collection<DMDrawsDgms.Point> GetPoints(DXDrawDgms.PointList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Point>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Point>())
    {
      var newItem = DMXDrawsDgms.PointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPoints(DXDrawDgms.PointList openXmlElement, Collection<DMDrawsDgms.Point>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetPoints(DXDrawDgms.PointList openXmlElement, Collection<DMDrawsDgms.Point>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.PointConverter.CreateOpenXmlElement<DXDrawDgms.Point>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.PointList? CreateModelElement(DXDrawDgms.PointList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.PointList();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.PointList? openXmlElement, DMDrawsDgms.PointList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoints(openXmlElement, value.Points, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PointList? value)
    where OpenXmlElementType: DXDrawDgms.PointList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoints(openXmlElement, value?.Points);
      return openXmlElement;
    }
    return default;
  }
}
