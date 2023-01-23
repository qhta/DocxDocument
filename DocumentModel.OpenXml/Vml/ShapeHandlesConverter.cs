namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public static class ShapeHandlesConverter
{
  private static Collection<DMVml.ShapeHandle> GetItems(DXVml.ShapeHandles openXmlElement)
  {
    var collection = new Collection<DMVml.ShapeHandle>();
    foreach (var item in openXmlElement.Elements<DXVml.ShapeHandle>())
    {
      var newItem = DMXVml.ShapeHandleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXVml.ShapeHandles openXmlElement, Collection<DMVml.ShapeHandle>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXVml.ShapeHandles openXmlElement, Collection<DMVml.ShapeHandle>? value)
  {
    openXmlElement.RemoveAllChildren<DXVml.ShapeHandle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.ShapeHandleConverter.CreateOpenXmlElement<DXVml.ShapeHandle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.ShapeHandles? CreateModelElement(DXVml.ShapeHandles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ShapeHandles();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.ShapeHandles? openXmlElement, DMVml.ShapeHandles? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeHandles? value)
    where OpenXmlElementType: DXVml.ShapeHandles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
