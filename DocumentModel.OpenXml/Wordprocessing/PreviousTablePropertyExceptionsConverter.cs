namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table-Level Property Exceptions.
/// </summary>
public static class PreviousTablePropertyExceptionsConverter
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthType? GetTableWidth(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableWidth(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Spacing Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableIndentation? GetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableIndentationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableIndentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableIndentationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableBorders? GetTableBorders(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableBorders(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableLayout? GetTableLayout(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableLayout(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellMarginDefault? GetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableCellMarginDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellMarginDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableLook? GetTableLook(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableLookConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableLook(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement, DocumentModel.Wordprocessing.TableLook? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableLookConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableLook>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions, new()
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
