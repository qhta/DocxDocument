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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RotationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement, DocumentModel.Drawings.Rotation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RotationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rotation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LightRig? CreateModelElement(DocumentFormat.OpenXml.Drawing.LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LightRig();
      value.Rig = GetRig(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LightRig? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LightRig, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRig(openXmlElement, value?.Rig);
      SetDirection(openXmlElement, value?.Direction);
      SetRotation(openXmlElement, value?.Rotation);
      return openXmlElement;
    }
    return default;
  }
}
