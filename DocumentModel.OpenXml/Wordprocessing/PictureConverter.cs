namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// VML Object.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DXW.Picture openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAnchorId(DXW.Picture openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  private static DMVml.Group? GetGroup(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Group>();
    if (itemElement != null)
      return DMXVml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroup(DXW.Picture openXmlElement, DMVml.Group? value)
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
  
  private static DMVml.ImageFile? GetImageFile(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ImageFile>();
    if (itemElement != null)
      return DMXVml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageFile(DXW.Picture openXmlElement, DMVml.ImageFile? value)
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
  
  private static DMVml.Line? GetLine(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Line>();
    if (itemElement != null)
      return DMXVml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine(DXW.Picture openXmlElement, DMVml.Line? value)
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
  
  private static DMVml.Oval? GetOval(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Oval>();
    if (itemElement != null)
      return DMXVml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOval(DXW.Picture openXmlElement, DMVml.Oval? value)
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
  
  private static DMVml.PolyLine? GetPolyLine(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.PolyLine>();
    if (itemElement != null)
      return DMXVml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPolyLine(DXW.Picture openXmlElement, DMVml.PolyLine? value)
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
  
  private static DMVml.Rectangle? GetRectangle(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Rectangle>();
    if (itemElement != null)
      return DMXVml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRectangle(DXW.Picture openXmlElement, DMVml.Rectangle? value)
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
  
  private static DMVml.RoundRectangle? GetRoundRectangle(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.RoundRectangle>();
    if (itemElement != null)
      return DMXVml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRoundRectangle(DXW.Picture openXmlElement, DMVml.RoundRectangle? value)
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
  
  private static DMVml.Shape? GetShape(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shape>();
    if (itemElement != null)
      return DMXVml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXW.Picture openXmlElement, DMVml.Shape? value)
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
  
  private static DMVml.Shapetype? GetShapetype(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shapetype>();
    if (itemElement != null)
      return DMXVml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapetype(DXW.Picture openXmlElement, DMVml.Shapetype? value)
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
  
  private static DMVml.Arc? GetArc(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Arc>();
    if (itemElement != null)
      return DMXVml.ArcConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArc(DXW.Picture openXmlElement, DMVml.Arc? value)
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
  
  private static DMVml.Curve? GetCurve(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Curve>();
    if (itemElement != null)
      return DMXVml.CurveConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCurve(DXW.Picture openXmlElement, DMVml.Curve? value)
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
  
  private static DMVml.OleObject? GetOleObject(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.OleObject>();
    if (itemElement != null)
      return DMXVml.OleObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOleObject(DXW.Picture openXmlElement, DMVml.OleObject? value)
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
  
  private static DMW.RelationshipType? GetMovieReference(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MovieReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Control? GetControl(DXW.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Control>();
    if (itemElement != null)
      return DMXW.ControlConverter.CreateModelElement(itemElement);
    return null;
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
        openXmlElement.AddChild(itemElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Picture? value)
    where OpenXmlElementType: DXW.Picture, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
