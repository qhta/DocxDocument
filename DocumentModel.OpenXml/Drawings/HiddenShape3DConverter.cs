namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
public static class HiddenShape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public static Int64? GetZ(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetZ(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public static Int64? GetContourWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public static DocumentModel.Drawings.PresetMaterialKind? GetPresetMaterial(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  public static void SetPresetMaterial(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelTop(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelTop(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelBottom(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public static DocumentModel.Drawings.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.ExtrusionColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public static DocumentModel.Drawings.ContourColor? GetContourColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourColor(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.ContourColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
