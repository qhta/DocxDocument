namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetRelationshipId(DXO10DCD.ContentPart openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXO10DCD.ContentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXO10DCD.ContentPart openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMD.BlackWhiteMode? GetBlackWhiteMode(DXO10DCD.ContentPart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXO10DCD.ContentPart openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXO10DCD.ContentPart openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  private static DMDCDs.NonVisualContentPartProperties? GetNonVisualContentPartProperties(DXO10DCD.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.NonVisualContentPartProperties>();
    if (element != null)
      return DMXDCDs.NonVisualContentPartPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualContentPartProperties(DXO10DCD.ContentPart openXmlElement, DMDCDs.NonVisualContentPartProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.NonVisualContentPartPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.NonVisualContentPartProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualContentPartProperties(DXO10DCD.ContentPart openXmlElement, DMDCDs.NonVisualContentPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.NonVisualContentPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NonVisualContentPartPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualContentPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  private static DMDCDs.ApplicationNonVisualDrawingProperties? GetApplicationNonVisualDrawingProperties(DXO10DCD.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.ApplicationNonVisualDrawingProperties>();
    if (element != null)
      return DMXDCDs.ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpApplicationNonVisualDrawingProperties(DXO10DCD.ContentPart openXmlElement, DMDCDs.ApplicationNonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ApplicationNonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.ApplicationNonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetApplicationNonVisualDrawingProperties(DXO10DCD.ContentPart openXmlElement, DMDCDs.ApplicationNonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.ApplicationNonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ApplicationNonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO10DCD.ApplicationNonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  private static DMDCDs.Transform2D? GetTransform2D(DXO10DCD.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.Transform2D>();
    if (element != null)
      return DMXDCDs.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXO10DCD.ContentPart openXmlElement, DMDCDs.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.Transform2D>(), value, diffs, objName);
  }
  
  private static void SetTransform2D(DXO10DCD.ContentPart openXmlElement, DMDCDs.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.Transform2DConverter.CreateOpenXmlElement<DXO10DCD.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDCDs.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO10DCD.ContentPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.OfficeArtExtensionList>();
    if (element != null)
      return DMXDCDs.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO10DCD.ContentPart openXmlElement, DMDCDs.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO10DCD.ContentPart openXmlElement, DMDCDs.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO10DCD.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ContentPart? CreateModelElement(DXO10DCD.ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ContentPart();
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.NonVisualContentPartProperties = GetNonVisualContentPartProperties(openXmlElement);
      value.ApplicationNonVisualDrawingProperties = GetApplicationNonVisualDrawingProperties(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10DCD.ContentPart? openXmlElement, DMDCDs.ContentPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpNonVisualContentPartProperties(openXmlElement, value.NonVisualContentPartProperties, diffs, objName))
        ok = false;
      if (!CmpApplicationNonVisualDrawingProperties(openXmlElement, value.ApplicationNonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, value.Transform2D, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ContentPart value)
    where OpenXmlElementType: DXO10DCD.ContentPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DCD.ContentPart openXmlElement, DMDCDs.ContentPart value)
  {
    SetRelationshipId(openXmlElement, value?.RelationshipId);
    SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
    SetNonVisualContentPartProperties(openXmlElement, value?.NonVisualContentPartProperties);
    SetApplicationNonVisualDrawingProperties(openXmlElement, value?.ApplicationNonVisualDrawingProperties);
    SetTransform2D(openXmlElement, value?.Transform2D);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
