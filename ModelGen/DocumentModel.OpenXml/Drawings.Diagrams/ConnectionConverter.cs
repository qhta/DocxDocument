namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection.
/// </summary>
public static class ConnectionConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ModelId);
  }
  
  private static bool CmpModelId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ModelId, value, diffs, objName, "ModelId");
  }
  
  private static void SetModelId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.ModelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  private static DMDrawsDgms.ConnectionKind? GetType(DXDrawDgms.Connection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DMDrawsDgms.ConnectionKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDrawDgms.Connection openXmlElement, DMDrawsDgms.ConnectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DMDrawsDgms.ConnectionKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDrawDgms.Connection openXmlElement, DMDrawsDgms.ConnectionKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DMDrawsDgms.ConnectionKind>(value);
  }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  private static String? GetSourceId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SourceId);
  }
  
  private static bool CmpSourceId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SourceId, value, diffs, objName, "SourceId");
  }
  
  private static void SetSourceId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.SourceId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  private static String? GetDestinationId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DestinationId);
  }
  
  private static bool CmpDestinationId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DestinationId, value, diffs, objName, "DestinationId");
  }
  
  private static void SetDestinationId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.DestinationId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  private static UInt32? GetSourcePosition(DXDrawDgms.Connection openXmlElement)
  {
    return openXmlElement?.SourcePosition?.Value;
  }
  
  private static bool CmpSourcePosition(DXDrawDgms.Connection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SourcePosition?.Value == value) return true;
    diffs?.Add(objName, "SourcePosition", openXmlElement?.SourcePosition?.Value, value);
    return false;
  }
  
  private static void SetSourcePosition(DXDrawDgms.Connection openXmlElement, UInt32? value)
  {
    openXmlElement.SourcePosition = value;
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  private static UInt32? GetDestinationPosition(DXDrawDgms.Connection openXmlElement)
  {
    return openXmlElement?.DestinationPosition?.Value;
  }
  
  private static bool CmpDestinationPosition(DXDrawDgms.Connection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DestinationPosition?.Value == value) return true;
    diffs?.Add(objName, "DestinationPosition", openXmlElement?.DestinationPosition?.Value, value);
    return false;
  }
  
  private static void SetDestinationPosition(DXDrawDgms.Connection openXmlElement, UInt32? value)
  {
    openXmlElement.DestinationPosition = value;
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  private static String? GetParentTransitionId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ParentTransitionId);
  }
  
  private static bool CmpParentTransitionId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ParentTransitionId, value, diffs, objName, "ParentTransitionId");
  }
  
  private static void SetParentTransitionId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.ParentTransitionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  private static String? GetSiblingTransitionId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SiblingTransitionId);
  }
  
  private static bool CmpSiblingTransitionId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SiblingTransitionId, value, diffs, objName, "SiblingTransitionId");
  }
  
  private static void SetSiblingTransitionId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.SiblingTransitionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  private static String? GetPresentationId(DXDrawDgms.Connection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PresentationId);
  }
  
  private static bool CmpPresentationId(DXDrawDgms.Connection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PresentationId, value, diffs, objName, "PresentationId");
  }
  
  private static void SetPresentationId(DXDrawDgms.Connection openXmlElement, String? value)
  {
    openXmlElement.PresentationId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Connection openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Connection openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.Connection openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Connection? CreateModelElement(DXDrawDgms.Connection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Connection();
      value.ModelId = GetModelId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.SourceId = GetSourceId(openXmlElement);
      value.DestinationId = GetDestinationId(openXmlElement);
      value.SourcePosition = GetSourcePosition(openXmlElement);
      value.DestinationPosition = GetDestinationPosition(openXmlElement);
      value.ParentTransitionId = GetParentTransitionId(openXmlElement);
      value.SiblingTransitionId = GetSiblingTransitionId(openXmlElement);
      value.PresentationId = GetPresentationId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Connection? openXmlElement, DMDrawsDgms.Connection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModelId(openXmlElement, value.ModelId, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpSourceId(openXmlElement, value.SourceId, diffs, objName))
        ok = false;
      if (!CmpDestinationId(openXmlElement, value.DestinationId, diffs, objName))
        ok = false;
      if (!CmpSourcePosition(openXmlElement, value.SourcePosition, diffs, objName))
        ok = false;
      if (!CmpDestinationPosition(openXmlElement, value.DestinationPosition, diffs, objName))
        ok = false;
      if (!CmpParentTransitionId(openXmlElement, value.ParentTransitionId, diffs, objName))
        ok = false;
      if (!CmpSiblingTransitionId(openXmlElement, value.SiblingTransitionId, diffs, objName))
        ok = false;
      if (!CmpPresentationId(openXmlElement, value.PresentationId, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Connection value)
    where OpenXmlElementType: DXDrawDgms.Connection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Connection openXmlElement, DMDrawsDgms.Connection value)
  {
    SetModelId(openXmlElement, value?.ModelId);
    SetType(openXmlElement, value?.Type);
    SetSourceId(openXmlElement, value?.SourceId);
    SetDestinationId(openXmlElement, value?.DestinationId);
    SetSourcePosition(openXmlElement, value?.SourcePosition);
    SetDestinationPosition(openXmlElement, value?.DestinationPosition);
    SetParentTransitionId(openXmlElement, value?.ParentTransitionId);
    SetSiblingTransitionId(openXmlElement, value?.SiblingTransitionId);
    SetPresentationId(openXmlElement, value?.PresentationId);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
