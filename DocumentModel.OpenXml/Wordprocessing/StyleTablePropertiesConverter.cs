namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public static class StyleTablePropertiesConverter
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public static Int32? GetTableStyleRowBandSize(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableStyleRowBandSize(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public static Int32? GetTableStyleColumnBandSize(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableStyleColumnBandSize(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
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
  
  public static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
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
  /// TableCellSpacing.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableIndentation? GetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.TableIndentation? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableBorders? GetTableBorders(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableBorders(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.TableBorders? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableCellMarginDefault? GetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? openXmlElement, DocumentModel.Wordprocessing.TableCellMarginDefault? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
