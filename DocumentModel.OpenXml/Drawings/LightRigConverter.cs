namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public static DocumentModel.Drawings.LightRigKind? GetRig(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DocumentModel.Drawings.LightRigKind>(openXmlElement?.Rig?.Value);
  }
  
  public static void SetRig(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement, DocumentModel.Drawings.LightRigKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rig = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DocumentModel.Drawings.LightRigKind>(value);
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public static DocumentModel.Drawings.LightRigDirectionKind? GetDirection(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DocumentModel.Drawings.LightRigDirectionKind>(openXmlElement?.Direction?.Value);
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement, DocumentModel.Drawings.LightRigDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DocumentModel.Drawings.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public static DocumentModel.Drawings.Rotation? GetRotation(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement, DocumentModel.Drawings.Rotation? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
