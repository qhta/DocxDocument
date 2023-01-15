using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings;
using BevelType = DocumentModel.Drawings.BevelType;
using ContourColor = DocumentModel.Drawings.ContourColor;
using ExtrusionColor = DocumentModel.Drawings.ExtrusionColor;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   3-D Shape Properties.
/// </summary>
public static class Shape3DConverter
{
  /// <summary>
  ///   Shape Depth
  /// </summary>
  public static Int64? GetZ(Shape3D? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }

  public static void SetZ(Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Z = value;
  }

  /// <summary>
  ///   Extrusion Height
  /// </summary>
  public static Int64? GetExtrusionHeight(Shape3D? openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }

  public static void SetExtrusionHeight(Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ExtrusionHeight = value;
  }

  /// <summary>
  ///   Contour Width
  /// </summary>
  public static Int64? GetContourWidth(Shape3D? openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }

  public static void SetContourWidth(Shape3D? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContourWidth = value;
  }

  /// <summary>
  ///   Preset Material Type
  /// </summary>
  public static PresetMaterialKind? GetPresetMaterial(Shape3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetMaterialTypeValues, PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }

  public static void SetPresetMaterial(Shape3D? openXmlElement, PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<PresetMaterialTypeValues, PresetMaterialKind>(value);
  }

  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public static BevelType? GetBevelTop(Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelTop>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelTop(Shape3D? openXmlElement, BevelType? value)
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
  public static BevelType? GetBevelBottom(Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BevelBottom>();
    if (itemElement != null)
      return BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBevelBottom(Shape3D? openXmlElement, BevelType? value)
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
  public static ExtrusionColor? GetExtrusionColor(Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
    if (itemElement != null)
      return ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusionColor(Shape3D? openXmlElement, ExtrusionColor? value)
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
  public static ContourColor? GetContourColor(Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
    if (itemElement != null)
      return ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetContourColor(Shape3D? openXmlElement, ContourColor? value)
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
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(Shape3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Shape3D? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Shape3D? CreateModelElement(Shape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Shape3D();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Shape3D? value)
    where OpenXmlElementType : Shape3D, new()
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