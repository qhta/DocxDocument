using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using ArcTo = DocumentModel.Drawings.ArcTo;
using CubicBezierCurveTo = DocumentModel.Drawings.CubicBezierCurveTo;
using LineTo = DocumentModel.Drawings.LineTo;
using MoveTo = DocumentModel.Drawings.MoveTo;
using Path = DocumentFormat.OpenXml.Drawing.Path;
using QuadraticBezierCurveTo = DocumentModel.Drawings.QuadraticBezierCurveTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Shape Path.
/// </summary>
public static class PathConverter
{
  /// <summary>
  ///   Path Width
  /// </summary>
  public static Int64? GetWidth(Path? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(Path? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   Path Height
  /// </summary>
  public static Int64? GetHeight(Path? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(Path? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   Path Fill
  /// </summary>
  public static PathFillMode? GetFill(Path? openXmlElement)
  {
    return EnumValueConverter.GetValue<PathFillModeValues, PathFillMode>(openXmlElement?.Fill?.Value);
  }

  public static void SetFill(Path? openXmlElement, PathFillMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fill = EnumValueConverter.CreateEnumValue<PathFillModeValues, PathFillMode>(value);
  }

  /// <summary>
  ///   Path Stroke
  /// </summary>
  public static Boolean? GetStroke(Path? openXmlElement)
  {
    return openXmlElement?.Stroke?.Value;
  }

  public static void SetStroke(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Stroke = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Stroke = null;
  }

  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  public static Boolean? GetExtrusionOk(Path? openXmlElement)
  {
    return openXmlElement?.ExtrusionOk?.Value;
  }

  public static void SetExtrusionOk(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ExtrusionOk = null;
  }

  public static Boolean? GetCloseShapePath(Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CloseShapePath>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCloseShapePath(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<CloseShapePath>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new CloseShapePath();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveTo? GetMoveTo(Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
    if (itemElement != null)
      return MoveToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveTo(Path? openXmlElement, MoveTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MoveTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineTo? GetLineTo(Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
    if (itemElement != null)
      return LineToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineTo(Path? openXmlElement, LineTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ArcTo? GetArcTo(Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
    if (itemElement != null)
      return ArcToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArcTo(Path? openXmlElement, ArcTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArcToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ArcTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
    if (itemElement != null)
      return QuadraticBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetQuadraticBezierCurveTo(Path? openXmlElement, QuadraticBezierCurveTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = QuadraticBezierCurveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CubicBezierCurveTo? GetCubicBezierCurveTo(Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
    if (itemElement != null)
      return CubicBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCubicBezierCurveTo(Path? openXmlElement, CubicBezierCurveTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CubicBezierCurveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Path? CreateModelElement(Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Path();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.Stroke = GetStroke(openXmlElement);
      value.ExtrusionOk = GetExtrusionOk(openXmlElement);
      value.CloseShapePath = GetCloseShapePath(openXmlElement);
      value.MoveTo = GetMoveTo(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      value.ArcTo = GetArcTo(openXmlElement);
      value.QuadraticBezierCurveTo = GetQuadraticBezierCurveTo(openXmlElement);
      value.CubicBezierCurveTo = GetCubicBezierCurveTo(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Path? value)
    where OpenXmlElementType : Path, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetFill(openXmlElement, value?.Fill);
      SetStroke(openXmlElement, value?.Stroke);
      SetExtrusionOk(openXmlElement, value?.ExtrusionOk);
      SetCloseShapePath(openXmlElement, value?.CloseShapePath);
      SetMoveTo(openXmlElement, value?.MoveTo);
      SetLineTo(openXmlElement, value?.LineTo);
      SetArcTo(openXmlElement, value?.ArcTo);
      SetQuadraticBezierCurveTo(openXmlElement, value?.QuadraticBezierCurveTo);
      SetCubicBezierCurveTo(openXmlElement, value?.CubicBezierCurveTo);
      return openXmlElement;
    }
    return default;
  }
}