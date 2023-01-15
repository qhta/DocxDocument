using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Lock = DocumentFormat.OpenXml.Vml.Office.Lock;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Lock Class.
/// </summary>
public static class LockConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Lock? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Lock? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Position Lock
  /// </summary>
  public static Boolean? GetPosition(Lock? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }

  public static void SetPosition(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Position = value;
      else
        openXmlElement.Position = null;
  }

  /// <summary>
  ///   Selection Lock
  /// </summary>
  public static Boolean? GetSelection(Lock? openXmlElement)
  {
    return openXmlElement?.Selection?.Value;
  }

  public static void SetSelection(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Selection = value;
      else
        openXmlElement.Selection = null;
  }

  /// <summary>
  ///   Grouping Lock
  /// </summary>
  public static Boolean? GetGrouping(Lock? openXmlElement)
  {
    return openXmlElement?.Grouping?.Value;
  }

  public static void SetGrouping(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Grouping = value;
      else
        openXmlElement.Grouping = null;
  }

  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  public static Boolean? GetUngrouping(Lock? openXmlElement)
  {
    return openXmlElement?.Ungrouping?.Value;
  }

  public static void SetUngrouping(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ungrouping = value;
      else
        openXmlElement.Ungrouping = null;
  }

  /// <summary>
  ///   Rotation Lock
  /// </summary>
  public static Boolean? GetRotation(Lock? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }

  public static void SetRotation(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Rotation = value;
      else
        openXmlElement.Rotation = null;
  }

  /// <summary>
  ///   Cropping Lock
  /// </summary>
  public static Boolean? GetCropping(Lock? openXmlElement)
  {
    return openXmlElement?.Cropping?.Value;
  }

  public static void SetCropping(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Cropping = value;
      else
        openXmlElement.Cropping = null;
  }

  /// <summary>
  ///   Vertices Lock
  /// </summary>
  public static Boolean? GetVerticies(Lock? openXmlElement)
  {
    return openXmlElement?.Verticies?.Value;
  }

  public static void SetVerticies(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Verticies = value;
      else
        openXmlElement.Verticies = null;
  }

  /// <summary>
  ///   Handles Lock
  /// </summary>
  public static Boolean? GetAdjustHandles(Lock? openXmlElement)
  {
    return openXmlElement?.AdjustHandles?.Value;
  }

  public static void SetAdjustHandles(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdjustHandles = value;
      else
        openXmlElement.AdjustHandles = null;
  }

  /// <summary>
  ///   Text Lock
  /// </summary>
  public static Boolean? GetTextLock(Lock? openXmlElement)
  {
    return openXmlElement?.TextLock?.Value;
  }

  public static void SetTextLock(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextLock = value;
      else
        openXmlElement.TextLock = null;
  }

  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  public static Boolean? GetAspectRatio(Lock? openXmlElement)
  {
    return openXmlElement?.AspectRatio?.Value;
  }

  public static void SetAspectRatio(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AspectRatio = value;
      else
        openXmlElement.AspectRatio = null;
  }

  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  public static Boolean? GetShapeType(Lock? openXmlElement)
  {
    return openXmlElement?.ShapeType?.Value;
  }

  public static void SetShapeType(Lock? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeType = value;
      else
        openXmlElement.ShapeType = null;
  }

  public static DocumentModel.Vml.Lock? CreateModelElement(Lock? openXmlElement)
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
    where OpenXmlElementType : Lock, new()
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