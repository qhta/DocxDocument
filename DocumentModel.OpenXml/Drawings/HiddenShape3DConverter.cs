namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
public static class HiddenShape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static void SetZ(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    return openXmlElement.ExtrusionHeight?.Value;
  }
  
  private static void SetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    return openXmlElement.ContourWidth?.Value;
  }
  
  private static void SetContourWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DocumentModel.Drawings.PresetMaterialKind? GetPresetMaterial(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static void SetPresetMaterial(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DocumentModel.Drawings.BevelType? GetBevelTop(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelTop(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BevelTop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  private static DocumentModel.Drawings.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBevelBottom(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BevelTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BevelBottom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  private static DocumentModel.Drawings.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtrusionColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusionColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.ExtrusionColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtrusionColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  private static DocumentModel.Drawings.ContourColor? GetContourColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ContourColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetContourColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.ContourColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ContourColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ContourColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HiddenShape3D? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D, new()
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
