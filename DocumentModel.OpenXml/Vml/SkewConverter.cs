using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Skew = DocumentFormat.OpenXml.Vml.Office.Skew;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Skew Transform.
/// </summary>
public static class SkewConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Skew? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Skew? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Skew ID
  /// </summary>
  public static String? GetId(Skew? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Skew Toggle
  /// </summary>
  public static Boolean? GetOn(Skew? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(Skew? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Skew Offset
  /// </summary>
  public static String? GetOffset(Skew? openXmlElement)
  {
    return openXmlElement?.Offset?.Value;
  }

  public static void SetOffset(Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Offset = new StringValue { Value = value };
      else
        openXmlElement.Offset = null;
  }

  /// <summary>
  ///   Skew Origin
  /// </summary>
  public static String? GetOrigin(Skew? openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }

  public static void SetOrigin(Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Origin = new StringValue { Value = value };
      else
        openXmlElement.Origin = null;
  }

  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  public static String? GetMatrix(Skew? openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }

  public static void SetMatrix(Skew? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Matrix = new StringValue { Value = value };
      else
        openXmlElement.Matrix = null;
  }

  public static DocumentModel.Vml.Skew? CreateModelElement(Skew? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Skew();
      value.Extension = GetExtension(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Skew? value)
    where OpenXmlElementType : Skew, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetId(openXmlElement, value?.Id);
      SetOn(openXmlElement, value?.On);
      SetOffset(openXmlElement, value?.Offset);
      SetOrigin(openXmlElement, value?.Origin);
      SetMatrix(openXmlElement, value?.Matrix);
      return openXmlElement;
    }
    return default;
  }
}