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
    return openXmlElement?.LockedField?.Value;
  }
  
  public static void SetLockedField(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockedField = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LockedField = null;
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
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public static String? GetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  public static void SetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProgId = new StringValue { Value = value };
      else
        openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public static String? GetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }
  
  public static void SetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
