namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.LightRigKind? GetLightRigType(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DocumentModel.Wordprocessing.LightRigKind>(openXmlElement?.LightRigType?.Value);
  }
  
  public static void SetLightRigType(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement, DocumentModel.Wordprocessing.LightRigKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LightRigType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DocumentModel.Wordprocessing.LightRigKind>(value);
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.LightRigDirectionKind? GetLightDirectionType(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DocumentModel.Wordprocessing.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value);
  }
  
  public static void SetLightDirectionType(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement, DocumentModel.Wordprocessing.LightRigDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LightDirectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DocumentModel.Wordprocessing.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public static DocumentModel.Wordprocessing.SphereCoordinates? GetSphereCoordinates(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSphereCoordinates(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement, DocumentModel.Wordprocessing.SphereCoordinates? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
