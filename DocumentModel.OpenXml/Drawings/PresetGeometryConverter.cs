using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using AdjustValueList = DocumentModel.Drawings.AdjustValueList;
using PresetGeometry = DocumentFormat.OpenXml.Drawing.PresetGeometry;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Preset geometry.
/// </summary>
public static class PresetGeometryConverter
{
  /// <summary>
  ///   Preset Shape
  /// </summary>
  public static ShapeKind? GetPreset(PresetGeometry? openXmlElement)
  {
    return EnumValueConverter.GetValue<ShapeTypeValues, ShapeKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(PresetGeometry? openXmlElement, ShapeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<ShapeTypeValues, ShapeKind>(value);
  }

  /// <summary>
  ///   List of Shape Adjust Values.
  /// </summary>
  public static AdjustValueList? GetAdjustValueList(PresetGeometry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustValueList(PresetGeometry? openXmlElement, AdjustValueList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustValueListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustValueList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PresetGeometry? CreateModelElement(PresetGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetGeometry();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetGeometry? value)
    where OpenXmlElementType : PresetGeometry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      return openXmlElement;
    }
    return default;
  }
}