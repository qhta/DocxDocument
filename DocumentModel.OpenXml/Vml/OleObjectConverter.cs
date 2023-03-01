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
  
  private static bool CmpType(DXVmlO.OleObject openXmlElement, DMVml.OleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMVml.OleKind>(openXmlElement?.Type?.Value, value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.ProgId);
  }
  
  private static bool CmpProgId(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProgId, value, diffs, objName, "ProgId");
  }
  
  private static void SetProgId(DXVmlO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ProgId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  private static String? GetShapeId(DXVmlO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXVmlO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  private static DMVml.OleDrawAspectKind? GetDrawAspect(DXVmlO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMVml.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }
  
  private static bool CmpDrawAspect(DXVmlO.OleObject openXmlElement, DMVml.OleDrawAspectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMVml.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value, value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.ObjectId);
  }
  
  private static bool CmpObjectId(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ObjectId, value, diffs, objName, "ObjectId");
  }
  
  private static void SetObjectId(DXVmlO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ObjectId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetId(DXVmlO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVmlO.OleObject openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  private static DMVml.OleUpdateMode? GetUpdateMode(DXVmlO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMVml.OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static bool CmpUpdateMode(DXVmlO.OleObject openXmlElement, DMVml.OleUpdateMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMVml.OleUpdateMode>(openXmlElement?.UpdateMode?.Value, value, diffs, objName);
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
      return openXmlElement?.GetFirstChild<DXVmlO.LinkType>()?.Text;
  }
  
  private static bool CmpLinkType(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVmlO.LinkType>()?.Text == value;
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
      return openXmlElement?.GetFirstChild<DXVmlO.LockedField>()?.Text;
  }
  
  private static bool CmpLockedField(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVmlO.LockedField>()?.Text == value;
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
      return openXmlElement?.GetFirstChild<DXVmlO.FieldCodes>()?.Text;
  }
  
  private static bool CmpFieldCodes(DXVmlO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVmlO.FieldCodes>()?.Text == value;
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
  
  public static DocumentModel.Vml.OleObject? CreateModelElement(DXVmlO.OleObject? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlO.OleObject? openXmlElement, DMVml.OleObject? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpProgId(openXmlElement, value.ProgId, diffs, objName))
        ok = false;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      if (!CmpDrawAspect(openXmlElement, value.DrawAspect, diffs, objName))
        ok = false;
      if (!CmpObjectId(openXmlElement, value.ObjectId, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpUpdateMode(openXmlElement, value.UpdateMode, diffs, objName))
        ok = false;
      if (!CmpLinkType(openXmlElement, value.LinkType, diffs, objName))
        ok = false;
      if (!CmpLockedField(openXmlElement, value.LockedField, diffs, objName))
        ok = false;
      if (!CmpFieldCodes(openXmlElement, value.FieldCodes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.OleObject value)
    where OpenXmlElementType: DXVmlO.OleObject, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.OleObject openXmlElement, DMVml.OleObject value)
  {
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
  }
}
