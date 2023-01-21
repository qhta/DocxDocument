namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public static class HeaderShapeDefaultsConverter
{
  private static DMVml.ShapeDefaults? GetShapeDefaults(DXW.HeaderShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ShapeDefaults>();
    if (itemElement != null)
      return DMXVml.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ShapeLayout>();
    if (itemElement != null)
      return DMXVml.ShapeLayoutConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.HeaderShapeDefaults? CreateModelElement(DXW.HeaderShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.HeaderShapeDefaults();
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderShapeDefaults? value)
    where OpenXmlElementType: DXW.HeaderShapeDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
      SetShapeLayout(openXmlElement, value?.ShapeLayout);
      return openXmlElement;
    }
    return default;
  }
}
