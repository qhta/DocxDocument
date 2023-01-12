namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public static class LockConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  public static Boolean? GetPosition(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  public static Boolean? GetSelection(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetSelection(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  public static Boolean? GetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  public static Boolean? GetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  public static Boolean? GetRotation(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  public static Boolean? GetCropping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetCropping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  public static Boolean? GetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  public static Boolean? GetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  public static Boolean? GetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  public static Boolean? GetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  public static Boolean? GetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static DocumentModel.Vml.Lock? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Lock();
      value.Extension = GetExtension(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.Grouping = GetGrouping(openXmlElement);
      value.Ungrouping = GetUngrouping(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      value.Cropping = GetCropping(openXmlElement);
      value.Verticies = GetVerticies(openXmlElement);
      value.AdjustHandles = GetAdjustHandles(openXmlElement);
      value.TextLock = GetTextLock(openXmlElement);
      value.AspectRatio = GetAspectRatio(openXmlElement);
      value.ShapeType = GetShapeType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Lock? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Lock, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetPosition(openXmlElement, value?.Position);
      SetSelection(openXmlElement, value?.Selection);
      SetGrouping(openXmlElement, value?.Grouping);
      SetUngrouping(openXmlElement, value?.Ungrouping);
      SetRotation(openXmlElement, value?.Rotation);
      SetCropping(openXmlElement, value?.Cropping);
      SetVerticies(openXmlElement, value?.Verticies);
      SetAdjustHandles(openXmlElement, value?.AdjustHandles);
      SetTextLock(openXmlElement, value?.TextLock);
      SetAspectRatio(openXmlElement, value?.AspectRatio);
      SetShapeType(openXmlElement, value?.ShapeType);
      return openXmlElement;
    }
    return default;
  }
}
