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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  public static Boolean? GetSelection(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSelection(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  public static Boolean? GetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  public static Boolean? GetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  public static Boolean? GetRotation(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  public static Boolean? GetCropping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCropping(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  public static Boolean? GetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  public static Boolean? GetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  public static Boolean? GetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  public static Boolean? GetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  public static Boolean? GetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
