using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Vml;
using DocumentModel.Vml;
using Control = DocumentModel.Wordprocessing.Control;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   VML Object.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(Picture? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }

  public static void SetAnchorId(Picture? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AnchorId = Convert.ToHexString(value);
      else
        openXmlElement.AnchorId = null;
    }
  }

  public static DocumentModel.Vml.Group? GetGroup(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroup(Picture? openXmlElement, DocumentModel.Vml.Group? value)
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

  public static ImageFile? GetImageFile(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageFile(Picture? openXmlElement, ImageFile? value)
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

  public static Line? GetLine(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return LineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLine(Picture? openXmlElement, Line? value)
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

  public static Oval? GetOval(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return OvalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOval(Picture? openXmlElement, Oval? value)
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

  public static PolyLine? GetPolyLine(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPolyLine(Picture? openXmlElement, PolyLine? value)
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

  public static Rectangle? GetRectangle(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return RectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRectangle(Picture? openXmlElement, Rectangle? value)
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

  public static RoundRectangle? GetRoundRectangle(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRoundRectangle(Picture? openXmlElement, RoundRectangle? value)
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

  public static Shape? GetShape(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(Picture? openXmlElement, Shape? value)
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

  public static Shapetype? GetShapetype(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapetype(Picture? openXmlElement, Shapetype? value)
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

  public static Arc? GetArc(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return ArcConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArc(Picture? openXmlElement, Arc? value)
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

  public static Curve? GetCurve(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return CurveConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCurve(Picture? openXmlElement, Curve? value)
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

  public static OleObject? GetOleObject(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
    if (itemElement != null)
      return OleObjectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOleObject(Picture? openXmlElement, OleObject? value)
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

  public static RelationshipType? GetMovieReference(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MovieReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMovieReference(Picture? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MovieReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<MovieReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Control? GetControl(Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
    if (itemElement != null)
      return ControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControl(Picture? openXmlElement, Control? value)
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

  public static DocumentModel.Wordprocessing.Picture? CreateModelElement(Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Picture();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Picture? value)
    where OpenXmlElementType : Picture, new()
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