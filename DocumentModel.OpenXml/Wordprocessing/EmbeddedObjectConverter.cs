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
    return openXmlElement?.DxaOriginal?.Value;
  }
  
  private static void SetDxaOriginal(DXW.EmbeddedObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DxaOriginal = new StringValue { Value = value };
    else
      openXmlElement.DxaOriginal = null;
  }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  private static String? GetDyaOriginal(DXW.EmbeddedObject openXmlElement)
  {
    return openXmlElement?.DyaOriginal?.Value;
  }
  
  private static void SetDyaOriginal(DXW.EmbeddedObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DyaOriginal = new StringValue { Value = value };
    else
      openXmlElement.DyaOriginal = null;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DXW.EmbeddedObject openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAnchorId(DXW.EmbeddedObject openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  private static DMVml.Group? GetGroup(DXW.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Group>();
    if (itemElement != null)
      return DMXVml.GroupConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ImageFile>();
    if (itemElement != null)
      return DMXVml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Line>();
    if (itemElement != null)
      return DMXVml.LineConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Oval>();
    if (itemElement != null)
      return DMXVml.OvalConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.PolyLine>();
    if (itemElement != null)
      return DMXVml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Rectangle>();
    if (itemElement != null)
      return DMXVml.RectangleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.RoundRectangle>();
    if (itemElement != null)
      return DMXVml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shape>();
    if (itemElement != null)
      return DMXVml.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shapetype>();
    if (itemElement != null)
      return DMXVml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Arc>();
    if (itemElement != null)
      return DMXVml.ArcConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Curve>();
    if (itemElement != null)
      return DMXVml.CurveConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.OleObject>();
    if (itemElement != null)
      return DMXVml.OleObjectConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      return DMXW.DrawingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Control>();
    if (itemElement != null)
      return DMXW.ControlConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ObjectEmbed>();
    if (itemElement != null)
      return DMXW.ObjectEmbedConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ObjectLink>();
    if (itemElement != null)
      return DMXW.ObjectLinkConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.EmbeddedObject? value)
    where OpenXmlElementType: DXW.EmbeddedObject, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
