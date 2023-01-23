namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public static class AdjustListConverter
{
  private static Collection<DMDrawsDgms.Adjust> GetAdjusts(DXDrawDgms.AdjustList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Adjust>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Adjust>())
    {
      var newItem = DMXDrawsDgms.AdjustConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAdjusts(DXDrawDgms.AdjustList openXmlElement, Collection<DMDrawsDgms.Adjust>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAdjusts(DXDrawDgms.AdjustList openXmlElement, Collection<DMDrawsDgms.Adjust>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Adjust>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.AdjustConverter.CreateOpenXmlElement<DXDrawDgms.Adjust>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.AdjustList? CreateModelElement(DXDrawDgms.AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.AdjustList();
      value.Adjusts = GetAdjusts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.AdjustList? openXmlElement, DMDrawsDgms.AdjustList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAdjusts(openXmlElement, value.Adjusts, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.AdjustList? value)
    where OpenXmlElementType: DXDrawDgms.AdjustList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjusts(openXmlElement, value?.Adjusts);
      return openXmlElement;
    }
    return default;
  }
}
