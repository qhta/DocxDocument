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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetProgId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetObjectId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Vml.Office.LinkType");
  }
  
  public static void SetLinkType(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public static String? GetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Vml.Office.LockedField");
  }
  
  public static void SetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public static String? GetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Vml.Office.FieldCodes");
  }
  
  public static void SetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
