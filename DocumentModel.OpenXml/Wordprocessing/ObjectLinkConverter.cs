namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public static class ObjectLinkConverter
{
  /// <summary>
  /// updateMode
  /// </summary>
  private static DocumentModel.Wordprocessing.ObjectUpdateMode? GetUpdateMode(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DocumentModel.Wordprocessing.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static void SetUpdateMode(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, DocumentModel.Wordprocessing.ObjectUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DocumentModel.Wordprocessing.ObjectUpdateMode>(value);
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  private static Boolean? GetLockedField(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return openXmlElement?.LockedField?.Value;
  }
  
  private static void SetLockedField(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedField = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LockedField = null;
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DocumentModel.Wordprocessing.ObjectDrawAspect? GetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static void SetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, DocumentModel.Wordprocessing.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static void SetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }
  
  private static void SetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FieldCodes = new StringValue { Value = value };
    else
      openXmlElement.FieldCodes = null;
  }
  
  public static DocumentModel.Wordprocessing.ObjectLink? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ObjectLink();
      value.UpdateMode = GetUpdateMode(openXmlElement);
      value.LockedField = GetLockedField(openXmlElement);
      value.drawAspect = GetdrawAspect(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ProgId = GetProgId(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.FieldCodes = GetFieldCodes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ObjectLink? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ObjectLink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUpdateMode(openXmlElement, value?.UpdateMode);
      SetLockedField(openXmlElement, value?.LockedField);
      SetdrawAspect(openXmlElement, value?.drawAspect);
      SetId(openXmlElement, value?.Id);
      SetProgId(openXmlElement, value?.ProgId);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetFieldCodes(openXmlElement, value?.FieldCodes);
      return openXmlElement;
    }
    return default;
  }
}
