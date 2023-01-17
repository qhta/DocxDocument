namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DocumentModel.Vml.FillKind? GetType(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Fill openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(value);
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  private static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  private static String? GetOpacity(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static void SetOpacity(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  private static String? GetColor2(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static void SetColor2(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  private static String? GetSource(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static void SetSource(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  private static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  private static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternateImageReference = new StringValue { Value = value };
    else
      openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  private static String? GetSize(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  private static void SetSize(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Size = new StringValue { Value = value };
    else
      openXmlElement.Size = null;
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  private static String? GetOrigin(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  private static void SetOrigin(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Origin = new StringValue { Value = value };
    else
      openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  private static String? GetPosition(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Position = new StringValue { Value = value };
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  private static DocumentModel.Vml.ImageAspectKind? GetAspect(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }
  
  private static void SetAspect(DocumentFormat.OpenXml.Vml.Fill openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  private static String? GetColors(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }
  
  private static void SetColors(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Colors = new StringValue { Value = value };
    else
      openXmlElement.Colors = null;
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  private static Decimal? GetAngle(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement.Angle?.Value;
  }
  
  private static void SetAngle(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Decimal? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  private static Boolean? GetAlignShape(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.AlignShape?.Value;
  }
  
  private static void SetAlignShape(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignShape = value;
    else
      openXmlElement.AlignShape = null;
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  private static String? GetFocus(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Focus?.Value;
  }
  
  private static void SetFocus(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Focus = new StringValue { Value = value };
    else
      openXmlElement.Focus = null;
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  private static String? GetFocusSize(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.FocusSize?.Value;
  }
  
  private static void SetFocusSize(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FocusSize = new StringValue { Value = value };
    else
      openXmlElement.FocusSize = null;
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  private static String? GetFocusPosition(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.FocusPosition?.Value;
  }
  
  private static void SetFocusPosition(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FocusPosition = new StringValue { Value = value };
    else
      openXmlElement.FocusPosition = null;
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  private static DocumentModel.Vml.FillMethodKind? GetMethod(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static void SetMethod(DocumentFormat.OpenXml.Vml.Fill openXmlElement, DocumentModel.Vml.FillMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  private static Boolean? GetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }
  
  private static void SetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DetectMouseClick = value;
    else
      openXmlElement.DetectMouseClick = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  private static String? GetOpacity2(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Opacity2?.Value;
  }
  
  private static void SetOpacity2(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity2 = new StringValue { Value = value };
    else
      openXmlElement.Opacity2 = null;
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  private static Boolean? GetRecolor(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Recolor?.Value;
  }
  
  private static void SetRecolor(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Recolor = value;
    else
      openXmlElement.Recolor = null;
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  private static Boolean? GetRotate(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.Rotate?.Value;
  }
  
  private static void SetRotate(DocumentFormat.OpenXml.Vml.Fill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotate = value;
    else
      openXmlElement.Rotate = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  private static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Fill openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelationshipId = new StringValue { Value = value };
    else
      openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  private static DocumentModel.Vml.FillExtendedProperties? GetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillExtendedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill openXmlElement, DocumentModel.Vml.FillExtendedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.FillExtendedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Fill? CreateModelElement(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Fill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Fill, new()
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
