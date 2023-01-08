namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public static class Properties3DConverter
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionHeight(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetContourWidth(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourWidth(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PresetMaterialKind? GetPresetMaterialType(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DocumentModel.Wordprocessing.PresetMaterialKind>(openXmlElement?.PresetMaterialType?.Value);
  }
  
  public static void SetPresetMaterialType(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.PresetMaterialKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetMaterialType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DocumentModel.Wordprocessing.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public static DocumentModel.Wordprocessing.BevelType? GetBevelTop(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelTop(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public static DocumentModel.Wordprocessing.BevelType? GetBevelBottom(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBevelBottom(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.BevelType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.ExtrusionColor? GetExtrusionColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.ExtrusionColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.ContourColor? GetContourColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetContourColor(DocumentFormat.OpenXml.Office2010.Word.Properties3D? openXmlElement, DocumentModel.Wordprocessing.ContourColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
