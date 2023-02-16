namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public static class PictureBulletBaseConverter
{
  private static DMVml.Group? GetGroup(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Group>();
    if (element != null)
      return DMXVml.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroup(DXW.PictureBulletBase openXmlElement, DMVml.Group? value, DiffList? diffs, string? objName)
  {
    return DMXVml.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Group>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.ImageFile>();
    if (element != null)
      return DMXVml.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXW.PictureBulletBase openXmlElement, DMVml.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageFile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Line>();
    if (element != null)
      return DMXVml.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXW.PictureBulletBase openXmlElement, DMVml.Line? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Line>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Oval>();
    if (element != null)
      return DMXVml.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXW.PictureBulletBase openXmlElement, DMVml.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXVml.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Oval>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.PolyLine>();
    if (element != null)
      return DMXVml.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXW.PictureBulletBase openXmlElement, DMVml.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.PolyLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Rectangle>();
    if (element != null)
      return DMXVml.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXW.PictureBulletBase openXmlElement, DMVml.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Rectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.RoundRectangle>();
    if (element != null)
      return DMXVml.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXW.PictureBulletBase openXmlElement, DMVml.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.RoundRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Shape>();
    if (element != null)
      return DMXVml.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXW.PictureBulletBase openXmlElement, DMVml.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Shapetype>();
    if (element != null)
      return DMXVml.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXW.PictureBulletBase openXmlElement, DMVml.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shapetype>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.PictureBulletBase? CreateModelElement(DXW.PictureBulletBase? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PictureBulletBase();
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
  
  public static bool CompareModelElement(DXW.PictureBulletBase? openXmlElement, DMW.PictureBulletBase? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroup(openXmlElement, value.Group, diffs, objName))
        ok = false;
      if (!CmpImageFile(openXmlElement, value.ImageFile, diffs, objName))
        ok = false;
      if (!CmpLine(openXmlElement, value.Line, diffs, objName))
        ok = false;
      if (!CmpOval(openXmlElement, value.Oval, diffs, objName))
        ok = false;
      if (!CmpPolyLine(openXmlElement, value.PolyLine, diffs, objName))
        ok = false;
      if (!CmpRectangle(openXmlElement, value.Rectangle, diffs, objName))
        ok = false;
      if (!CmpRoundRectangle(openXmlElement, value.RoundRectangle, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpShapetype(openXmlElement, value.Shapetype, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
