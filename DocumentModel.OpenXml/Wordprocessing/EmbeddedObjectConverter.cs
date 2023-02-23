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
  
  private static DMVml.Group? GetGroup(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Group>();
    if (element != null)
      return DMXVml.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroup(DXW.EmbeddedObject openXmlElement, DMVml.Group? value, DiffList? diffs, string? objName)
  {
    return DMXVml.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Group>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroup(DXW.EmbeddedObject openXmlElement, DMVml.Group? value)
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
  
  private static DMVml.ImageFile? GetImageFile(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.ImageFile>();
    if (element != null)
      return DMXVml.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXW.EmbeddedObject openXmlElement, DMVml.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageFile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageFile(DXW.EmbeddedObject openXmlElement, DMVml.ImageFile? value)
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
  
  private static DMVml.Line? GetLine(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Line>();
    if (element != null)
      return DMXVml.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXW.EmbeddedObject openXmlElement, DMVml.Line? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Line>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLine(DXW.EmbeddedObject openXmlElement, DMVml.Line? value)
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
  
  private static DMVml.Oval? GetOval(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Oval>();
    if (element != null)
      return DMXVml.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXW.EmbeddedObject openXmlElement, DMVml.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXVml.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Oval>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOval(DXW.EmbeddedObject openXmlElement, DMVml.Oval? value)
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
  
  private static DMVml.PolyLine? GetPolyLine(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.PolyLine>();
    if (element != null)
      return DMXVml.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXW.EmbeddedObject openXmlElement, DMVml.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.PolyLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPolyLine(DXW.EmbeddedObject openXmlElement, DMVml.PolyLine? value)
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
  
  private static DMVml.Rectangle? GetRectangle(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Rectangle>();
    if (element != null)
      return DMXVml.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXW.EmbeddedObject openXmlElement, DMVml.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Rectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRectangle(DXW.EmbeddedObject openXmlElement, DMVml.Rectangle? value)
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
  
  private static DMVml.RoundRectangle? GetRoundRectangle(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.RoundRectangle>();
    if (element != null)
      return DMXVml.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXW.EmbeddedObject openXmlElement, DMVml.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.RoundRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRoundRectangle(DXW.EmbeddedObject openXmlElement, DMVml.RoundRectangle? value)
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
  
  private static DMVml.Shape? GetShape(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Shape>();
    if (element != null)
      return DMXVml.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXW.EmbeddedObject openXmlElement, DMVml.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXW.EmbeddedObject openXmlElement, DMVml.Shape? value)
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
  
  private static DMVml.Shapetype? GetShapetype(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Shapetype>();
    if (element != null)
      return DMXVml.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXW.EmbeddedObject openXmlElement, DMVml.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shapetype>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapetype(DXW.EmbeddedObject openXmlElement, DMVml.Shapetype? value)
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
  
  private static DMVml.Arc? GetArc(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Arc>();
    if (element != null)
      return DMXVml.ArcConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArc(DXW.EmbeddedObject openXmlElement, DMVml.Arc? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ArcConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Arc>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetArc(DXW.EmbeddedObject openXmlElement, DMVml.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ArcConverter.CreateOpenXmlElement<DXVml.Arc>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Curve? GetCurve(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Curve>();
    if (element != null)
      return DMXVml.CurveConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCurve(DXW.EmbeddedObject openXmlElement, DMVml.Curve? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CurveConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Curve>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCurve(DXW.EmbeddedObject openXmlElement, DMVml.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.CurveConverter.CreateOpenXmlElement<DXVml.Curve>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.OleObject? GetOleObject(DXW.EmbeddedObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.OleObject>();
    if (element != null)
      return DMXVml.OleObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOleObject(DXW.EmbeddedObject openXmlElement, DMVml.OleObject? value, DiffList? diffs, string? objName)
  {
    return DMXVml.OleObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.OleObject>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOleObject(DXW.EmbeddedObject openXmlElement, DMVml.OleObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.OleObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.OleObjectConverter.CreateOpenXmlElement<DXVmlO.OleObject>(value);
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
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Drawing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDrawing(DXW.EmbeddedObject openXmlElement, DMW.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DrawingConverter.CreateOpenXmlElement<DXW.Drawing>(value);
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
    return DMXW.ControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Control>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.ObjectEmbedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ObjectEmbed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.ObjectLinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ObjectLink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.EmbeddedObject? CreateModelElement(DXW.EmbeddedObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EmbeddedObject();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.EmbeddedObject value)
    where OpenXmlElementType: DXW.EmbeddedObject, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.EmbeddedObject openXmlElement, DMW.EmbeddedObject value)
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
  }
}
