using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using LinePropertiesType = DocumentFormat.OpenXml.Drawing.LinePropertiesType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public static class LinePropertiesTypeConverter
{
  /// <summary>
  ///   line width
  /// </summary>
  public static Int32? GetWidth(LinePropertiesType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(LinePropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   line cap
  /// </summary>
  public static LineCapKind? GetCapType(LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineCapValues, LineCapKind>(openXmlElement?.CapType?.Value);
  }

  public static void SetCapType(LinePropertiesType? openXmlElement, LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<LineCapValues, LineCapKind>(value);
  }

  /// <summary>
  ///   compound line type
  /// </summary>
  public static CompoundLineKind? GetCompoundLineType(LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<CompoundLineValues, CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }

  public static void SetCompoundLineType(LinePropertiesType? openXmlElement, CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<CompoundLineValues, CompoundLineKind>(value);
  }

  /// <summary>
  ///   pen alignment
  /// </summary>
  public static PenAlignmentKind? GetAlignment(LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<PenAlignmentValues, PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(LinePropertiesType? openXmlElement, PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<PenAlignmentValues, PenAlignmentKind>(value);
  }

  public static DocumentModel.Drawings.LinePropertiesType? CreateModelElement(LinePropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesType();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesType? value)
    where OpenXmlElementType : LinePropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetCapType(openXmlElement, value?.CapType);
      SetCompoundLineType(openXmlElement, value?.CompoundLineType);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}