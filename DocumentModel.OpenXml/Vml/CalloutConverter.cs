namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public static class CalloutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.Callout openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  private static Boolean? GetOn(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  private static String? GetType(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DXVmlO.Callout openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  private static String? GetGap(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.Gap?.Value;
  }
  
  private static void SetGap(DXVmlO.Callout openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gap = new StringValue { Value = value };
    else
      openXmlElement.Gap = null;
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  private static DMVml.AngleKind? GetAngle(DXVmlO.Callout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMVml.AngleKind>(openXmlElement?.Angle?.Value);
  }
  
  private static void SetAngle(DXVmlO.Callout openXmlElement, DMVml.AngleKind? value)
  {
    openXmlElement.Angle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DMVml.AngleKind>(value);
  }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  private static Boolean? GetDropAuto(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.DropAuto?.Value;
  }
  
  private static void SetDropAuto(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DropAuto = value;
    else
      openXmlElement.DropAuto = null;
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  private static String? GetDrop(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.Drop?.Value;
  }
  
  private static void SetDrop(DXVmlO.Callout openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Drop = new StringValue { Value = value };
    else
      openXmlElement.Drop = null;
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  private static String? GetDistance(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  private static void SetDistance(DXVmlO.Callout openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Distance = new StringValue { Value = value };
    else
      openXmlElement.Distance = null;
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  private static Boolean? GetLengthSpecified(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.LengthSpecified?.Value;
  }
  
  private static void SetLengthSpecified(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LengthSpecified = value;
    else
      openXmlElement.LengthSpecified = null;
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  private static String? GetLength(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.Length?.Value;
  }
  
  private static void SetLength(DXVmlO.Callout openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Length = new StringValue { Value = value };
    else
      openXmlElement.Length = null;
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  private static Boolean? GetAccentBar(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.AccentBar?.Value;
  }
  
  private static void SetAccentBar(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AccentBar = value;
    else
      openXmlElement.AccentBar = null;
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  private static Boolean? GetTextBorder(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.TextBorder?.Value;
  }
  
  private static void SetTextBorder(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBorder = value;
    else
      openXmlElement.TextBorder = null;
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  private static Boolean? GetMinusX(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.MinusX?.Value;
  }
  
  private static void SetMinusX(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusX = value;
    else
      openXmlElement.MinusX = null;
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  private static Boolean? GetMinusY(DXVmlO.Callout openXmlElement)
  {
    return openXmlElement?.MinusY?.Value;
  }
  
  private static void SetMinusY(DXVmlO.Callout openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MinusY = value;
    else
      openXmlElement.MinusY = null;
  }
  
  public static DMVml.Callout? CreateModelElement(DXVmlO.Callout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Callout();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Callout? value)
    where OpenXmlElementType: DXVmlO.Callout, new()
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
