namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Properties.
/// </summary>
public static class TableStyleConditionalFormattingTablePropertiesConverter
{
  /// <summary>
  /// TableJustification.
  /// </summary>
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableJustification(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  private static DMW.TableWidth? GetTableCellSpacing(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }
  
  private static void SetTableCellSpacing(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  private static DMW.TableIndentation? GetTableIndentation(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableIndentation(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName);
  }
  
  private static void SetTableIndentation(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableIndentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableIndentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableIndentationConverter.CreateOpenXmlElement<DXW.TableIndentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  private static DMW.TableBorders? GetTableBorders(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableBorders(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName);
  }
  
  private static void SetTableBorders(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableBordersConverter.CreateOpenXmlElement<DXW.TableBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMarginDefault(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName);
  }
  
  private static void SetTableCellMarginDefault(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableCellMarginDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginDefaultConverter.CreateOpenXmlElement<DXW.TableCellMarginDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableStyleConditionalTableProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableStyleConditionalTableProperties();
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableProperties? openXmlElement, DMW.TableStyleConditionalTableProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableJustification(openXmlElement, value.TableJustification, diffs, objName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, value.TableCellSpacing, diffs, objName))
        ok = false;
      if (!CmpTableIndentation(openXmlElement, value.TableIndentation, diffs, objName))
        ok = false;
      if (!CmpTableBorders(openXmlElement, value.TableBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpTableCellMarginDefault(openXmlElement, value.TableCellMarginDefault, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalTableProperties value)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableStyleConditionalTableProperties value)
  {
    SetTableJustification(openXmlElement, value?.TableJustification);
    SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
    SetTableIndentation(openXmlElement, value?.TableIndentation);
    SetTableBorders(openXmlElement, value?.TableBorders);
    SetShading(openXmlElement, value?.Shading);
    SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
  }
}
