namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public static class ShapeDefaultsConverter
{
  private static DMVml.ShapeDefaults? GetChildShapeDefaults(DXW.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ShapeDefaults>();
    if (itemElement != null)
      return DMXVml.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ShapeLayout>();
    if (itemElement != null)
      return DMXVml.ShapeLayoutConverter.CreateModelElement(itemElement);
    return null;
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
