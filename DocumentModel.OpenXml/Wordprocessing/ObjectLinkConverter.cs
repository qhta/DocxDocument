namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public static class ObjectLinkConverter
{
  /// <summary>
  /// updateMode
  /// </summary>
  public static DocumentModel.Wordprocessing.ObjectUpdateMode? GetUpdateMode(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DocumentModel.Wordprocessing.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  public static void SetUpdateMode(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, DocumentModel.Wordprocessing.ObjectUpdateMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DocumentModel.Wordprocessing.ObjectUpdateMode>(value);
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  public static Boolean? GetLockedField(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLockedField(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public static DocumentModel.Wordprocessing.ObjectDrawAspect? GetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  public static void SetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, DocumentModel.Wordprocessing.ObjectDrawAspect? value)
  {
    if (openXmlElement != null)
      openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public static String? GetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public static String? GetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
