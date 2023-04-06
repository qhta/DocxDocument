namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DMVml.FillKind? GetType(DXVml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVml.Fill openXmlElement, DMVml.FillKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVml.Fill openXmlElement, DMVml.FillKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(value);
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVml.Fill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  private static String? GetColor(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  private static String? GetOpacity(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  private static String? GetColor2(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  private static String? GetSource(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Source);
  }
  
  private static bool CmpSource(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Source, value, diffs, objName, "Source");
  }
  
  private static void SetSource(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Source = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  private static String? GetAlternateImageReference(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternateImageReference);
  }
  
  private static bool CmpAlternateImageReference(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternateImageReference, value, diffs, objName, "AlternateImageReference");
  }
  
  private static void SetAlternateImageReference(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  private static String? GetSize(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Size);
  }
  
  private static bool CmpSize(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Size, value, diffs, objName, "Value");
  }
  
  private static void SetSize(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Size = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  private static String? GetOrigin(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Origin);
  }
  
  private static bool CmpOrigin(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Origin, value, diffs, objName, "Origin");
  }
  
  private static void SetOrigin(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Origin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  private static String? GetPosition(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Position);
  }
  
  private static bool CmpPosition(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Position, value, diffs, objName, "Position");
  }
  
  private static void SetPosition(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Position = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  private static DMVml.ImageAspectKind? GetAspect(DXVml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }
  
  private static bool CmpAspect(DXVml.Fill openXmlElement, DMVml.ImageAspectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.Aspect?.Value, value, diffs, objName);
  }
  
  private static void SetAspect(DXVml.Fill openXmlElement, DMVml.ImageAspectKind? value)
  {
    openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  private static String? GetColors(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Colors);
  }
  
  private static bool CmpColors(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Colors, value, diffs, objName, "Colors");
  }
  
  private static void SetColors(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Colors = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  private static Decimal? GetAngle(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  private static bool CmpAngle(DXVml.Fill openXmlElement, Decimal? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Angle?.Value == value) return true;
    diffs?.Add(objName, "Angle", openXmlElement?.Angle?.Value, value);
    return false;
  }
  
  private static void SetAngle(DXVml.Fill openXmlElement, Decimal? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  private static Boolean? GetAlignShape(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.AlignShape?.Value;
  }
  
  private static bool CmpAlignShape(DXVml.Fill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AlignShape?.Value == value) return true;
    diffs?.Add(objName, "AlignShape", openXmlElement?.AlignShape?.Value, value);
    return false;
  }
  
  private static void SetAlignShape(DXVml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignShape = value;
    else
      openXmlElement.AlignShape = null;
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  private static String? GetFocus(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Focus);
  }
  
  private static bool CmpFocus(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Focus, value, diffs, objName, "Focus");
  }
  
  private static void SetFocus(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Focus = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  private static String? GetFocusSize(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FocusSize);
  }
  
  private static bool CmpFocusSize(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FocusSize, value, diffs, objName, "FocusSize");
  }
  
  private static void SetFocusSize(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.FocusSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  private static String? GetFocusPosition(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FocusPosition);
  }
  
  private static bool CmpFocusPosition(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FocusPosition, value, diffs, objName, "FocusPosition");
  }
  
  private static void SetFocusPosition(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.FocusPosition = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  private static DMVml.FillMethodKind? GetMethod(DXVml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMVml.FillMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static bool CmpMethod(DXVml.Fill openXmlElement, DMVml.FillMethodKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMVml.FillMethodKind>(openXmlElement?.Method?.Value, value, diffs, objName);
  }
  
  private static void SetMethod(DXVml.Fill openXmlElement, DMVml.FillMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMVml.FillMethodKind>(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  private static Boolean? GetDetectMouseClick(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }
  
  private static bool CmpDetectMouseClick(DXVml.Fill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DetectMouseClick?.Value == value) return true;
    diffs?.Add(objName, "DetectMouseClick", openXmlElement?.DetectMouseClick?.Value, value);
    return false;
  }
  
  private static void SetDetectMouseClick(DXVml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DetectMouseClick = value;
    else
      openXmlElement.DetectMouseClick = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  private static String? GetOpacity2(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity2);
  }
  
  private static bool CmpOpacity2(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity2, value, diffs, objName, "Opacity2");
  }
  
  private static void SetOpacity2(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.Opacity2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  private static Boolean? GetRecolor(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Recolor?.Value;
  }
  
  private static bool CmpRecolor(DXVml.Fill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Recolor?.Value == value) return true;
    diffs?.Add(objName, "Recolor", openXmlElement?.Recolor?.Value, value);
    return false;
  }
  
  private static void SetRecolor(DXVml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Recolor = value;
    else
      openXmlElement.Recolor = null;
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  private static Boolean? GetRotate(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Rotate?.Value;
  }
  
  private static bool CmpRotate(DXVml.Fill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotate?.Value == value) return true;
    diffs?.Add(objName, "Rotate", openXmlElement?.Rotate?.Value, value);
    return false;
  }
  
  private static void SetRotate(DXVml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotate = value;
    else
      openXmlElement.Rotate = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetRelationshipId(DXVml.Fill openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXVml.Fill openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  private static DMVml.FillExtendedProperties? GetFillExtendedProperties(DXVml.Fill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.FillExtendedProperties>();
    if (element != null)
      return DMXVml.FillExtendedPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillExtendedProperties(DXVml.Fill openXmlElement, DMVml.FillExtendedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillExtendedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.FillExtendedProperties>(), value, diffs, objName);
  }
  
  private static void SetFillExtendedProperties(DXVml.Fill openXmlElement, DMVml.FillExtendedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.FillExtendedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.FillExtendedPropertiesConverter.CreateOpenXmlElement<DXVmlO.FillExtendedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Fill? CreateModelElement(DXVml.Fill? openXmlElement)
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
  
  public static bool CompareModelElement(DXVml.Fill? openXmlElement, DMVml.Fill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpOpacity(openXmlElement, value.Opacity, diffs, objName))
        ok = false;
      if (!CmpColor2(openXmlElement, value.Color2, diffs, objName))
        ok = false;
      if (!CmpSource(openXmlElement, value.Source, diffs, objName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName))
        ok = false;
      if (!CmpAlternateImageReference(openXmlElement, value.AlternateImageReference, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      if (!CmpOrigin(openXmlElement, value.Origin, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpAspect(openXmlElement, value.Aspect, diffs, objName))
        ok = false;
      if (!CmpColors(openXmlElement, value.Colors, diffs, objName))
        ok = false;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName))
        ok = false;
      if (!CmpAlignShape(openXmlElement, value.AlignShape, diffs, objName))
        ok = false;
      if (!CmpFocus(openXmlElement, value.Focus, diffs, objName))
        ok = false;
      if (!CmpFocusSize(openXmlElement, value.FocusSize, diffs, objName))
        ok = false;
      if (!CmpFocusPosition(openXmlElement, value.FocusPosition, diffs, objName))
        ok = false;
      if (!CmpMethod(openXmlElement, value.Method, diffs, objName))
        ok = false;
      if (!CmpDetectMouseClick(openXmlElement, value.DetectMouseClick, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpOpacity2(openXmlElement, value.Opacity2, diffs, objName))
        ok = false;
      if (!CmpRecolor(openXmlElement, value.Recolor, diffs, objName))
        ok = false;
      if (!CmpRotate(openXmlElement, value.Rotate, diffs, objName))
        ok = false;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      if (!CmpFillExtendedProperties(openXmlElement, value.FillExtendedProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Fill value)
    where OpenXmlElementType: DXVml.Fill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.Fill openXmlElement, DMVml.Fill value)
  {
    SetId(openXmlElement, value?.Id);
    SetType(openXmlElement, value?.Type);
    SetOn(openXmlElement, value?.On);
    SetColor(openXmlElement, value?.Color);
    SetOpacity(openXmlElement, value?.Opacity);
    SetColor2(openXmlElement, value?.Color2);
    SetSource(openXmlElement, value?.Source);
    SetHref(openXmlElement, value?.Href);
    SetAlternateImageReference(openXmlElement, value?.AlternateImageReference);
    SetSize(openXmlElement, value?.Size);
    SetOrigin(openXmlElement, value?.Origin);
    SetPosition(openXmlElement, value?.Position);
    SetAspect(openXmlElement, value?.Aspect);
    SetColors(openXmlElement, value?.Colors);
    SetAngle(openXmlElement, value?.Angle);
    SetAlignShape(openXmlElement, value?.AlignShape);
    SetFocus(openXmlElement, value?.Focus);
    SetFocusSize(openXmlElement, value?.FocusSize);
    SetFocusPosition(openXmlElement, value?.FocusPosition);
    SetMethod(openXmlElement, value?.Method);
    SetDetectMouseClick(openXmlElement, value?.DetectMouseClick);
    SetTitle(openXmlElement, value?.Title);
    SetOpacity2(openXmlElement, value?.Opacity2);
    SetRecolor(openXmlElement, value?.Recolor);
    SetRotate(openXmlElement, value?.Rotate);
    SetRelationshipId(openXmlElement, value?.RelationshipId);
    SetFillExtendedProperties(openXmlElement, value?.FillExtendedProperties);
  }
}
