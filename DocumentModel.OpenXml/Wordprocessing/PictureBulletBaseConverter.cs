namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public static class PictureBulletBaseConverter
{
  private static DMVml.Group? GetGroup(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Group>();
    if (itemElement != null)
      return DMXVml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroup(DXW.PictureBulletBase openXmlElement, DMVml.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.GroupConverter.CreateOpenXmlElement<DXVml.Group>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ImageFile? GetImageFile(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ImageFile>();
    if (itemElement != null)
      return DMXVml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageFile(DXW.PictureBulletBase openXmlElement, DMVml.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ImageFileConverter.CreateOpenXmlElement<DXVml.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Line? GetLine(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Line>();
    if (itemElement != null)
      return DMXVml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine(DXW.PictureBulletBase openXmlElement, DMVml.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.LineConverter.CreateOpenXmlElement<DXVml.Line>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Oval? GetOval(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Oval>();
    if (itemElement != null)
      return DMXVml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOval(DXW.PictureBulletBase openXmlElement, DMVml.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.OvalConverter.CreateOpenXmlElement<DXVml.Oval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.PolyLine? GetPolyLine(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.PolyLine>();
    if (itemElement != null)
      return DMXVml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPolyLine(DXW.PictureBulletBase openXmlElement, DMVml.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.PolyLineConverter.CreateOpenXmlElement<DXVml.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Rectangle? GetRectangle(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Rectangle>();
    if (itemElement != null)
      return DMXVml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRectangle(DXW.PictureBulletBase openXmlElement, DMVml.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RectangleConverter.CreateOpenXmlElement<DXVml.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.RoundRectangle? GetRoundRectangle(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.RoundRectangle>();
    if (itemElement != null)
      return DMXVml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRoundRectangle(DXW.PictureBulletBase openXmlElement, DMVml.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RoundRectangleConverter.CreateOpenXmlElement<DXVml.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Shape? GetShape(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shape>();
    if (itemElement != null)
      return DMXVml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXW.PictureBulletBase openXmlElement, DMVml.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeConverter.CreateOpenXmlElement<DXVml.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Shapetype? GetShapetype(DXW.PictureBulletBase openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shapetype>();
    if (itemElement != null)
      return DMXVml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapetype(DXW.PictureBulletBase openXmlElement, DMVml.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapetypeConverter.CreateOpenXmlElement<DXVml.Shapetype>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.PictureBulletBase? CreateModelElement(DXW.PictureBulletBase? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PictureBulletBase();
      value.Group = GetGroup(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PictureBulletBase? value)
    where OpenXmlElementType: DXW.PictureBulletBase, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroup(openXmlElement, value?.Group);
      SetImageFile(openXmlElement, value?.ImageFile);
      SetLine(openXmlElement, value?.Line);
      SetOval(openXmlElement, value?.Oval);
      SetPolyLine(openXmlElement, value?.PolyLine);
      SetRectangle(openXmlElement, value?.Rectangle);
      SetRoundRectangle(openXmlElement, value?.RoundRectangle);
      SetShape(openXmlElement, value?.Shape);
      SetShapetype(openXmlElement, value?.Shapetype);
      return openXmlElement;
    }
    return default;
  }
}
