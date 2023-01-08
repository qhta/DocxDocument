namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Apply 3D shape properties.
/// </summary>
public static class Shape3DTypeConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public static Int64? GetZ(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetZ(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionHeight(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public static Int64? GetContourWidth(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourWidth(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public static DocumentModel.Drawings.PresetMaterialKind? GetPresetMaterial(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  public static void SetPresetMaterial(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DocumentModel.Drawings.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelTop(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelTop(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public static DocumentModel.Drawings.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelBottom(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public static DocumentModel.Drawings.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.ExtrusionColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public static DocumentModel.Drawings.ContourColor? GetContourColor(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourColor(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.ContourColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Shape3DType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
