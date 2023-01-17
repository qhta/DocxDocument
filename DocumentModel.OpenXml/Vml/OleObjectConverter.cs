namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public static class OleObjectConverter
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  private static DocumentModel.Vml.OleKind? GetType(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DocumentModel.Vml.OleKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, DocumentModel.Vml.OleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues, DocumentModel.Vml.OleKind>(value);
  }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  private static String? GetProgId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static void SetProgId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  private static String? GetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  private static DocumentModel.Vml.OleDrawAspectKind? GetDrawAspect(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DocumentModel.Vml.OleDrawAspectKind>(openXmlElement?.DrawAspect?.Value);
  }
  
  private static void SetDrawAspect(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, DocumentModel.Vml.OleDrawAspectKind? value)
  {
    openXmlElement.DrawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues, DocumentModel.Vml.OleDrawAspectKind>(value);
  }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  private static String? GetObjectId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return openXmlElement?.ObjectId?.Value;
  }
  
  private static void SetObjectId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ObjectId = new StringValue { Value = value };
    else
      openXmlElement.ObjectId = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  private static DocumentModel.Vml.OleUpdateMode? GetUpdateMode(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DocumentModel.Vml.OleUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static void SetUpdateMode(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, DocumentModel.Vml.OleUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues, DocumentModel.Vml.OleUpdateMode>(value);
  }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  private static String? GetLinkType(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LinkType>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLinkType(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LinkType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Vml.Office.LinkType { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  private static String? GetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LockedField>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLockedField(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LockedField>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Vml.Office.LockedField { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  private static String? GetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FieldCodes>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFieldCodes(DocumentFormat.OpenXml.Vml.Office.OleObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FieldCodes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Vml.Office.FieldCodes { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.OleObject? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.OleObject? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.OleObject, new()
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
