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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public static Int64? GetHeight(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStroke(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public static Boolean? GetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionOk(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCloseShapePath(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.MoveTo? GetMoveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMoveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.MoveTo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LineTo? GetLineTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.LineTo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ArcTo? GetArcTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetArcTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.ArcTo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetQuadraticBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.QuadraticBezierCurveTo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.CubicBezierCurveTo? GetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCubicBezierCurveTo(DocumentFormat.OpenXml.Drawing.Path? openXmlElement, DocumentModel.Drawings.CubicBezierCurveTo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
