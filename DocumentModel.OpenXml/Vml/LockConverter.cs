namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public static class LockConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  private static Boolean? GetPosition(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Position = value;
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  private static Boolean? GetSelection(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Selection?.Value;
  }
  
  private static void SetSelection(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Selection = value;
    else
      openXmlElement.Selection = null;
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  private static Boolean? GetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Grouping?.Value;
  }
  
  private static void SetGrouping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grouping = value;
    else
      openXmlElement.Grouping = null;
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  private static Boolean? GetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Ungrouping?.Value;
  }
  
  private static void SetUngrouping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ungrouping = value;
    else
      openXmlElement.Ungrouping = null;
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  private static Boolean? GetRotation(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static void SetRotation(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotation = value;
    else
      openXmlElement.Rotation = null;
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  private static Boolean? GetCropping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Cropping?.Value;
  }
  
  private static void SetCropping(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Cropping = value;
    else
      openXmlElement.Cropping = null;
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  private static Boolean? GetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.Verticies?.Value;
  }
  
  private static void SetVerticies(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Verticies = value;
    else
      openXmlElement.Verticies = null;
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  private static Boolean? GetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.AdjustHandles?.Value;
  }
  
  private static void SetAdjustHandles(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AdjustHandles = value;
    else
      openXmlElement.AdjustHandles = null;
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  private static Boolean? GetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.TextLock?.Value;
  }
  
  private static void SetTextLock(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextLock = value;
    else
      openXmlElement.TextLock = null;
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  private static Boolean? GetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.AspectRatio?.Value;
  }
  
  private static void SetAspectRatio(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AspectRatio = value;
    else
      openXmlElement.AspectRatio = null;
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  private static Boolean? GetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement)
  {
    return openXmlElement?.ShapeType?.Value;
  }
  
  private static void SetShapeType(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShapeType = value;
    else
      openXmlElement.ShapeType = null;
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
