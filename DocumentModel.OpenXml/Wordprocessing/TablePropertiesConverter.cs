namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Properties.
/// </summary>
public static class TablePropertiesConverter
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  public static String? GetTableStyle(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.TableStyle");
  }
  
  public static void SetTableStyle(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TablePositionProperties? GetTablePositionProperties(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTablePositionProperties(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TablePositionProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableOverlapKind? GetTableOverlap(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableOverlap>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DocumentModel.Wordprocessing.TableOverlapKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTableOverlap(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableOverlapKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableOverlap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableOverlap, DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DocumentModel.Wordprocessing.TableOverlapKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetBiDiVisual(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBiDiVisual(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableWidth(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableWidth(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
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
  
  public static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
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
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableIndentation? GetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableIndentation? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableBorders? GetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableBorders? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableLayout? GetTableLayout(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableLayout(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableLayout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableCellMarginDefault? GetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableCellMarginDefault? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableLook? GetTableLook(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableLook(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TableLook? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetTableCaption(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    return openXmlElement?.TableCaption?.Val?.Value;
  }
  
  public static void SetTableCaption(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetTableDescription(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    return openXmlElement?.TableDescription?.Val?.Value;
  }
  
  public static void SetTableDescription(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Revision Information for Table Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TablePropertiesChange? GetTablePropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTablePropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableProperties? openXmlElement, DocumentModel.Wordprocessing.TablePropertiesChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
