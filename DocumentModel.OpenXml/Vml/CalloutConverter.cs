using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Callout = DocumentFormat.OpenXml.Vml.Office.Callout;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Callout Class.
/// </summary>
public static class CalloutConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Callout? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Callout? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Callout toggle
  /// </summary>
  public static Boolean? GetOn(Callout? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Callout type
  /// </summary>
  public static String? GetType(Callout? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }

  public static void SetType(Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }

  /// <summary>
  ///   Callout gap
  /// </summary>
  public static String? GetGap(Callout? openXmlElement)
  {
    return openXmlElement?.Gap?.Value;
  }

  public static void SetGap(Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gap = new StringValue { Value = value };
      else
        openXmlElement.Gap = null;
  }

  /// <summary>
  ///   Callout angle
  /// </summary>
  public static AngleKind? GetAngle(Callout? openXmlElement)
  {
    return EnumValueConverter.GetValue<AngleValues, AngleKind>(openXmlElement?.Angle?.Value);
  }

  public static void SetAngle(Callout? openXmlElement, AngleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = EnumValueConverter.CreateEnumValue<AngleValues, AngleKind>(value);
  }

  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  public static Boolean? GetDropAuto(Callout? openXmlElement)
  {
    return openXmlElement?.DropAuto?.Value;
  }

  public static void SetDropAuto(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DropAuto = value;
      else
        openXmlElement.DropAuto = null;
  }

  /// <summary>
  ///   Callout drop position
  /// </summary>
  public static String? GetDrop(Callout? openXmlElement)
  {
    return openXmlElement?.Drop?.Value;
  }

  public static void SetDrop(Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Drop = new StringValue { Value = value };
      else
        openXmlElement.Drop = null;
  }

  /// <summary>
  ///   Callout drop distance
  /// </summary>
  public static String? GetDistance(Callout? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }

  public static void SetDistance(Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Distance = new StringValue { Value = value };
      else
        openXmlElement.Distance = null;
  }

  /// <summary>
  ///   Callout length toggle
  /// </summary>
  public static Boolean? GetLengthSpecified(Callout? openXmlElement)
  {
    return openXmlElement?.LengthSpecified?.Value;
  }

  public static void SetLengthSpecified(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LengthSpecified = value;
      else
        openXmlElement.LengthSpecified = null;
  }

  /// <summary>
  ///   Callout length
  /// </summary>
  public static String? GetLength(Callout? openXmlElement)
  {
    return openXmlElement?.Length?.Value;
  }

  public static void SetLength(Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Length = new StringValue { Value = value };
      else
        openXmlElement.Length = null;
  }

  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  public static Boolean? GetAccentBar(Callout? openXmlElement)
  {
    return openXmlElement?.AccentBar?.Value;
  }

  public static void SetAccentBar(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AccentBar = value;
      else
        openXmlElement.AccentBar = null;
  }

  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  public static Boolean? GetTextBorder(Callout? openXmlElement)
  {
    return openXmlElement?.TextBorder?.Value;
  }

  public static void SetTextBorder(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextBorder = value;
      else
        openXmlElement.TextBorder = null;
  }

  /// <summary>
  ///   Callout flip x
  /// </summary>
  public static Boolean? GetMinusX(Callout? openXmlElement)
  {
    return openXmlElement?.MinusX?.Value;
  }

  public static void SetMinusX(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinusX = value;
      else
        openXmlElement.MinusX = null;
  }

  /// <summary>
  ///   Callout flip y
  /// </summary>
  public static Boolean? GetMinusY(Callout? openXmlElement)
  {
    return openXmlElement?.MinusY?.Value;
  }

  public static void SetMinusY(Callout? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinusY = value;
      else
        openXmlElement.MinusY = null;
  }

  public static DocumentModel.Vml.Callout? CreateModelElement(Callout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Callout();
      value.Extension = GetExtension(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Gap = GetGap(openXmlElement);
      value.Angle = GetAngle(openXmlElement);
      value.DropAuto = GetDropAuto(openXmlElement);
      value.Drop = GetDrop(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.LengthSpecified = GetLengthSpecified(openXmlElement);
      value.Length = GetLength(openXmlElement);
      value.AccentBar = GetAccentBar(openXmlElement);
      value.TextBorder = GetTextBorder(openXmlElement);
      value.MinusX = GetMinusX(openXmlElement);
      value.MinusY = GetMinusY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Callout? value)
    where OpenXmlElementType : Callout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetOn(openXmlElement, value?.On);
      SetType(openXmlElement, value?.Type);
      SetGap(openXmlElement, value?.Gap);
      SetAngle(openXmlElement, value?.Angle);
      SetDropAuto(openXmlElement, value?.DropAuto);
      SetDrop(openXmlElement, value?.Drop);
      SetDistance(openXmlElement, value?.Distance);
      SetLengthSpecified(openXmlElement, value?.LengthSpecified);
      SetLength(openXmlElement, value?.Length);
      SetAccentBar(openXmlElement, value?.AccentBar);
      SetTextBorder(openXmlElement, value?.TextBorder);
      SetMinusX(openXmlElement, value?.MinusX);
      SetMinusY(openXmlElement, value?.MinusY);
      return openXmlElement;
    }
    return default;
  }
}