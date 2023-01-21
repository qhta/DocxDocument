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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableWidth>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableJustification(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.TableRowAlignmentKind? value)
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
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (itemElement != null)
      return DMXW.TableIndentationConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (itemElement != null)
      return DMXW.TableBordersConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      return DMXW.ShadingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableLayout>();
    if (itemElement != null)
      return DMXW.TableLayoutConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (itemElement != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableLook>();
    if (itemElement != null)
      return DMXW.TableLookConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.PreviousTablePropertyExceptions? CreateModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTablePropertyExceptions();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTablePropertyExceptions? value)
    where OpenXmlElementType: DXW.PreviousTablePropertyExceptions, new()
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
      return openXmlElement;
    }
    return default;
  }
}
