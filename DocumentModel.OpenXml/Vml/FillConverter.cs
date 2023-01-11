namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public static DocumentModel.Vml.FillKind? GetType(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(value);
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity = new StringValue { Value = value };
      else
        openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  public static String? GetSource(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  public static void SetSource(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Source = new StringValue { Value = value };
      else
        openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  public static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  public static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternateImageReference = new StringValue { Value = value };
      else
        openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  public static String? GetSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Size = new StringValue { Value = value };
      else
        openXmlElement.Size = null;
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  public static String? GetOrigin(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  public static void SetOrigin(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Origin = new StringValue { Value = value };
      else
        openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Position = new StringValue { Value = value };
      else
        openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public static DocumentModel.Vml.ImageAspectKind? GetAspect(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }
  
  public static void SetAspect(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  public static String? GetColors(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }
  
  public static void SetColors(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Colors = new StringValue { Value = value };
      else
        openXmlElement.Colors = null;
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  public static Decimal? GetAngle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Decimal? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  public static Boolean? GetAlignShape(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAlignShape(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  public static String? GetFocus(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Focus?.Value;
  }
  
  public static void SetFocus(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Focus = new StringValue { Value = value };
      else
        openXmlElement.Focus = null;
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  public static String? GetFocusSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.FocusSize?.Value;
  }
  
  public static void SetFocusSize(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FocusSize = new StringValue { Value = value };
      else
        openXmlElement.FocusSize = null;
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  public static String? GetFocusPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.FocusPosition?.Value;
  }
  
  public static void SetFocusPosition(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FocusPosition = new StringValue { Value = value };
      else
        openXmlElement.FocusPosition = null;
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public static DocumentModel.Vml.FillMethodKind? GetMethod(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(openXmlElement?.Method?.Value);
  }
  
  public static void SetMethod(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillMethodKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues, DocumentModel.Vml.FillMethodKind>(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public static Boolean? GetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetDetectMouseClick(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  public static String? GetOpacity2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.Opacity2?.Value;
  }
  
  public static void SetOpacity2(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity2 = new StringValue { Value = value };
      else
        openXmlElement.Opacity2 = null;
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  public static Boolean? GetRecolor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetRecolor(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  public static Boolean? GetRotate(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetRotate(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public static DocumentModel.Vml.FillExtendedProperties? GetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillExtendedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillExtendedProperties(DocumentFormat.OpenXml.Vml.Fill? openXmlElement, DocumentModel.Vml.FillExtendedProperties? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
