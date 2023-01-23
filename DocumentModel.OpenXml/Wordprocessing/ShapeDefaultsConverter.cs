namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public static class ShapeDefaultsConverter
{
  private static DMVml.ShapeDefaults? GetChildShapeDefaults(DXW.ShapeDefaults openXmlElement)
  {
    return DMXVml.ShapeDefaultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeDefaults>());
  }
  
  private static bool CmpChildShapeDefaults(DXW.ShapeDefaults openXmlElement, DMVml.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeDefaultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildShapeDefaults(DXW.ShapeDefaults openXmlElement, DMVml.ShapeDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ShapeDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeDefaultsConverter.CreateOpenXmlElement<DXVmlO.ShapeDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ShapeLayout? GetShapeLayout(DXW.ShapeDefaults openXmlElement)
  {
    return DMXVml.ShapeLayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeLayout>());
  }
  
  private static bool CmpShapeLayout(DXW.ShapeDefaults openXmlElement, DMVml.ShapeLayout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeLayoutConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeLayout(DXW.ShapeDefaults openXmlElement, DMVml.ShapeLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ShapeLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeLayoutConverter.CreateOpenXmlElement<DXVmlO.ShapeLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.ShapeDefaults? CreateModelElement(DXW.ShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ShapeDefaults();
      value.ChildShapeDefaults = GetChildShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ShapeDefaults? openXmlElement, DMW.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChildShapeDefaults(openXmlElement, value.ChildShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpShapeLayout(openXmlElement, value.ShapeLayout, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ShapeDefaults? value)
    where OpenXmlElementType: DXW.ShapeDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChildShapeDefaults(openXmlElement, value?.ChildShapeDefaults);
      SetShapeLayout(openXmlElement, value?.ShapeLayout);
      return openXmlElement;
    }
    return default;
  }
}
