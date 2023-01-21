namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public static class OleObjectConverter
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  private static DMVml.OleKind? GetType(DXVmlO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMVml.OleKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVmlO.OleObject openXmlElement, DMVml.OleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMVml.OleKind>(value);
  }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  private static String? GetProgId(DXVmlO.OleObject openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static void SetProgId(DXVmlO.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  private static String? GetShapeId(DXVmlO.OleObject openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DXVmlO.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  private static DMVml.OleDrawAspectKind? GetDrawAspect(DXVmlO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMVml.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }
  
  private static void SetDrawAspect(DXVmlO.OleObject openXmlElement, DMVml.OleDrawAspectKind? value)
  {
    openXmlElement.DrawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMVml.OleDrawAspectKind>(value);
  }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  private static String? GetObjectId(DXVmlO.OleObject openXmlElement)
  {
    return openXmlElement?.ObjectId?.Value;
  }
  
  private static void SetObjectId(DXVmlO.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ObjectId = new StringValue { Value = value };
    else
      openXmlElement.ObjectId = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetId(DXVmlO.OleObject openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVmlO.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  private static DMVml.OleUpdateMode? GetUpdateMode(DXVmlO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMVml.OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static void SetUpdateMode(DXVmlO.OleObject openXmlElement, DMVml.OleUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMVml.OleUpdateMode>(value);
  }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  private static String? GetLinkType(DXVmlO.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.LinkType>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLinkType(DXVmlO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.LinkType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVmlO.LinkType { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  private static String? GetLockedField(DXVmlO.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.LockedField>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLockedField(DXVmlO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.LockedField>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVmlO.LockedField { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  private static String? GetFieldCodes(DXVmlO.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.FieldCodes>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFieldCodes(DXVmlO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.FieldCodes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVmlO.FieldCodes { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.OleObject? CreateModelElement(DXVmlO.OleObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.OleObject();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.OleObject? value)
    where OpenXmlElementType: DXVmlO.OleObject, new()
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
