namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public static class OleObjectConverter
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  private static DMV.OleKind? GetType(DXVO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMV.OleKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVO.OleObject openXmlElement, DMV.OleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMV.OleKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXVO.OleObject openXmlElement, DMV.OleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DMV.OleKind>(value);
  }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  private static String? GetProgId(DXVO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProgId);
  }
  
  private static bool CmpProgId(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProgId, value, diffs, objName, "ProgId");
  }
  
  private static void SetProgId(DXVO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ProgId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  private static String? GetShapeId(DXVO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXVO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  private static DMV.OleDrawAspectKind? GetDrawAspect(DXVO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMV.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }
  
  private static bool CmpDrawAspect(DXVO.OleObject openXmlElement, DMV.OleDrawAspectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMV.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value, value, diffs, objName);
  }
  
  private static void SetDrawAspect(DXVO.OleObject openXmlElement, DMV.OleDrawAspectKind? value)
  {
    openXmlElement.DrawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DMV.OleDrawAspectKind>(value);
  }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  private static String? GetObjectId(DXVO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ObjectId);
  }
  
  private static bool CmpObjectId(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ObjectId, value, diffs, objName, "ObjectId");
  }
  
  private static void SetObjectId(DXVO.OleObject openXmlElement, String? value)
  {
    openXmlElement.ObjectId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetId(DXVO.OleObject openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXVO.OleObject openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  private static DMV.OleUpdateMode? GetUpdateMode(DXVO.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMV.OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static bool CmpUpdateMode(DXVO.OleObject openXmlElement, DMV.OleUpdateMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMV.OleUpdateMode>(openXmlElement?.UpdateMode?.Value, value, diffs, objName);
  }
  
  private static void SetUpdateMode(DXVO.OleObject openXmlElement, DMV.OleUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DMV.OleUpdateMode>(value);
  }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  private static String? GetLinkType(DXVO.OleObject openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVO.LinkType>()?.Text;
  }
  
  private static bool CmpLinkType(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVO.LinkType>()?.Text == value;
  }
  
  private static void SetLinkType(DXVO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.LinkType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVO.LinkType { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  private static String? GetLockedField(DXVO.OleObject openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVO.LockedField>()?.Text;
  }
  
  private static bool CmpLockedField(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVO.LockedField>()?.Text == value;
  }
  
  private static void SetLockedField(DXVO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.LockedField>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVO.LockedField { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  private static String? GetFieldCodes(DXVO.OleObject openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVO.FieldCodes>()?.Text;
  }
  
  private static bool CmpFieldCodes(DXVO.OleObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVO.FieldCodes>()?.Text == value;
  }
  
  private static void SetFieldCodes(DXVO.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.FieldCodes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVO.FieldCodes { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.OleObject? CreateModelElement(DXVO.OleObject? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.OleObject? openXmlElement, DMV.OleObject? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.OleObject value)
    where OpenXmlElementType: DXVO.OleObject, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.OleObject openXmlElement, DMV.OleObject value)
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
