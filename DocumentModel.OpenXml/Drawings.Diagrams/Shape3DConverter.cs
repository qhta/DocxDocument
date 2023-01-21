namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public static class Shape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement.ExtrusionHeight?.Value;
  }
  
  private static void SetExtrusionHeight(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement.ContourWidth?.Value;
  }
  
  private static void SetContourWidth(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMDraws.PresetMaterialKind? GetPresetMaterial(DXDrawDgms.Shape3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static void SetPresetMaterial(DXDrawDgms.Shape3D openXmlElement, DMDraws.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelTop(DXDrawDgms.Shape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BevelTop>();
    if (itemElement != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelTop(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.BevelType? GetBevelBottom(DXDrawDgms.Shape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BevelBottom>();
    if (itemElement != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelBottom(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.ExtrusionColor? GetExtrusionColor(DXDrawDgms.Shape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>();
    if (itemElement != null)
      return DMXDraws.ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusionColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtrusionColor? value)
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
  private static DMDraws.ContourColor? GetContourColor(DXDrawDgms.Shape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ContourColor>();
    if (itemElement != null)
      return DMXDraws.ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetContourColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ContourColor? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawDgms.Shape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDrawsDgms.Shape3D? CreateModelElement(DXDrawDgms.Shape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Shape3D();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Shape3D? value)
    where OpenXmlElementType: DXDrawDgms.Shape3D, new()
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
