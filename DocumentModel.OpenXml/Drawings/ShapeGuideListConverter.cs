namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Guides.
/// </summary>
public static class ShapeGuideListConverter
{
  private static Collection<DMDraws.ShapeGuide> GetShapeGuides(DXDraw.ShapeGuideList openXmlElement)
  {
    var collection = new Collection<DMDraws.ShapeGuide>();
    foreach (var item in openXmlElement.Elements<DXDraw.ShapeGuide>())
    {
      var newItem = DMXDraws.ShapeGuideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpShapeGuides(DXDraw.ShapeGuideList openXmlElement, Collection<DMDraws.ShapeGuide>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetShapeGuides(DXDraw.ShapeGuideList openXmlElement, Collection<DMDraws.ShapeGuide>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ShapeGuide>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ShapeGuideConverter.CreateOpenXmlElement<DXDraw.ShapeGuide>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.ShapeGuideList? CreateModelElement(DXDraw.ShapeGuideList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ShapeGuideList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ShapeGuideList? openXmlElement, DMDraws.ShapeGuideList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeGuides(openXmlElement, value.ShapeGuides, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapeGuideList? value)
    where OpenXmlElementType: DXDraw.ShapeGuideList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeGuides(openXmlElement, value?.ShapeGuides);
      return openXmlElement;
    }
    return default;
  }
}
