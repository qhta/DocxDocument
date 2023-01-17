namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Path Width
  /// </summary>
  private static Int64? GetWidth(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Drawing.Path openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  private static Int64? GetHeight(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Drawing.Path openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  private static DocumentModel.Drawings.PathFillMode? GetFill(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DocumentModel.Drawings.PathFillMode>(openXmlElement?.Fill?.Value);
  }
  
  private static void SetFill(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.PathFillMode? value)
  {
    openXmlElement.Fill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DocumentModel.Drawings.PathFillMode>(value);
  }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  private static Boolean? GetStroke(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    return openXmlElement?.Stroke?.Value;
  }
  
  private static void SetStroke(DocumentFormat.OpenXml.Drawing.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroke = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Stroke = null;
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  private static Boolean? GetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    return openXmlElement?.ExtrusionOk?.Value;
  }
  
  private static void SetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ExtrusionOk = null;
  }
  
  private static Boolean? GetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CloseShapePath>();
    return itemElement != null;
  }
  
  private static void SetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CloseShapePath>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.CloseShapePath();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.MoveTo? GetMoveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MoveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.MoveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.MoveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MoveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.LineTo? GetLineTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.LineTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ArcTo? GetArcTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArcToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArcTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.ArcTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArcToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ArcTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.QuadraticBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.QuadraticBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.QuadraticBezierCurveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.CubicBezierCurveTo? GetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CubicBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path openXmlElement, DocumentModel.Drawings.CubicBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CubicBezierCurveToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Path? CreateModelElement(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Path, new()
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
