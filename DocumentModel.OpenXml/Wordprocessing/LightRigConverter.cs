namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.LightRigKind? GetLightRigType(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DocumentModel.Wordprocessing.LightRigKind>(openXmlElement?.LightRigType?.Value);
  }
  
  private static void SetLightRigType(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement, DocumentModel.Wordprocessing.LightRigKind? value)
  {
    openXmlElement.LightRigType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DocumentModel.Wordprocessing.LightRigKind>(value);
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.LightRigDirectionKind? GetLightDirectionType(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DocumentModel.Wordprocessing.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value);
  }
  
  private static void SetLightDirectionType(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement, DocumentModel.Wordprocessing.LightRigDirectionKind? value)
  {
    openXmlElement.LightDirectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DocumentModel.Wordprocessing.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  private static DocumentModel.Wordprocessing.SphereCoordinates? GetSphereCoordinates(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SphereCoordinatesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSphereCoordinates(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement, DocumentModel.Wordprocessing.SphereCoordinates? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SphereCoordinatesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.LightRig? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LightRig();
      value.LightRigType = GetLightRigType(openXmlElement);
      value.LightDirectionType = GetLightDirectionType(openXmlElement);
      value.SphereCoordinates = GetSphereCoordinates(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LightRig? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.LightRig, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLightRigType(openXmlElement, value?.LightRigType);
      SetLightDirectionType(openXmlElement, value?.LightDirectionType);
      SetSphereCoordinates(openXmlElement, value?.SphereCoordinates);
      return openXmlElement;
    }
    return default;
  }
}
