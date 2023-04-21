namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  private static String? GetValue(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Value);
  }
  
  private static bool CmpValue(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Value, value, diffs, objName, "Type");
  }
  
  private static void SetValue(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.Value = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  private static String? GetLimo(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Limo);
  }
  
  private static bool CmpLimo(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Limo, value, diffs, objName, "Limo");
  }
  
  private static void SetLimo(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.Limo = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  private static String? GetTextboxRectangle(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TextboxRectangle);
  }
  
  private static bool CmpTextboxRectangle(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TextboxRectangle, value, diffs, objName, "TextboxRectangle");
  }
  
  private static void SetTextboxRectangle(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.TextboxRectangle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetAllowFill(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowFill?.Value;
  }
  
  private static bool CmpAllowFill(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowFill?.Value == value) return true;
    diffs?.Add(objName, "AllowFill", openXmlElement?.AllowFill?.Value, value);
    return false;
  }
  
  private static void SetAllowFill(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowFill = value;
    else
      openXmlElement.AllowFill = null;
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetAllowStroke(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowStroke?.Value;
  }
  
  private static bool CmpAllowStroke(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowStroke?.Value == value) return true;
    diffs?.Add(objName, "AllowStroke", openXmlElement?.AllowStroke?.Value, value);
    return false;
  }
  
  private static void SetAllowStroke(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowStroke = value;
    else
      openXmlElement.AllowStroke = null;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  private static Boolean? GetAllowShading(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowShading?.Value;
  }
  
  private static bool CmpAllowShading(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowShading?.Value == value) return true;
    diffs?.Add(objName, "AllowShading", openXmlElement?.AllowShading?.Value, value);
    return false;
  }
  
  private static void SetAllowShading(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowShading = value;
    else
      openXmlElement.AllowShading = null;
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  private static Boolean? GetShowArrowhead(DXV.Path openXmlElement)
  {
    return openXmlElement?.ShowArrowhead?.Value;
  }
  
  private static bool CmpShowArrowhead(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowArrowhead?.Value == value) return true;
    diffs?.Add(objName, "ShowArrowhead", openXmlElement?.ShowArrowhead?.Value, value);
    return false;
  }
  
  private static void SetShowArrowhead(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowArrowhead = value;
    else
      openXmlElement.ShowArrowhead = null;
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  private static Boolean? GetAllowGradientShape(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowGradientShape?.Value;
  }
  
  private static bool CmpAllowGradientShape(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowGradientShape?.Value == value) return true;
    diffs?.Add(objName, "AllowGradientShape", openXmlElement?.AllowGradientShape?.Value, value);
    return false;
  }
  
  private static void SetAllowGradientShape(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowGradientShape = value;
    else
      openXmlElement.AllowGradientShape = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetAllowTextPath(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowTextPath?.Value;
  }
  
  private static bool CmpAllowTextPath(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowTextPath?.Value == value) return true;
    diffs?.Add(objName, "AllowTextPath", openXmlElement?.AllowTextPath?.Value, value);
    return false;
  }
  
  private static void SetAllowTextPath(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowTextPath = value;
    else
      openXmlElement.AllowTextPath = null;
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  private static Boolean? GetAllowInsetPen(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowInsetPen?.Value;
  }
  
  private static bool CmpAllowInsetPen(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInsetPen?.Value == value) return true;
    diffs?.Add(objName, "AllowInsetPen", openXmlElement?.AllowInsetPen?.Value, value);
    return false;
  }
  
  private static void SetAllowInsetPen(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInsetPen = value;
    else
      openXmlElement.AllowInsetPen = null;
  }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  private static DMV.ConnectKind? GetConnectionPointType(DXV.Path openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DMV.ConnectKind>(openXmlElement?.ConnectionPointType?.Value);
  }
  
  private static bool CmpConnectionPointType(DXV.Path openXmlElement, DMV.ConnectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DMV.ConnectKind>(openXmlElement?.ConnectionPointType?.Value, value, diffs, objName);
  }
  
  private static void SetConnectionPointType(DXV.Path openXmlElement, DMV.ConnectKind? value)
  {
    openXmlElement.ConnectionPointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DMV.ConnectKind>(value);
  }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  private static String? GetConnectionPoints(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ConnectionPoints);
  }
  
  private static bool CmpConnectionPoints(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ConnectionPoints, value, diffs, objName, "ConnectionPoints");
  }
  
  private static void SetConnectionPoints(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.ConnectionPoints = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  private static String? GetConnectAngles(DXV.Path openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ConnectAngles);
  }
  
  private static bool CmpConnectAngles(DXV.Path openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ConnectAngles, value, diffs, objName, "ConnectAngles");
  }
  
  private static void SetConnectAngles(DXV.Path openXmlElement, String? value)
  {
    openXmlElement.ConnectAngles = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  private static Boolean? GetAllowExtrusion(DXV.Path openXmlElement)
  {
    return openXmlElement?.AllowExtrusion?.Value;
  }
  
  private static bool CmpAllowExtrusion(DXV.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowExtrusion?.Value == value) return true;
    diffs?.Add(objName, "AllowExtrusion", openXmlElement?.AllowExtrusion?.Value, value);
    return false;
  }
  
  private static void SetAllowExtrusion(DXV.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowExtrusion = value;
    else
      openXmlElement.AllowExtrusion = null;
  }
  
  public static DocumentModel.Vml.Path? CreateModelElement(DXV.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Path();
      value.Id = GetId(openXmlElement);
      value.Value = GetValue(openXmlElement);
      value.Limo = GetLimo(openXmlElement);
      value.TextboxRectangle = GetTextboxRectangle(openXmlElement);
      value.AllowFill = GetAllowFill(openXmlElement);
      value.AllowStroke = GetAllowStroke(openXmlElement);
      value.AllowShading = GetAllowShading(openXmlElement);
      value.ShowArrowhead = GetShowArrowhead(openXmlElement);
      value.AllowGradientShape = GetAllowGradientShape(openXmlElement);
      value.AllowTextPath = GetAllowTextPath(openXmlElement);
      value.AllowInsetPen = GetAllowInsetPen(openXmlElement);
      value.ConnectionPointType = GetConnectionPointType(openXmlElement);
      value.ConnectionPoints = GetConnectionPoints(openXmlElement);
      value.ConnectAngles = GetConnectAngles(openXmlElement);
      value.AllowExtrusion = GetAllowExtrusion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Path? openXmlElement, DMV.Path? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      if (!CmpLimo(openXmlElement, value.Limo, diffs, objName))
        ok = false;
      if (!CmpTextboxRectangle(openXmlElement, value.TextboxRectangle, diffs, objName))
        ok = false;
      if (!CmpAllowFill(openXmlElement, value.AllowFill, diffs, objName))
        ok = false;
      if (!CmpAllowStroke(openXmlElement, value.AllowStroke, diffs, objName))
        ok = false;
      if (!CmpAllowShading(openXmlElement, value.AllowShading, diffs, objName))
        ok = false;
      if (!CmpShowArrowhead(openXmlElement, value.ShowArrowhead, diffs, objName))
        ok = false;
      if (!CmpAllowGradientShape(openXmlElement, value.AllowGradientShape, diffs, objName))
        ok = false;
      if (!CmpAllowTextPath(openXmlElement, value.AllowTextPath, diffs, objName))
        ok = false;
      if (!CmpAllowInsetPen(openXmlElement, value.AllowInsetPen, diffs, objName))
        ok = false;
      if (!CmpConnectionPointType(openXmlElement, value.ConnectionPointType, diffs, objName))
        ok = false;
      if (!CmpConnectionPoints(openXmlElement, value.ConnectionPoints, diffs, objName))
        ok = false;
      if (!CmpConnectAngles(openXmlElement, value.ConnectAngles, diffs, objName))
        ok = false;
      if (!CmpAllowExtrusion(openXmlElement, value.AllowExtrusion, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Path value)
    where OpenXmlElementType: DXV.Path, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Path openXmlElement, DMV.Path value)
  {
    SetId(openXmlElement, value?.Id);
    SetValue(openXmlElement, value?.Value);
    SetLimo(openXmlElement, value?.Limo);
    SetTextboxRectangle(openXmlElement, value?.TextboxRectangle);
    SetAllowFill(openXmlElement, value?.AllowFill);
    SetAllowStroke(openXmlElement, value?.AllowStroke);
    SetAllowShading(openXmlElement, value?.AllowShading);
    SetShowArrowhead(openXmlElement, value?.ShowArrowhead);
    SetAllowGradientShape(openXmlElement, value?.AllowGradientShape);
    SetAllowTextPath(openXmlElement, value?.AllowTextPath);
    SetAllowInsetPen(openXmlElement, value?.AllowInsetPen);
    SetConnectionPointType(openXmlElement, value?.ConnectionPointType);
    SetConnectionPoints(openXmlElement, value?.ConnectionPoints);
    SetConnectAngles(openXmlElement, value?.ConnectAngles);
    SetAllowExtrusion(openXmlElement, value?.AllowExtrusion);
  }
}
