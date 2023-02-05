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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Color?.Value;
  }
  
  private static bool CmpColor(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color?.Value == value) return true;
    diffs?.Add(objName, "Color", openXmlElement?.Color?.Value, value);
    return false;
  }
  
  private static void SetColor(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  private static String? GetOpacity(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static bool CmpOpacity(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Opacity?.Value == value) return true;
    diffs?.Add(objName, "Opacity", openXmlElement?.Opacity?.Value, value);
    return false;
  }
  
  private static void SetOpacity(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  private static String? GetColor2(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static bool CmpColor2(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color2?.Value == value) return true;
    diffs?.Add(objName, "Color2", openXmlElement?.Color2?.Value, value);
    return false;
  }
  
  private static void SetColor2(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  private static String? GetSource(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static bool CmpSource(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Source?.Value == value) return true;
    diffs?.Add(objName, "Source", openXmlElement?.Source?.Value, value);
    return false;
  }
  
  private static void SetSource(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static bool CmpHref(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Href?.Value == value) return true;
    diffs?.Add(objName, "Href", openXmlElement?.Href?.Value, value);
    return false;
  }
  
  private static void SetHref(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  private static String? GetAlternateImageReference(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  private static bool CmpAlternateImageReference(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AlternateImageReference?.Value == value) return true;
    diffs?.Add(objName, "AlternateImageReference", openXmlElement?.AlternateImageReference?.Value, value);
    return false;
  }
  
  private static void SetAlternateImageReference(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternateImageReference = new StringValue { Value = value };
    else
      openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  private static String? GetSize(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  private static bool CmpSize(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value) return true;
    diffs?.Add(objName, "Size", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Size = new StringValue { Value = value };
    else
      openXmlElement.Size = null;
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  private static String? GetOrigin(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  private static bool CmpOrigin(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Origin?.Value == value) return true;
    diffs?.Add(objName, "Origin", openXmlElement?.Origin?.Value, value);
    return false;
  }
  
  private static void SetOrigin(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Origin = new StringValue { Value = value };
    else
      openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  private static String? GetPosition(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Position = new StringValue { Value = value };
    else
      openXmlElement.Position = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.Aspect?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Colors?.Value;
  }
  
  private static bool CmpColors(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Colors?.Value == value) return true;
    diffs?.Add(objName, "Colors", openXmlElement?.Colors?.Value, value);
    return false;
  }
  
  private static void SetColors(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Colors = new StringValue { Value = value };
    else
      openXmlElement.Colors = null;
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
    return openXmlElement?.Focus?.Value;
  }
  
  private static bool CmpFocus(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Focus?.Value == value) return true;
    diffs?.Add(objName, "Focus", openXmlElement?.Focus?.Value, value);
    return false;
  }
  
  private static void SetFocus(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Focus = new StringValue { Value = value };
    else
      openXmlElement.Focus = null;
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  private static String? GetFocusSize(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.FocusSize?.Value;
  }
  
  private static bool CmpFocusSize(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FocusSize?.Value == value) return true;
    diffs?.Add(objName, "FocusSize", openXmlElement?.FocusSize?.Value, value);
    return false;
  }
  
  private static void SetFocusSize(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FocusSize = new StringValue { Value = value };
    else
      openXmlElement.FocusSize = null;
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  private static String? GetFocusPosition(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.FocusPosition?.Value;
  }
  
  private static bool CmpFocusPosition(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FocusPosition?.Value == value) return true;
    diffs?.Add(objName, "FocusPosition", openXmlElement?.FocusPosition?.Value, value);
    return false;
  }
  
  private static void SetFocusPosition(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FocusPosition = new StringValue { Value = value };
    else
      openXmlElement.FocusPosition = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DMVml.FillMethodKind>(openXmlElement?.Method?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Title?.Value == value) return true;
    diffs?.Add(objName, "Title", openXmlElement?.Title?.Value, value);
    return false;
  }
  
  private static void SetTitle(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  private static String? GetOpacity2(DXVml.Fill openXmlElement)
  {
    return openXmlElement?.Opacity2?.Value;
  }
  
  private static bool CmpOpacity2(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Opacity2?.Value == value) return true;
    diffs?.Add(objName, "Opacity2", openXmlElement?.Opacity2?.Value, value);
    return false;
  }
  
  private static void SetOpacity2(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity2 = new StringValue { Value = value };
    else
      openXmlElement.Opacity2 = null;
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
    return openXmlElement?.RelationshipId?.Value;
  }
  
  private static bool CmpRelationshipId(DXVml.Fill openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipId?.Value == value) return true;
    diffs?.Add(objName, "RelationshipId", openXmlElement?.RelationshipId?.Value, value);
    return false;
  }
  
  private static void SetRelationshipId(DXVml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelationshipId = new StringValue { Value = value };
    else
      openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  private static DMVml.FillExtendedProperties? GetFillExtendedProperties(DXVml.Fill openXmlElement)
  {
    return DMXVml.FillExtendedPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.FillExtendedProperties>());
  }
  
  private static bool CmpFillExtendedProperties(DXVml.Fill openXmlElement, DMVml.FillExtendedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillExtendedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.FillExtendedProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMVml.Fill? CreateModelElement(DXVml.Fill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Fill();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Fill? value)
    where OpenXmlElementType: DXVml.Fill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
