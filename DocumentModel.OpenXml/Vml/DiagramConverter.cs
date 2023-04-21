namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Diagram openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVO.Diagram openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  private static Int64? GetStyle(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVO.Diagram openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Style?.Value == value) return true;
    diffs?.Add(objName, "Style", openXmlElement?.Style?.Value, value);
    return false;
  }
  
  private static void SetStyle(DXVO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.Style = value;
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  private static Boolean? GetAutoFormat(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.AutoFormat?.Value;
  }
  
  private static bool CmpAutoFormat(DXVO.Diagram openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AutoFormat?.Value == value) return true;
    diffs?.Add(objName, "AutoFormat", openXmlElement?.AutoFormat?.Value, value);
    return false;
  }
  
  private static void SetAutoFormat(DXVO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoFormat = value;
    else
      openXmlElement.AutoFormat = null;
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  private static Boolean? GetReverse(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.Reverse?.Value;
  }
  
  private static bool CmpReverse(DXVO.Diagram openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Reverse?.Value == value) return true;
    diffs?.Add(objName, "Reverse", openXmlElement?.Reverse?.Value, value);
    return false;
  }
  
  private static void SetReverse(DXVO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Reverse = value;
    else
      openXmlElement.Reverse = null;
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  private static Boolean? GetAutoLayout(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.AutoLayout?.Value;
  }
  
  private static bool CmpAutoLayout(DXVO.Diagram openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AutoLayout?.Value == value) return true;
    diffs?.Add(objName, "AutoLayout", openXmlElement?.AutoLayout?.Value, value);
    return false;
  }
  
  private static void SetAutoLayout(DXVO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoLayout = value;
    else
      openXmlElement.AutoLayout = null;
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  private static Int64? GetScaleX(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.ScaleX?.Value;
  }
  
  private static bool CmpScaleX(DXVO.Diagram openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ScaleX?.Value == value) return true;
    diffs?.Add(objName, "ScaleX", openXmlElement?.ScaleX?.Value, value);
    return false;
  }
  
  private static void SetScaleX(DXVO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleX = value;
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  private static Int64? GetScaleY(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.ScaleY?.Value;
  }
  
  private static bool CmpScaleY(DXVO.Diagram openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ScaleY?.Value == value) return true;
    diffs?.Add(objName, "ScaleY", openXmlElement?.ScaleY?.Value, value);
    return false;
  }
  
  private static void SetScaleY(DXVO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleY = value;
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  private static Int64? GetFontSize(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }
  
  private static bool CmpFontSize(DXVO.Diagram openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FontSize?.Value == value) return true;
    diffs?.Add(objName, "FontSize", openXmlElement?.FontSize?.Value, value);
    return false;
  }
  
  private static void SetFontSize(DXVO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  private static String? GetConstrainBounds(DXVO.Diagram openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ConstrainBounds);
  }
  
  private static bool CmpConstrainBounds(DXVO.Diagram openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ConstrainBounds, value, diffs, objName, "ConstrainBounds");
  }
  
  private static void SetConstrainBounds(DXVO.Diagram openXmlElement, String? value)
  {
    openXmlElement.ConstrainBounds = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  private static Int64? GetBaseTextScale(DXVO.Diagram openXmlElement)
  {
    return openXmlElement?.BaseTextScale?.Value;
  }
  
  private static bool CmpBaseTextScale(DXVO.Diagram openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BaseTextScale?.Value == value) return true;
    diffs?.Add(objName, "BaseTextScale", openXmlElement?.BaseTextScale?.Value, value);
    return false;
  }
  
  private static void SetBaseTextScale(DXVO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.BaseTextScale = value;
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  private static DMV.RelationTable? GetRelationTable(DXVO.Diagram openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.RelationTable>();
    if (element != null)
      return DMXV.RelationTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelationTable(DXVO.Diagram openXmlElement, DMV.RelationTable? value, DiffList? diffs, string? objName)
  {
    return DMXV.RelationTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.RelationTable>(), value, diffs, objName);
  }
  
  private static void SetRelationTable(DXVO.Diagram openXmlElement, DMV.RelationTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.RelationTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RelationTableConverter.CreateOpenXmlElement<DXVO.RelationTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Diagram? CreateModelElement(DXVO.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Diagram();
      value.Extension = GetExtension(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.AutoFormat = GetAutoFormat(openXmlElement);
      value.Reverse = GetReverse(openXmlElement);
      value.AutoLayout = GetAutoLayout(openXmlElement);
      value.ScaleX = GetScaleX(openXmlElement);
      value.ScaleY = GetScaleY(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.ConstrainBounds = GetConstrainBounds(openXmlElement);
      value.BaseTextScale = GetBaseTextScale(openXmlElement);
      value.RelationTable = GetRelationTable(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.Diagram? openXmlElement, DMV.Diagram? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpAutoFormat(openXmlElement, value.AutoFormat, diffs, objName))
        ok = false;
      if (!CmpReverse(openXmlElement, value.Reverse, diffs, objName))
        ok = false;
      if (!CmpAutoLayout(openXmlElement, value.AutoLayout, diffs, objName))
        ok = false;
      if (!CmpScaleX(openXmlElement, value.ScaleX, diffs, objName))
        ok = false;
      if (!CmpScaleY(openXmlElement, value.ScaleY, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpConstrainBounds(openXmlElement, value.ConstrainBounds, diffs, objName))
        ok = false;
      if (!CmpBaseTextScale(openXmlElement, value.BaseTextScale, diffs, objName))
        ok = false;
      if (!CmpRelationTable(openXmlElement, value.RelationTable, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Diagram value)
    where OpenXmlElementType: DXVO.Diagram, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Diagram openXmlElement, DMV.Diagram value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetStyle(openXmlElement, value?.Style);
    SetAutoFormat(openXmlElement, value?.AutoFormat);
    SetReverse(openXmlElement, value?.Reverse);
    SetAutoLayout(openXmlElement, value?.AutoLayout);
    SetScaleX(openXmlElement, value?.ScaleX);
    SetScaleY(openXmlElement, value?.ScaleY);
    SetFontSize(openXmlElement, value?.FontSize);
    SetConstrainBounds(openXmlElement, value?.ConstrainBounds);
    SetBaseTextScale(openXmlElement, value?.BaseTextScale);
    SetRelationTable(openXmlElement, value?.RelationTable);
  }
}
