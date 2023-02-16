namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public static class StyleTablePropertiesConverter
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  private static Int32? GetTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.TableStyleRowBandSize>()?.Val?.Value;
  }
  
  private static bool CmpTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleRowBandSize>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.TableStyleRowBandSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleRowBandSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableStyleRowBandSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  private static Int32? GetTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.TableStyleColumnBandSize>()?.Val?.Value;
  }
  
  private static bool CmpTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleColumnBandSize>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.TableStyleColumnBandSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleColumnBandSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableStyleColumnBandSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.StyleTableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.StyleTableProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableJustification(DXW.StyleTableProperties openXmlElement, DMW.TableRowAlignmentKind? value)
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
  /// TableCellSpacing.
  /// </summary>
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.StyleTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.StyleTableProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellSpacing(DXW.StyleTableProperties openXmlElement, DMW.TableWidthType? value)
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
  private static DMW.TableIndentation? GetTableIndentation(DXW.StyleTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableIndentation(DXW.StyleTableProperties openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableIndentation(DXW.StyleTableProperties openXmlElement, DMW.TableIndentation? value)
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
  private static DMW.TableBorders? GetTableBorders(DXW.StyleTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableBorders(DXW.StyleTableProperties openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableBorders(DXW.StyleTableProperties openXmlElement, DMW.TableBorders? value)
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
  private static DMW.Shading? GetShading(DXW.StyleTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.StyleTableProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.StyleTableProperties openXmlElement, DMW.Shading? value)
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
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.StyleTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMarginDefault(DXW.StyleTableProperties openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellMarginDefault(DXW.StyleTableProperties openXmlElement, DMW.TableCellMarginDefault? value)
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
  
  public static DocumentModel.Wordprocessing.StyleTableProperties? CreateModelElement(DXW.StyleTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleTableProperties();
      value.TableStyleRowBandSize = GetTableStyleRowBandSize(openXmlElement);
      value.TableStyleColumnBandSize = GetTableStyleColumnBandSize(openXmlElement);
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
  
  public static bool CompareModelElement(DXW.StyleTableProperties? openXmlElement, DMW.StyleTableProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableStyleRowBandSize(openXmlElement, value.TableStyleRowBandSize, diffs, objName))
        ok = false;
      if (!CmpTableStyleColumnBandSize(openXmlElement, value.TableStyleColumnBandSize, diffs, objName))
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
      if (!CmpTableCellMarginDefault(openXmlElement, value.TableCellMarginDefault, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleTableProperties? value)
    where OpenXmlElementType: DXW.StyleTableProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableStyleRowBandSize(openXmlElement, value?.TableStyleRowBandSize);
      SetTableStyleColumnBandSize(openXmlElement, value?.TableStyleColumnBandSize);
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      return openXmlElement;
    }
    return default;
  }
}
