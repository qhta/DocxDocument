namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table-Level Property Exceptions.
/// </summary>
public static class PreviousTablePropertyExceptionsConverter
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  private static DMW.TableWidthType? GetTableWidth(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableWidth(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableWidth>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableWidth(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableWidthType? value)
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
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableJustification(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableRowAlignmentKind? value)
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
  /// Table Cell Spacing Exception.
  /// </summary>
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellSpacing(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableWidthType? value)
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
  private static DMW.TableIndentation? GetTableIndentation(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableIndentation(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableIndentation(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableIndentation? value)
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
  private static DMW.TableBorders? GetTableBorders(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableBorders(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableBorders(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableBorders? value)
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
  private static DMW.Shading? GetShading(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.Shading? value)
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
  private static DMW.TableLayout? GetTableLayout(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLayout>();
    if (element != null)
      return DMXW.TableLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLayout(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableLayout(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableLayout? value)
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
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMarginDefault(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellMarginDefault(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableCellMarginDefault? value)
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
  private static DMW.TableLook? GetTableLook(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLook>();
    if (element != null)
      return DMXW.TableLookConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLook(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableLook? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLookConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLook>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableLook(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableLook? value)
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
  
  public static DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? CreateModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousTablePropertyExceptions();
      value.TableWidth = GetTableWidth(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableLayout = GetTableLayout(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      value.TableLook = GetTableLook(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement, DMW.PreviousTablePropertyExceptions? value, DiffList? diffs, string? objName)
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTablePropertyExceptions value)
    where OpenXmlElementType: DXW.PreviousTablePropertyExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.PreviousTablePropertyExceptions value)
  {
    SetTableWidth(openXmlElement, value?.TableWidth);
    SetTableJustification(openXmlElement, value?.TableJustification);
    SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
    SetTableIndentation(openXmlElement, value?.TableIndentation);
    SetTableBorders(openXmlElement, value?.TableBorders);
    SetShading(openXmlElement, value?.Shading);
    SetTableLayout(openXmlElement, value?.TableLayout);
    SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
    SetTableLook(openXmlElement, value?.TableLook);
  }
}
