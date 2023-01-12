namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Path Width
  /// </summary>
  public static Int64? GetWidth(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public static Int64? GetHeight(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public static DocumentModel.Drawings.PathFillMode? GetFill(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DocumentModel.Drawings.PathFillMode>(openXmlElement?.Fill?.Value);
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.PathFillMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Fill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DocumentModel.Drawings.PathFillMode>(value);
  }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public static Boolean? GetStroke(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    return openXmlElement?.Stroke?.Value;
  }
  
  public static void SetStroke(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Stroke = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Stroke = null;
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public static Boolean? GetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    return openXmlElement?.ExtrusionOk?.Value;
  }
  
  public static void SetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ExtrusionOk = null;
  }
  
  public static Boolean? GetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CloseShapePath>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.MoveTo? GetMoveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MoveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.MoveTo? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.LineTo? GetLineTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.LineTo? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ArcTo? GetArcTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArcToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArcTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.ArcTo? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.QuadraticBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.QuadraticBezierCurveTo? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.CubicBezierCurveTo? GetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CubicBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.CubicBezierCurveTo? value)
  {
    if (openXmlElement != null)
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
      return openXmlElement;
    }
    return default;
  }
}
