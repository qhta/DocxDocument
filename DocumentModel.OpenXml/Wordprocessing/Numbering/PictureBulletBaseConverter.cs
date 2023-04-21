namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public static class PictureBulletBaseConverter
{
  private static DMV.Group? GetGroup(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Group>();
    if (element != null)
      return DMXV.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroup(DXW.PictureBulletBase openXmlElement, DMV.Group? value, DiffList? diffs, string? objName)
  {
    return DMXV.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Group>(), value, diffs, objName);
  }
  
  private static void SetGroup(DXW.PictureBulletBase openXmlElement, DMV.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.GroupConverter.CreateOpenXmlElement<DXV.Group>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.ImageFile? GetImageFile(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageFile>();
    if (element != null)
      return DMXV.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXW.PictureBulletBase openXmlElement, DMV.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXV.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageFile>(), value, diffs, objName);
  }
  
  private static void SetImageFile(DXW.PictureBulletBase openXmlElement, DMV.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageFileConverter.CreateOpenXmlElement<DXV.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Line? GetLine(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Line>();
    if (element != null)
      return DMXV.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXW.PictureBulletBase openXmlElement, DMV.Line? value, DiffList? diffs, string? objName)
  {
    return DMXV.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Line>(), value, diffs, objName);
  }
  
  private static void SetLine(DXW.PictureBulletBase openXmlElement, DMV.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LineConverter.CreateOpenXmlElement<DXV.Line>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Oval? GetOval(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Oval>();
    if (element != null)
      return DMXV.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXW.PictureBulletBase openXmlElement, DMV.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXV.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Oval>(), value, diffs, objName);
  }
  
  private static void SetOval(DXW.PictureBulletBase openXmlElement, DMV.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.OvalConverter.CreateOpenXmlElement<DXV.Oval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.PolyLine? GetPolyLine(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.PolyLine>();
    if (element != null)
      return DMXV.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXW.PictureBulletBase openXmlElement, DMV.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXV.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.PolyLine>(), value, diffs, objName);
  }
  
  private static void SetPolyLine(DXW.PictureBulletBase openXmlElement, DMV.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.PolyLineConverter.CreateOpenXmlElement<DXV.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Rectangle? GetRectangle(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Rectangle>();
    if (element != null)
      return DMXV.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXW.PictureBulletBase openXmlElement, DMV.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Rectangle>(), value, diffs, objName);
  }
  
  private static void SetRectangle(DXW.PictureBulletBase openXmlElement, DMV.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RectangleConverter.CreateOpenXmlElement<DXV.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.RoundRectangle? GetRoundRectangle(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.RoundRectangle>();
    if (element != null)
      return DMXV.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXW.PictureBulletBase openXmlElement, DMV.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.RoundRectangle>(), value, diffs, objName);
  }
  
  private static void SetRoundRectangle(DXW.PictureBulletBase openXmlElement, DMV.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RoundRectangleConverter.CreateOpenXmlElement<DXV.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Shape? GetShape(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shape>();
    if (element != null)
      return DMXV.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXW.PictureBulletBase openXmlElement, DMV.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXW.PictureBulletBase openXmlElement, DMV.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeConverter.CreateOpenXmlElement<DXV.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Shapetype? GetShapetype(DXW.PictureBulletBase openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shapetype>();
    if (element != null)
      return DMXV.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXW.PictureBulletBase openXmlElement, DMV.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shapetype>(), value, diffs, objName);
  }
  
  private static void SetShapetype(DXW.PictureBulletBase openXmlElement, DMV.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapetypeConverter.CreateOpenXmlElement<DXV.Shapetype>(value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PictureBulletBase value)
    where OpenXmlElementType: DXW.PictureBulletBase, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PictureBulletBase openXmlElement, DMW.PictureBulletBase value)
  {
    SetGroup(openXmlElement, value?.Group);
    SetImageFile(openXmlElement, value?.ImageFile);
    SetLine(openXmlElement, value?.Line);
    SetOval(openXmlElement, value?.Oval);
    SetPolyLine(openXmlElement, value?.PolyLine);
    SetRectangle(openXmlElement, value?.Rectangle);
    SetRoundRectangle(openXmlElement, value?.RoundRectangle);
    SetShape(openXmlElement, value?.Shape);
    SetShapetype(openXmlElement, value?.Shapetype);
  }
}
