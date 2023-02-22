namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public static class HeaderShapeDefaultsConverter
{
  private static DMVml.ShapeDefaults? GetShapeDefaults(DXW.HeaderShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.ShapeDefaults>();
    if (element != null)
      return DMXVml.ShapeDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeDefaults(DXW.HeaderShapeDefaults openXmlElement, DMVml.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ShapeDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeDefaults(DXW.HeaderShapeDefaults openXmlElement, DMVml.ShapeDefaults? value)
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
  
  private static DMVml.ShapeLayout? GetShapeLayout(DXW.HeaderShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.ShapeLayout>();
    if (element != null)
      return DMXVml.ShapeLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLayout(DXW.HeaderShapeDefaults openXmlElement, DMVml.ShapeLayout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ShapeLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeLayout(DXW.HeaderShapeDefaults openXmlElement, DMVml.ShapeLayout? value)
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
  
  public static DocumentModel.Wordprocessing.HeaderShapeDefaults? CreateModelElement(DXW.HeaderShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HeaderShapeDefaults();
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.HeaderShapeDefaults? openXmlElement, DMW.HeaderShapeDefaults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeDefaults(openXmlElement, value.ShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpShapeLayout(openXmlElement, value.ShapeLayout, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderShapeDefaults value)
    where OpenXmlElementType: DXW.HeaderShapeDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.HeaderShapeDefaults openXmlElement, DMW.HeaderShapeDefaults value)
  {
    SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
    SetShapeLayout(openXmlElement, value?.ShapeLayout);
    }
  }
