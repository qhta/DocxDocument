using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Vml;
using DocumentModel.Vml;
using Control = DocumentModel.Wordprocessing.Control;
using Drawing = DocumentModel.Wordprocessing.Drawing;
using ObjectEmbed = DocumentModel.Wordprocessing.ObjectEmbed;
using ObjectLink = DocumentModel.Wordprocessing.ObjectLink;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Inline Embedded Object.
/// </summary>
public static class EmbeddedObjectConverter
{
  /// <summary>
  ///   dxaOrig
  /// </summary>
  public static String? GetDxaOriginal(EmbeddedObject? openXmlElement)
  {
    return openXmlElement?.DxaOriginal?.Value;
  }

  public static void SetDxaOriginal(EmbeddedObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DxaOriginal = new StringValue { Value = value };
      else
        openXmlElement.DxaOriginal = null;
  }

  /// <summary>
  ///   dyaOrig
  /// </summary>
  public static String? GetDyaOriginal(EmbeddedObject? openXmlElement)
  {
    return openXmlElement?.DyaOriginal?.Value;
  }

  public static void SetDyaOriginal(EmbeddedObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DyaOriginal = new StringValue { Value = value };
      else
        openXmlElement.DyaOriginal = null;
  }

  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(EmbeddedObject? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }

  public static void SetAnchorId(EmbeddedObject? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AnchorId = Convert.ToHexString(value);
      else
        openXmlElement.AnchorId = null;
    }
  }

  public static DocumentModel.Vml.Group? GetGroup(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroup(EmbeddedObject? openXmlElement, DocumentModel.Vml.Group? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXml.Vml.GroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Group>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ImageFile? GetImageFile(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageFile(EmbeddedObject? openXmlElement, ImageFile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageFileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageFile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Line? GetLine(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return LineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLine(EmbeddedObject? openXmlElement, Line? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Line>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Oval? GetOval(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return OvalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOval(EmbeddedObject? openXmlElement, Oval? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OvalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Oval>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PolyLine? GetPolyLine(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPolyLine(EmbeddedObject? openXmlElement, PolyLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PolyLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.PolyLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Rectangle? GetRectangle(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return RectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRectangle(EmbeddedObject? openXmlElement, Rectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Rectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RoundRectangle? GetRoundRectangle(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRoundRectangle(EmbeddedObject? openXmlElement, RoundRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RoundRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.RoundRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shape? GetShape(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(EmbeddedObject? openXmlElement, Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shapetype? GetShapetype(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapetype(EmbeddedObject? openXmlElement, Shapetype? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapetypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shapetype>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Arc? GetArc(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return ArcConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArc(EmbeddedObject? openXmlElement, Arc? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArcConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Arc>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Curve? GetCurve(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return CurveConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCurve(EmbeddedObject? openXmlElement, Curve? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CurveConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Curve>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OleObject? GetOleObject(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
    if (itemElement != null)
      return OleObjectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOleObject(EmbeddedObject? openXmlElement, OleObject? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OleObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.OleObject>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Drawing? GetDrawing(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DrawingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDrawing(EmbeddedObject? openXmlElement, Drawing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Control? GetControl(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
    if (itemElement != null)
      return ControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControl(EmbeddedObject? openXmlElement, Control? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Control>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ObjectEmbed? GetObjectEmbed(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>();
    if (itemElement != null)
      return ObjectEmbedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetObjectEmbed(EmbeddedObject? openXmlElement, ObjectEmbed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectEmbedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ObjectLink? GetObjectLink(EmbeddedObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>();
    if (itemElement != null)
      return ObjectLinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetObjectLink(EmbeddedObject? openXmlElement, ObjectLink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectLinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.EmbeddedObject? CreateModelElement(EmbeddedObject? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EmbeddedObject? value)
    where OpenXmlElementType : EmbeddedObject, new()
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