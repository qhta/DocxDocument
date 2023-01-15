using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using BevelType = DocumentModel.Drawings.BevelType;
using ContourColor = DocumentModel.Drawings.ContourColor;
using ExtrusionColor = DocumentModel.Drawings.ExtrusionColor;
using HiddenShape3D = DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public static class HiddenShape3DConverter
{
  /// <summary>
  ///   Shape Depth
  /// </summary>
  public static Int64? GetZ(HiddenShape3D? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }

  public static void SetZ(HiddenShape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Z = value;
  }

  /// <summary>
  ///   Extrusion Height
  /// </summary>
  public static Int64? GetExtrusionHeight(HiddenShape3D? openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }

  public static void SetExtrusionHeight(HiddenShape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ExtrusionHeight = value;
  }

  /// <summary>
  ///   Contour Width
  /// </summary>
  public static Int64? GetContourWidth(HiddenShape3D? openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }

  public static void SetContourWidth(HiddenShape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContourWidth = value;
  }

  /// <summary>
  ///   Preset Material Type
  /// </summary>
  public static PresetMaterialKind? GetPresetMaterial(HiddenShape3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetMaterialTypeValues, PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }

  public static void SetPresetMaterial(HiddenShape3D? openXmlElement, PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<PresetMaterialTypeValues, PresetMaterialKind>(value);
  }

  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public static BevelType? GetBevelTop(HiddenShape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelTop>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelTop(HiddenShape3D? openXmlElement, BevelType? value)
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
  ///   Bottom Bevel.
  /// </summary>
  public static BevelType? GetBevelBottom(HiddenShape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelBottom>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelBottom(HiddenShape3D? openXmlElement, BevelType? value)
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
  ///   Extrusion Color.
  /// </summary>
  public static ExtrusionColor? GetExtrusionColor(HiddenShape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
    if (itemElement != null)
      return ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusionColor(HiddenShape3D? openXmlElement, ExtrusionColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Contour Color.
  /// </summary>
  public static ContourColor? GetContourColor(HiddenShape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
    if (itemElement != null)
      return ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetContourColor(HiddenShape3D? openXmlElement, ContourColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContourColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ContourColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(HiddenShape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(HiddenShape3D? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.HiddenShape3D? CreateModelElement(HiddenShape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenShape3D();
      value.Z = GetZ(openXmlElement);
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterial = GetPresetMaterial(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HiddenShape3D? value)
    where OpenXmlElementType : HiddenShape3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZ(openXmlElement, value?.Z);
      SetExtrusionHeight(openXmlElement, value?.ExtrusionHeight);
      SetContourWidth(openXmlElement, value?.ContourWidth);
      SetPresetMaterial(openXmlElement, value?.PresetMaterial);
      SetBevelTop(openXmlElement, value?.BevelTop);
      SetBevelBottom(openXmlElement, value?.BevelBottom);
      SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
      SetContourColor(openXmlElement, value?.ContourColor);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}