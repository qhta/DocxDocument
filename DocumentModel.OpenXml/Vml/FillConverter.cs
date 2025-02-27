namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DMV.FillTypeKind? GetType(DXV.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXV.Fill openXmlElement, DMV.FillTypeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXV.Fill openXmlElement, DMV.FillTypeKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(value);
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  private static Boolean? GetOn(DXV.Fill openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXV.Fill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXV.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  private static String? GetColor(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  private static String? GetOpacity(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  private static String? GetColor2(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  private static String? GetSource(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Source);
  }
  
  private static bool CmpSource(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Source, value, diffs, objName, "Source");
  }
  
  private static void SetSource(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Source = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  private static String? GetAlternateImageReference(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternateImageReference);
  }
  
  private static bool CmpAlternateImageReference(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternateImageReference, value, diffs, objName, "AlternateImageReference");
  }
  
  private static void SetAlternateImageReference(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  private static String? GetSize(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Size);
  }
  
  private static bool CmpSize(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Size, value, diffs, objName, "Value");
  }
  
  private static void SetSize(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Size = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  private static String? GetOrigin(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Origin);
  }
  
  private static bool CmpOrigin(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Origin, value, diffs, objName, "Origin");
  }
  
  private static void SetOrigin(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Origin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  private static String? GetPosition(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Position);
  }
  
  private static bool CmpPosition(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Position, value, diffs, objName, "Position");
  }
  
  private static void SetPosition(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Position = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  private static DMV.ImageAspectKind? GetAspect(DXV.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }
  
  private static bool CmpAspect(DXV.Fill openXmlElement, DMV.ImageAspectKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.Aspect?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAspect(DXV.Fill openXmlElement, DMV.ImageAspectKind? value)
  {
    openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  private static String? GetColors(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Colors);
  }
  
  private static bool CmpColors(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Colors, value, diffs, objName, "Colors");
  }
  
  private static void SetColors(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Colors = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  private static Decimal? GetAngle(DXV.Fill openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  private static bool CmpAngle(DXV.Fill openXmlElement, Decimal? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Angle?.Value == value) return true;
    diffs?.Add(objName, "Angle", openXmlElement?.Angle?.Value, value);
    return false;
  }
  
  private static void SetAngle(DXV.Fill openXmlElement, Decimal? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  private static Boolean? GetAlignShape(DXV.Fill openXmlElement)
  {
    return openXmlElement?.AlignShape?.Value;
  }
  
  private static bool CmpAlignShape(DXV.Fill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AlignShape?.Value == value) return true;
    diffs?.Add(objName, "AlignShape", openXmlElement?.AlignShape?.Value, value);
    return false;
  }
  
  private static void SetAlignShape(DXV.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignShape = value;
    else
      openXmlElement.AlignShape = null;
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  private static String? GetFocus(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Focus);
  }
  
  private static bool CmpFocus(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Focus, value, diffs, objName, "Focus");
  }
  
  private static void SetFocus(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Focus = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  private static String? GetFocusSize(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FocusSize);
  }
  
  private static bool CmpFocusSize(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FocusSize, value, diffs, objName, "FocusSize");
  }
  
  private static void SetFocusSize(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.FocusSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  private static String? GetFocusPosition(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FocusPosition);
  }
  
  private static bool CmpFocusPosition(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FocusPosition, value, diffs, objName, "FocusPosition");
  }
  
  private static void SetFocusPosition(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.FocusPosition = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  private static DMV.FillMethodKind? GetMethod(DXV.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMV.FillMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static bool CmpMethod(DXV.Fill openXmlElement, DMV.FillMethodKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMV.FillMethodKind>(openXmlElement?.Method?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMethod(DXV.Fill openXmlElement, DMV.FillMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMV.FillMethodKind>(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  private static Boolean? GetDetectMouseClick(DXV.Fill openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }
  
  private static bool CmpDetectMouseClick(DXV.Fill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DetectMouseClick?.Value == value) return true;
    diffs?.Add(objName, "DetectMouseClick", openXmlElement?.DetectMouseClick?.Value, value);
    return false;
  }
  
  private static void SetDetectMouseClick(DXV.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DetectMouseClick = value;
    else
      openXmlElement.DetectMouseClick = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  private static String? GetOpacity2(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity2);
  }
  
  private static bool CmpOpacity2(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity2, value, diffs, objName, "Opacity2");
  }
  
  private static void SetOpacity2(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.Opacity2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  private static Boolean? GetRecolor(DXV.Fill openXmlElement)
  {
    return openXmlElement?.Recolor?.Value;
  }
  
  private static bool CmpRecolor(DXV.Fill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Recolor?.Value == value) return true;
    diffs?.Add(objName, "Recolor", openXmlElement?.Recolor?.Value, value);
    return false;
  }
  
  private static void SetRecolor(DXV.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Recolor = value;
    else
      openXmlElement.Recolor = null;
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  private static Boolean? GetRotate(DXV.Fill openXmlElement)
  {
    return openXmlElement?.Rotate?.Value;
  }
  
  private static bool CmpRotate(DXV.Fill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Rotate?.Value == value) return true;
    diffs?.Add(objName, "Rotate", openXmlElement?.Rotate?.Value, value);
    return false;
  }
  
  private static void SetRotate(DXV.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotate = value;
    else
      openXmlElement.Rotate = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetRelationshipId(DXV.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXV.Fill openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXV.Fill openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  private static DMV.FillExtendedProperties? GetFillExtendedProperties(DXV.Fill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.FillExtendedProperties>();
    if (element != null)
      return DMXV.FillExtendedPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillExtendedProperties(DXV.Fill openXmlElement, DMV.FillExtendedProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.FillExtendedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.FillExtendedProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetFillExtendedProperties(DXV.Fill openXmlElement, DMV.FillExtendedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.FillExtendedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FillExtendedPropertiesConverter.CreateOpenXmlElement<DXVO.FillExtendedProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Fill? CreateModelElement(DXV.Fill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Fill();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
      value.Source = GetSource(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.AlternateImageReference = GetAlternateImageReference(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.Aspect = GetAspect(openXmlElement);
      value.Colors = GetColors(openXmlElement);
      value.Angle = GetAngle(openXmlElement);
      value.AlignShape = GetAlignShape(openXmlElement);
      value.Focus = GetFocus(openXmlElement);
      value.FocusSize = GetFocusSize(openXmlElement);
      value.FocusPosition = GetFocusPosition(openXmlElement);
      value.Method = GetMethod(openXmlElement);
      value.DetectMouseClick = GetDetectMouseClick(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.Opacity2 = GetOpacity2(openXmlElement);
      value.Recolor = GetRecolor(openXmlElement);
      value.Rotate = GetRotate(openXmlElement);
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.FillExtendedProperties = GetFillExtendedProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Fill? openXmlElement, DMV.Fill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName, propName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName, propName))
        ok = false;
      if (!CmpOpacity(openXmlElement, value.Opacity, diffs, objName, propName))
        ok = false;
      if (!CmpColor2(openXmlElement, value.Color2, diffs, objName, propName))
        ok = false;
      if (!CmpSource(openXmlElement, value.Source, diffs, objName, propName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName, propName))
        ok = false;
      if (!CmpAlternateImageReference(openXmlElement, value.AlternateImageReference, diffs, objName, propName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName, propName))
        ok = false;
      if (!CmpOrigin(openXmlElement, value.Origin, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      if (!CmpAspect(openXmlElement, value.Aspect, diffs, objName, propName))
        ok = false;
      if (!CmpColors(openXmlElement, value.Colors, diffs, objName, propName))
        ok = false;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName, propName))
        ok = false;
      if (!CmpAlignShape(openXmlElement, value.AlignShape, diffs, objName, propName))
        ok = false;
      if (!CmpFocus(openXmlElement, value.Focus, diffs, objName, propName))
        ok = false;
      if (!CmpFocusSize(openXmlElement, value.FocusSize, diffs, objName, propName))
        ok = false;
      if (!CmpFocusPosition(openXmlElement, value.FocusPosition, diffs, objName, propName))
        ok = false;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName, propName))
        ok = false;
      if (!CmpDetectMouseClick(openXmlElement, value.DetectMouseClick, diffs, objName, propName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName, propName))
        ok = false;
      if (!CmpOpacity2(openXmlElement, value.Opacity2, diffs, objName, propName))
        ok = false;
      if (!CmpRecolor(openXmlElement, value.Recolor, diffs, objName, propName))
        ok = false;
      if (!CmpRotate(openXmlElement, value.Rotate, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName, propName))
        ok = false;
      if (!CmpFillExtendedProperties(openXmlElement, value.FillExtendedProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Fill value)
    where OpenXmlElementType: DXV.Fill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Fill openXmlElement, DMV.Fill value)
  {
    SetId(openXmlElement, value.Id);
    SetType(openXmlElement, value.Type);
    SetOn(openXmlElement, value.On);
    SetColor(openXmlElement, value.Color);
    SetOpacity(openXmlElement, value.Opacity);
    SetColor2(openXmlElement, value.Color2);
    SetSource(openXmlElement, value.Source);
    SetHref(openXmlElement, value.Href);
    SetAlternateImageReference(openXmlElement, value.AlternateImageReference);
    SetSize(openXmlElement, value.Size);
    SetOrigin(openXmlElement, value.Origin);
    SetPosition(openXmlElement, value.Position);
    SetAspect(openXmlElement, value.Aspect);
    SetColors(openXmlElement, value.Colors);
    SetAngle(openXmlElement, value.Angle);
    SetAlignShape(openXmlElement, value.AlignShape);
    SetFocus(openXmlElement, value.Focus);
    SetFocusSize(openXmlElement, value.FocusSize);
    SetFocusPosition(openXmlElement, value.FocusPosition);
    SetMethod(openXmlElement, value.Method);
    SetDetectMouseClick(openXmlElement, value.DetectMouseClick);
    SetTitle(openXmlElement, value.Title);
    SetOpacity2(openXmlElement, value.Opacity2);
    SetRecolor(openXmlElement, value.Recolor);
    SetRotate(openXmlElement, value.Rotate);
    SetRelationshipId(openXmlElement, value.RelationshipId);
    SetFillExtendedProperties(openXmlElement, value.FillExtendedProperties);
  }
}
