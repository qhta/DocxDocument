namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public static class AdjustValueListConverter
{
  private static Collection<DMDraws.ShapeGuide> GetShapeGuides(DXDraw.AdjustValueList openXmlElement)
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
  
  private static bool CmpShapeGuides(DXDraw.AdjustValueList openXmlElement, Collection<DMDraws.ShapeGuide>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetShapeGuides(DXDraw.AdjustValueList openXmlElement, Collection<DMDraws.ShapeGuide>? value)
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
  
  public static DMDraws.AdjustValueList? CreateModelElement(DXDraw.AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AdjustValueList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AdjustValueList? openXmlElement, DMDraws.AdjustValueList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustValueList? value)
    where OpenXmlElementType: DXDraw.AdjustValueList, new()
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
