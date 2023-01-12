namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public static class OleObjectConverter
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public static DocumentModel.Vml.OleKind? GetType(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DocumentModel.Vml.OleKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, DocumentModel.Vml.OleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DocumentModel.Vml.OleKind>(value);
  }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  public static String? GetProgId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  public static void SetProgId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProgId = new StringValue { Value = value };
      else
        openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public static DocumentModel.Vml.OleDrawAspectKind? GetDrawAspect(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DocumentModel.Vml.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }
  
  public static void SetDrawAspect(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, DocumentModel.Vml.OleDrawAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DrawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DocumentModel.Vml.OleDrawAspectKind>(value);
  }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  public static String? GetObjectId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return openXmlElement?.ObjectId?.Value;
  }
  
  public static void SetObjectId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ObjectId = new StringValue { Value = value };
      else
        openXmlElement.ObjectId = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public static DocumentModel.Vml.OleUpdateMode? GetUpdateMode(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DocumentModel.Vml.OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  public static void SetUpdateMode(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, DocumentModel.Vml.OleUpdateMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DocumentModel.Vml.OleUpdateMode>(value);
  }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  public static String? GetLinkType(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.LinkType");
  }
  
  public static void SetLinkType(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.LinkType");
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public static String? GetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.LockedField");
  }
  
  public static void SetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.LockedField");
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public static String? GetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.FieldCodes");
  }
  
  public static void SetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Vml.Office.FieldCodes");
  }
  
  public static DocumentModel.Vml.OleObject? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.OleObject();
      value.Type = GetType(openXmlElement);
      value.ProgId = GetProgId(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.DrawAspect = GetDrawAspect(openXmlElement);
      value.ObjectId = GetObjectId(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.UpdateMode = GetUpdateMode(openXmlElement);
      value.LinkType = GetLinkType(openXmlElement);
      value.LockedField = GetLockedField(openXmlElement);
      value.FieldCodes = GetFieldCodes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.OleObject? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.OleObject, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetProgId(openXmlElement, value?.ProgId);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetDrawAspect(openXmlElement, value?.DrawAspect);
      SetObjectId(openXmlElement, value?.ObjectId);
      SetId(openXmlElement, value?.Id);
      SetUpdateMode(openXmlElement, value?.UpdateMode);
      SetLinkType(openXmlElement, value?.LinkType);
      SetLockedField(openXmlElement, value?.LockedField);
      SetFieldCodes(openXmlElement, value?.FieldCodes);
      return openXmlElement;
    }
    return default;
  }
}
