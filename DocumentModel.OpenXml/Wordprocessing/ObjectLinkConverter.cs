namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public static class ObjectLinkConverter
{
  /// <summary>
  /// updateMode
  /// </summary>
  private static DMW.ObjectUpdateMode? GetUpdateMode(DXW.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DMW.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static void SetUpdateMode(DXW.ObjectLink openXmlElement, DMW.ObjectUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DMW.ObjectUpdateMode>(value);
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  private static Boolean? GetLockedField(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.LockedField?.Value;
  }
  
  private static void SetLockedField(DXW.ObjectLink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedField = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LockedField = null;
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DMW.ObjectDrawAspect? GetdrawAspect(DXW.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static void SetdrawAspect(DXW.ObjectLink openXmlElement, DMW.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static void SetProgId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }
  
  private static void SetFieldCodes(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FieldCodes = new StringValue { Value = value };
    else
      openXmlElement.FieldCodes = null;
  }
  
  public static DMW.ObjectLink? CreateModelElement(DXW.ObjectLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ObjectLink();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ObjectLink? value)
    where OpenXmlElementType: DXW.ObjectLink, new()
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
