using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using BevelType = DocumentModel.Wordprocessing.BevelType;
using ContourColor = DocumentModel.Wordprocessing.ContourColor;
using ExtrusionColor = DocumentModel.Wordprocessing.ExtrusionColor;
using Properties3D = DocumentFormat.OpenXml.Office2010.Word.Properties3D;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Properties3D Class.
/// </summary>
public static class Properties3DConverter
{
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetExtrusionHeight(Properties3D? openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }

  public static void SetExtrusionHeight(Properties3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ExtrusionHeight = value;
  }

  /// <summary>
  ///   contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetContourWidth(Properties3D? openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }

  public static void SetContourWidth(Properties3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContourWidth = value;
  }

  /// <summary>
  ///   prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public static PresetMaterialKind? GetPresetMaterialType(Properties3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetMaterialTypeValues, PresetMaterialKind>(openXmlElement?.PresetMaterialType?.Value);
  }

  public static void SetPresetMaterialType(Properties3D? openXmlElement, PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterialType = EnumValueConverter.CreateEnumValue<PresetMaterialTypeValues, PresetMaterialKind>(value);
  }

  /// <summary>
  ///   BevelTop.
  /// </summary>
  public static BevelType? GetBevelTop(Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelTop>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelTop(Properties3D? openXmlElement, BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BevelTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelTypeConverter.CreateOpenXmlElement<BevelTop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BevelBottom.
  /// </summary>
  public static BevelType? GetBevelBottom(Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelBottom>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelBottom(Properties3D? openXmlElement, BevelType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BevelBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelTypeConverter.CreateOpenXmlElement<BevelBottom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  public static ExtrusionColor? GetExtrusionColor(Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
    if (itemElement != null)
      return ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusionColor(Properties3D? openXmlElement, ExtrusionColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ContourColor.
  /// </summary>
  public static ContourColor? GetContourColor(Properties3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
    if (itemElement != null)
      return ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetContourColor(Properties3D? openXmlElement, ContourColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContourColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ContourColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Properties3D? CreateModelElement(Properties3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Properties3D();
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterialType = GetPresetMaterialType(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Properties3D? value)
    where OpenXmlElementType : Properties3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtrusionHeight(openXmlElement, value?.ExtrusionHeight);
      SetContourWidth(openXmlElement, value?.ContourWidth);
      SetPresetMaterialType(openXmlElement, value?.PresetMaterialType);
      SetBevelTop(openXmlElement, value?.BevelTop);
      SetBevelBottom(openXmlElement, value?.BevelBottom);
      SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
      SetContourColor(openXmlElement, value?.ContourColor);
      return openXmlElement;
    }
    return default;
  }
}