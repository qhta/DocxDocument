using DocumentModel.Wordprocessing;
using ObjectLink = DocumentFormat.OpenXml.Wordprocessing.ObjectLink;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ObjectLink Class.
/// </summary>
public static class ObjectLinkConverter
{
  /// <summary>
  ///   updateMode
  /// </summary>
  public static ObjectUpdateMode? GetUpdateMode(ObjectLink? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }

  public static void SetUpdateMode(ObjectLink? openXmlElement, ObjectUpdateMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, ObjectUpdateMode>(value);
  }

  /// <summary>
  ///   lockedField
  /// </summary>
  public static Boolean? GetLockedField(ObjectLink? openXmlElement)
  {
    return openXmlElement?.LockedField?.Value;
  }

  public static void SetLockedField(ObjectLink? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockedField = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LockedField = null;
  }

  /// <summary>
  ///   drawAspect
  /// </summary>
  public static ObjectDrawAspect? GetdrawAspect(ObjectLink? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }

  public static void SetdrawAspect(ObjectLink? openXmlElement, ObjectDrawAspect? value)
  {
    if (openXmlElement != null)
      openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, ObjectDrawAspect>(value);
  }

  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(ObjectLink? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   progId
  /// </summary>
  public static String? GetProgId(ObjectLink? openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }

  public static void SetProgId(ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProgId = new StringValue { Value = value };
      else
        openXmlElement.ProgId = null;
  }

  /// <summary>
  ///   shapeId
  /// </summary>
  public static String? GetShapeId(ObjectLink? openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }

  public static void SetShapeId(ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }

  /// <summary>
  ///   fieldCodes
  /// </summary>
  public static String? GetFieldCodes(ObjectLink? openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }

  public static void SetFieldCodes(ObjectLink? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FieldCodes = new StringValue { Value = value };
      else
        openXmlElement.FieldCodes = null;
  }

  public static DocumentModel.Wordprocessing.ObjectLink? CreateModelElement(ObjectLink? openXmlElement)
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
    where OpenXmlElementType : ObjectLink, new()
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