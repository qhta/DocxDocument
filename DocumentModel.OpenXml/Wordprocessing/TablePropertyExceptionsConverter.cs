namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
public static class TablePropertyExceptionsConverter
{
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableWidth(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableWidth(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Alignment Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Table Cell Spacing Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableIndentation? GetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableIndentation? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableBorders? GetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableBorders? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableLayout? GetTableLayout(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableLayout(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableLayout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableCellMarginDefault? GetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableCellMarginDefault? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableLook? GetTableLook(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableLook(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TableLook? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public static DocumentModel.Wordprocessing.TablePropertyExceptionsChange? GetTablePropertyExceptionsChange(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTablePropertyExceptionsChange(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? openXmlElement, DocumentModel.Wordprocessing.TablePropertyExceptionsChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
