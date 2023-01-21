namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Apply 3D shape properties.
/// </summary>
public static class Shape3DTypeConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.ExtrusionHeight?.Value;
  }
  
  private static void SetExtrusionHeight(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.ContourWidth?.Value;
  }
  
  private static void SetContourWidth(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMDraws.PresetMaterialKind? GetPresetMaterial(DXDraw.Shape3DType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static void SetPresetMaterial(DXDraw.Shape3DType openXmlElement, DMDraws.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelTop(DXDraw.Shape3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BevelTop>();
    if (itemElement != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelTop(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BevelTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BevelTypeConverter.CreateOpenXmlElement<DXDraw.BevelTop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelBottom(DXDraw.Shape3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BevelBottom>();
    if (itemElement != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelBottom(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BevelBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BevelTypeConverter.CreateOpenXmlElement<DXDraw.BevelBottom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  private static DMDraws.ExtrusionColor? GetExtrusionColor(DXDraw.Shape3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>();
    if (itemElement != null)
      return DMXDraws.ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusionColor(DXDraw.Shape3DType openXmlElement, DMDraws.ExtrusionColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtrusionColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtrusionColorConverter.CreateOpenXmlElement<DXDraw.ExtrusionColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  private static DMDraws.ContourColor? GetContourColor(DXDraw.Shape3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ContourColor>();
    if (itemElement != null)
      return DMXDraws.ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetContourColor(DXDraw.Shape3DType openXmlElement, DMDraws.ContourColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ContourColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ContourColorConverter.CreateOpenXmlElement<DXDraw.ContourColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Shape3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.Shape3DType openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Shape3DType? CreateModelElement(DXDraw.Shape3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Shape3DType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Shape3DType? value)
    where OpenXmlElementType: DXDraw.Shape3DType, new()
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
