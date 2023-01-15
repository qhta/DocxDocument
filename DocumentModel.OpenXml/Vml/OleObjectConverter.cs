using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using OleObject = DocumentFormat.OpenXml.Vml.Office.OleObject;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Embedded OLE Object.
/// </summary>
public static class OleObjectConverter
{
  /// <summary>
  ///   OLE Object Type
  /// </summary>
  public static OleKind? GetType(OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<OleValues, OleKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(OleObject? openXmlElement, OleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<OleValues, OleKind>(value);
  }

  /// <summary>
  ///   OLE Object Application
  /// </summary>
  public static String? GetProgId(OleObject? openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }

  public static void SetProgId(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProgId = new StringValue { Value = value };
      else
        openXmlElement.ProgId = null;
  }

  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  public static String? GetShapeId(OleObject? openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }

  public static void SetShapeId(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }

  /// <summary>
  ///   OLE Object Representation
  /// </summary>
  public static OleDrawAspectKind? GetDrawAspect(OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<OleDrawAspectValues, OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }

  public static void SetDrawAspect(OleObject? openXmlElement, OleDrawAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DrawAspect = EnumValueConverter.CreateEnumValue<OleDrawAspectValues, OleDrawAspectKind>(value);
  }

  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  public static String? GetObjectId(OleObject? openXmlElement)
  {
    return openXmlElement?.ObjectId?.Value;
  }

  public static void SetObjectId(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ObjectId = new StringValue { Value = value };
      else
        openXmlElement.ObjectId = null;
  }

  /// <summary>
  ///   Relationship
  /// </summary>
  public static String? GetId(OleObject? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   OLE Update Mode
  /// </summary>
  public static OleUpdateMode? GetUpdateMode(OleObject? openXmlElement)
  {
    return EnumValueConverter.GetValue<OleUpdateModeValues, OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }

  public static void SetUpdateMode(OleObject? openXmlElement, OleUpdateMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<OleUpdateModeValues, OleUpdateMode>(value);
  }

  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public static String? GetLinkType(OleObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LinkType>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetLinkType(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LinkType { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public static String? GetLockedField(OleObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LockedField>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetLockedField(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LockedField>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LockedField { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public static String? GetFieldCodes(OleObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FieldCodes>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFieldCodes(OleObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FieldCodes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FieldCodes { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.OleObject? CreateModelElement(OleObject? openXmlElement)
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
    where OpenXmlElementType : OleObject, new()
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