namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public static class EmbeddedObjectConverter
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  private static String? GetDxaOriginal(DXW.EmbeddedObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DxaOriginal);
  }
  
  private static bool CmpDxaOriginal(DXW.EmbeddedObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DxaOriginal, value, diffs, objName, "DxaOriginal");
  }
  
  private static void SetDxaOriginal(DXW.EmbeddedObject openXmlElement, String? value)
  {
    openXmlElement.DxaOriginal = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  private static String? GetDyaOriginal(DXW.EmbeddedObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DyaOriginal);
  }
  
  private static bool CmpDyaOriginal(DXW.EmbeddedObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DyaOriginal, value, diffs, objName, "DyaOriginal");
  }
  
  private static void SetDyaOriginal(DXW.EmbeddedObject openXmlElement, String? value)
  {
    openXmlElement.DyaOriginal = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetAnchorId(DXW.EmbeddedObject openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AnchorId.Value);
    return null;
  }
  
  private static bool CmpAnchorId(DXW.EmbeddedObject openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.AnchorId?.Value, value, diffs, objName, "AnchorId");
  }
  
  private static void SetAnchorId(DXW.EmbeddedObject openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AnchorId = value.ToString();
    else
      openXmlElement.AnchorId = null;
  }
  
  private static DMV.Group? GetGroup(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Group>();
    if (element != null)
      return DMXV.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroup(DXW.EmbeddedObject openXmlElement, DMV.Group? value, DiffList? diffs, string? objName)
  {
    return DMXV.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Group>(), value, diffs, objName);
  }
  
  private static void SetGroup(DXW.EmbeddedObject openXmlElement, DMV.Group? value)
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
  
  private static DMV.ImageFile? GetImageFile(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageFile>();
    if (element != null)
      return DMXV.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXW.EmbeddedObject openXmlElement, DMV.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXV.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageFile>(), value, diffs, objName);
  }
  
  private static void SetImageFile(DXW.EmbeddedObject openXmlElement, DMV.ImageFile? value)
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
  
  private static DMV.Line? GetLine(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Line>();
    if (element != null)
      return DMXV.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXW.EmbeddedObject openXmlElement, DMV.Line? value, DiffList? diffs, string? objName)
  {
    return DMXV.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Line>(), value, diffs, objName);
  }
  
  private static void SetLine(DXW.EmbeddedObject openXmlElement, DMV.Line? value)
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
  
  private static DMV.Oval? GetOval(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Oval>();
    if (element != null)
      return DMXV.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXW.EmbeddedObject openXmlElement, DMV.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXV.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Oval>(), value, diffs, objName);
  }
  
  private static void SetOval(DXW.EmbeddedObject openXmlElement, DMV.Oval? value)
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
  
  private static DMV.PolyLine? GetPolyLine(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.PolyLine>();
    if (element != null)
      return DMXV.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXW.EmbeddedObject openXmlElement, DMV.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXV.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.PolyLine>(), value, diffs, objName);
  }
  
  private static void SetPolyLine(DXW.EmbeddedObject openXmlElement, DMV.PolyLine? value)
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
  
  private static DMV.Rectangle? GetRectangle(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Rectangle>();
    if (element != null)
      return DMXV.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXW.EmbeddedObject openXmlElement, DMV.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Rectangle>(), value, diffs, objName);
  }
  
  private static void SetRectangle(DXW.EmbeddedObject openXmlElement, DMV.Rectangle? value)
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
  
  private static DMV.RoundRectangle? GetRoundRectangle(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.RoundRectangle>();
    if (element != null)
      return DMXV.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXW.EmbeddedObject openXmlElement, DMV.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.RoundRectangle>(), value, diffs, objName);
  }
  
  private static void SetRoundRectangle(DXW.EmbeddedObject openXmlElement, DMV.RoundRectangle? value)
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
  
  private static DMV.Shape? GetShape(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shape>();
    if (element != null)
      return DMXV.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXW.EmbeddedObject openXmlElement, DMV.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXW.EmbeddedObject openXmlElement, DMV.Shape? value)
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
  
  private static DMV.Shapetype? GetShapetype(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shapetype>();
    if (element != null)
      return DMXV.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXW.EmbeddedObject openXmlElement, DMV.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shapetype>(), value, diffs, objName);
  }
  
  private static void SetShapetype(DXW.EmbeddedObject openXmlElement, DMV.Shapetype? value)
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
  
  private static DMV.Arc? GetArc(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Arc>();
    if (element != null)
      return DMXV.ArcConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArc(DXW.EmbeddedObject openXmlElement, DMV.Arc? value, DiffList? diffs, string? objName)
  {
    return DMXV.ArcConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Arc>(), value, diffs, objName);
  }
  
  private static void SetArc(DXW.EmbeddedObject openXmlElement, DMV.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ArcConverter.CreateOpenXmlElement<DXV.Arc>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Curve? GetCurve(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Curve>();
    if (element != null)
      return DMXV.CurveConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCurve(DXW.EmbeddedObject openXmlElement, DMV.Curve? value, DiffList? diffs, string? objName)
  {
    return DMXV.CurveConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Curve>(), value, diffs, objName);
  }
  
  private static void SetCurve(DXW.EmbeddedObject openXmlElement, DMV.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CurveConverter.CreateOpenXmlElement<DXV.Curve>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.OleObject? GetOleObject(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.OleObject>();
    if (element != null)
      return DMXV.OleObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOleObject(DXW.EmbeddedObject openXmlElement, DMV.OleObject? value, DiffList? diffs, string? objName)
  {
    return DMXV.OleObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.OleObject>(), value, diffs, objName);
  }
  
  private static void SetOleObject(DXW.EmbeddedObject openXmlElement, DMV.OleObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.OleObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.OleObjectConverter.CreateOpenXmlElement<DXVO.OleObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Drawing? GetDrawing(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Drawing>();
    if (element != null)
      return DMXW.DrawingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDrawing(DXW.EmbeddedObject openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Drawing>(), value, diffs, objName);
  }
  
  private static void SetDrawing(DXW.EmbeddedObject openXmlElement, DMW.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DrawingConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Control? GetControl(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Control>();
    if (element != null)
      return DMXW.ControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControl(DXW.EmbeddedObject openXmlElement, DMW.Control? value, DiffList? diffs, string? objName)
  {
    return DMXW.ControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Control>(), value, diffs, objName);
  }
  
  private static void SetControl(DXW.EmbeddedObject openXmlElement, DMW.Control? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Control>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ControlConverter.CreateOpenXmlElement<DXW.Control>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ObjectEmbed? GetObjectEmbed(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ObjectEmbed>();
    if (element != null)
      return DMXW.ObjectEmbedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectEmbed(DXW.EmbeddedObject openXmlElement, DMW.ObjectEmbed? value, DiffList? diffs, string? objName)
  {
    return DMXW.ObjectEmbedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ObjectEmbed>(), value, diffs, objName);
  }
  
  private static void SetObjectEmbed(DXW.EmbeddedObject openXmlElement, DMW.ObjectEmbed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ObjectEmbed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ObjectEmbedConverter.CreateOpenXmlElement<DXW.ObjectEmbed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ObjectLink? GetObjectLink(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ObjectLink>();
    if (element != null)
      return DMXW.ObjectLinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectLink(DXW.EmbeddedObject openXmlElement, DMW.ObjectLink? value, DiffList? diffs, string? objName)
  {
    return DMXW.ObjectLinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ObjectLink>(), value, diffs, objName);
  }
  
  private static void SetObjectLink(DXW.EmbeddedObject openXmlElement, DMW.ObjectLink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ObjectLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ObjectLinkConverter.CreateOpenXmlElement<DXW.ObjectLink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.EmbeddedObject? CreateModelElement(DXW.EmbeddedObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.EmbeddedObject();
      value.DxaOriginal = GetDxaOriginal(openXmlElement);
      value.DyaOriginal = GetDyaOriginal(openXmlElement);
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
      value.Drawing = GetDrawing(openXmlElement);
      value.Control = GetControl(openXmlElement);
      value.ObjectEmbed = GetObjectEmbed(openXmlElement);
      value.ObjectLink = GetObjectLink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.EmbeddedObject? openXmlElement, DMW.EmbeddedObject? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDxaOriginal(openXmlElement, value.DxaOriginal, diffs, objName))
        ok = false;
      if (!CmpDyaOriginal(openXmlElement, value.DyaOriginal, diffs, objName))
        ok = false;
      if (!CmpAnchorId(openXmlElement, value.AnchorId, diffs, objName))
        ok = false;
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
      if (!CmpArc(openXmlElement, value.Arc, diffs, objName))
        ok = false;
      if (!CmpCurve(openXmlElement, value.Curve, diffs, objName))
        ok = false;
      if (!CmpOleObject(openXmlElement, value.OleObject, diffs, objName))
        ok = false;
      if (!CmpDrawing(openXmlElement, value.Drawing, diffs, objName))
        ok = false;
      if (!CmpControl(openXmlElement, value.Control, diffs, objName))
        ok = false;
      if (!CmpObjectEmbed(openXmlElement, value.ObjectEmbed, diffs, objName))
        ok = false;
      if (!CmpObjectLink(openXmlElement, value.ObjectLink, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.EmbeddedObject CreateOpenXmlElement(DMW.EmbeddedObject value)
  {
    var openXmlElement = new DXW.EmbeddedObject();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.EmbeddedObject openXmlElement, DMW.EmbeddedObject value)
  {
    SetDxaOriginal(openXmlElement, value?.DxaOriginal);
    SetDyaOriginal(openXmlElement, value?.DyaOriginal);
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
    SetDrawing(openXmlElement, value?.Drawing);
    SetControl(openXmlElement, value?.Control);
    SetObjectEmbed(openXmlElement, value?.ObjectEmbed);
    SetObjectLink(openXmlElement, value?.ObjectLink);
    return true;
  }
}
