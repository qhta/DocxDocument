namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// VML Object.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetAnchorId(DXW.Picture openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AnchorId.Value);
    return null;
  }
  
  private static bool CmpAnchorId(DXW.Picture openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.AnchorId?.Value, value, diffs, objName, "AnchorId");
  }
  
  private static void SetAnchorId(DXW.Picture openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AnchorId = value.ToString();
    else
      openXmlElement.AnchorId = null;
  }
  
  private static DMV.Group? GetGroup(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Group>();
    if (element != null)
      return DMXV.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroup(DXW.Picture openXmlElement, DMV.Group? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Group>(), value, diffs, objName, propName);
  }
  
  private static void SetGroup(DXW.Picture openXmlElement, DMV.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.GroupConverter.CreateOpenXmlElement<DXV.Group>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ImageFile? GetImageFile(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageFile>();
    if (element != null)
      return DMXV.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXW.Picture openXmlElement, DMV.ImageFile? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageFile>(), value, diffs, objName, propName);
  }
  
  private static void SetImageFile(DXW.Picture openXmlElement, DMV.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageFileConverter.CreateOpenXmlElement<DXV.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Line? GetLine(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Line>();
    if (element != null)
      return DMXV.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXW.Picture openXmlElement, DMV.Line? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Line>(), value, diffs, objName, propName);
  }
  
  private static void SetLine(DXW.Picture openXmlElement, DMV.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LineConverter.CreateOpenXmlElement<DXV.Line>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Oval? GetOval(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Oval>();
    if (element != null)
      return DMXV.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXW.Picture openXmlElement, DMV.Oval? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Oval>(), value, diffs, objName, propName);
  }
  
  private static void SetOval(DXW.Picture openXmlElement, DMV.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.OvalConverter.CreateOpenXmlElement<DXV.Oval>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.PolyLine? GetPolyLine(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.PolyLine>();
    if (element != null)
      return DMXV.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXW.Picture openXmlElement, DMV.PolyLine? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.PolyLine>(), value, diffs, objName, propName);
  }
  
  private static void SetPolyLine(DXW.Picture openXmlElement, DMV.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.PolyLineConverter.CreateOpenXmlElement<DXV.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Rectangle? GetRectangle(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Rectangle>();
    if (element != null)
      return DMXV.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXW.Picture openXmlElement, DMV.Rectangle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Rectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetRectangle(DXW.Picture openXmlElement, DMV.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RectangleConverter.CreateOpenXmlElement<DXV.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.RoundRectangle? GetRoundRectangle(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.RoundRectangle>();
    if (element != null)
      return DMXV.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXW.Picture openXmlElement, DMV.RoundRectangle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.RoundRectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetRoundRectangle(DXW.Picture openXmlElement, DMV.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RoundRectangleConverter.CreateOpenXmlElement<DXV.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Shape? GetShape(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shape>();
    if (element != null)
      return DMXV.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXW.Picture openXmlElement, DMV.Shape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shape>(), value, diffs, objName, propName);
  }
  
  private static void SetShape(DXW.Picture openXmlElement, DMV.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeConverter.CreateOpenXmlElement<DXV.Shape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Shapetype? GetShapetype(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shapetype>();
    if (element != null)
      return DMXV.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXW.Picture openXmlElement, DMV.Shapetype? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shapetype>(), value, diffs, objName, propName);
  }
  
  private static void SetShapetype(DXW.Picture openXmlElement, DMV.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapetypeConverter.CreateOpenXmlElement<DXV.Shapetype>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Arc? GetArc(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Arc>();
    if (element != null)
      return DMXV.ArcConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArc(DXW.Picture openXmlElement, DMV.Arc? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ArcConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Arc>(), value, diffs, objName, propName);
  }
  
  private static void SetArc(DXW.Picture openXmlElement, DMV.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ArcConverter.CreateOpenXmlElement<DXV.Arc>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Curve? GetCurve(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Curve>();
    if (element != null)
      return DMXV.CurveConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCurve(DXW.Picture openXmlElement, DMV.Curve? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.CurveConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Curve>(), value, diffs, objName, propName);
  }
  
  private static void SetCurve(DXW.Picture openXmlElement, DMV.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CurveConverter.CreateOpenXmlElement<DXV.Curve>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.OleObject? GetOleObject(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.OleObject>();
    if (element != null)
      return DMXV.OleObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOleObject(DXW.Picture openXmlElement, DMV.OleObject? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.OleObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.OleObject>(), value, diffs, objName, propName);
  }
  
  private static void SetOleObject(DXW.Picture openXmlElement, DMV.OleObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.OleObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.OleObjectConverter.CreateOpenXmlElement<DXVO.OleObject>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetMovieReference(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MovieReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMovieReference(DXW.Picture openXmlElement, DMW.RelationshipType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MovieReference>(), value, diffs, objName, propName);
  }
  
  private static void SetMovieReference(DXW.Picture openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MovieReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.MovieReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.Control? GetControl(DXW.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Control>();
    if (element != null)
      return DMXW.ControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControl(DXW.Picture openXmlElement, DMW.Control? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Control>(), value, diffs, objName, propName);
  }
  
  private static void SetControl(DXW.Picture openXmlElement, DMW.Control? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Control>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ControlConverter.CreateOpenXmlElement<DXW.Control>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.Picture? CreateModelElement(DXW.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Picture();
      value.AnchorId = GetAnchorId(openXmlElement);
      value.Group = GetGroup(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      value.Arc = GetArc(openXmlElement);
      value.Curve = GetCurve(openXmlElement);
      value.OleObject = GetOleObject(openXmlElement);
      value.MovieReference = GetMovieReference(openXmlElement);
      value.Control = GetControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Picture? openXmlElement, DMW.Picture? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAnchorId(openXmlElement, value.AnchorId, diffs, objName, propName))
        ok = false;
      if (!CmpGroup(openXmlElement, value.Group, diffs, objName, propName))
        ok = false;
      if (!CmpImageFile(openXmlElement, value.ImageFile, diffs, objName, propName))
        ok = false;
      if (!CmpLine(openXmlElement, value.Line, diffs, objName, propName))
        ok = false;
      if (!CmpOval(openXmlElement, value.Oval, diffs, objName, propName))
        ok = false;
      if (!CmpPolyLine(openXmlElement, value.PolyLine, diffs, objName, propName))
        ok = false;
      if (!CmpRectangle(openXmlElement, value.Rectangle, diffs, objName, propName))
        ok = false;
      if (!CmpRoundRectangle(openXmlElement, value.RoundRectangle, diffs, objName, propName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName, propName))
        ok = false;
      if (!CmpShapetype(openXmlElement, value.Shapetype, diffs, objName, propName))
        ok = false;
      if (!CmpArc(openXmlElement, value.Arc, diffs, objName, propName))
        ok = false;
      if (!CmpCurve(openXmlElement, value.Curve, diffs, objName, propName))
        ok = false;
      if (!CmpOleObject(openXmlElement, value.OleObject, diffs, objName, propName))
        ok = false;
      if (!CmpMovieReference(openXmlElement, value.MovieReference, diffs, objName, propName))
        ok = false;
      if (!CmpControl(openXmlElement, value.Control, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.Picture CreateOpenXmlElement(DMW.Picture value)
  {
    var openXmlElement = new DXW.Picture();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.Picture openXmlElement, DMW.Picture value)
  {
    SetAnchorId(openXmlElement, value?.AnchorId);
    SetGroup(openXmlElement, value?.Group);
    SetImageFile(openXmlElement, value?.ImageFile);
    SetLine(openXmlElement, value?.Line);
    SetOval(openXmlElement, value?.Oval);
    SetPolyLine(openXmlElement, value?.PolyLine);
    SetRectangle(openXmlElement, value?.Rectangle);
    SetRoundRectangle(openXmlElement, value?.RoundRectangle);
    SetShape(openXmlElement, value?.Shape);
    SetShapetype(openXmlElement, value?.Shapetype);
    SetArc(openXmlElement, value?.Arc);
    SetCurve(openXmlElement, value?.Curve);
    SetOleObject(openXmlElement, value?.OleObject);
    SetMovieReference(openXmlElement, value?.MovieReference);
    SetControl(openXmlElement, value?.Control);
    return true;
  }
}
