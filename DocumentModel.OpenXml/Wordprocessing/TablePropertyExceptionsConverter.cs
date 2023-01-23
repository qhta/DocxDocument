namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
public static class TablePropertyExceptionsConverter
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  private static DMW.TableWidthType? GetTableWidth(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableWidth>());
  }
  
  private static bool CmpTableWidth(DXW.TablePropertyExceptions openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableWidth>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableWidth(DXW.TablePropertyExceptions openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TablePropertyExceptions openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.TablePropertyExceptions openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableJustification(DXW.TablePropertyExceptions openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Spacing Exception.
  /// </summary>
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableCellSpacing>());
  }
  
  private static bool CmpTableCellSpacing(DXW.TablePropertyExceptions openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellSpacing(DXW.TablePropertyExceptions openXmlElement, DMW.TableWidthType? value)
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
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  private static DMW.TableIndentation? GetTableIndentation(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableIndentationConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableIndentation>());
  }
  
  private static bool CmpTableIndentation(DXW.TablePropertyExceptions openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableIndentation(DXW.TablePropertyExceptions openXmlElement, DMW.TableIndentation? value)
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
  /// Table Borders Exceptions.
  /// </summary>
  private static DMW.TableBorders? GetTableBorders(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableBordersConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableBorders>());
  }
  
  private static bool CmpTableBorders(DXW.TablePropertyExceptions openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableBorders(DXW.TablePropertyExceptions openXmlElement, DMW.TableBorders? value)
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
  /// Table Shading Exception.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.ShadingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Shading>());
  }
  
  private static bool CmpShading(DXW.TablePropertyExceptions openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.TablePropertyExceptions openXmlElement, DMW.Shading? value)
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
  /// Table Layout Exception.
  /// </summary>
  private static DMW.TableLayout? GetTableLayout(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableLayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableLayout>());
  }
  
  private static bool CmpTableLayout(DXW.TablePropertyExceptions openXmlElement, DMW.TableLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLayoutConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableLayout(DXW.TablePropertyExceptions openXmlElement, DMW.TableLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLayoutConverter.CreateOpenXmlElement<DXW.TableLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableCellMarginDefaultConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>());
  }
  
  private static bool CmpTableCellMarginDefault(DXW.TablePropertyExceptions openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellMarginDefault(DXW.TablePropertyExceptions openXmlElement, DMW.TableCellMarginDefault? value)
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
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  private static DMW.TableLook? GetTableLook(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TableLookConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableLook>());
  }
  
  private static bool CmpTableLook(DXW.TablePropertyExceptions openXmlElement, DMW.TableLook? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLookConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TableLook>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableLook(DXW.TablePropertyExceptions openXmlElement, DMW.TableLook? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLook>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLookConverter.CreateOpenXmlElement<DXW.TableLook>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  private static DMW.TablePropertyExceptionsChange? GetTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement)
  {
    return DMXW.TablePropertyExceptionsChangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TablePropertyExceptionsChange>());
  }
  
  private static bool CmpTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement, DMW.TablePropertyExceptionsChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertyExceptionsChangeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TablePropertyExceptionsChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement, DMW.TablePropertyExceptionsChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePropertyExceptionsChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertyExceptionsChangeConverter.CreateOpenXmlElement<DXW.TablePropertyExceptionsChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TablePropertyExceptions? CreateModelElement(DXW.TablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertyExceptions();
      value.TableWidth = GetTableWidth(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableLayout = GetTableLayout(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      value.TableLook = GetTableLook(openXmlElement);
      value.TablePropertyExceptionsChange = GetTablePropertyExceptionsChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertyExceptions? openXmlElement, DMW.TablePropertyExceptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableWidth(openXmlElement, value.TableWidth, diffs, objName))
        ok = false;
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
      if (!CmpTableLayout(openXmlElement, value.TableLayout, diffs, objName))
        ok = false;
      if (!CmpTableCellMarginDefault(openXmlElement, value.TableCellMarginDefault, diffs, objName))
        ok = false;
      if (!CmpTableLook(openXmlElement, value.TableLook, diffs, objName))
        ok = false;
      if (!CmpTablePropertyExceptionsChange(openXmlElement, value.TablePropertyExceptionsChange, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertyExceptions? value)
    where OpenXmlElementType: DXW.TablePropertyExceptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableWidth(openXmlElement, value?.TableWidth);
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableLayout(openXmlElement, value?.TableLayout);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      SetTableLook(openXmlElement, value?.TableLook);
      SetTablePropertyExceptionsChange(openXmlElement, value?.TablePropertyExceptionsChange);
      return openXmlElement;
    }
    return default;
  }
}
