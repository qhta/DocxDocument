namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public static class MatrixPropertiesConverter
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public static DocumentModel.Math.VerticalAlignmentKind? GetBaseJustification(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DocumentModel.Math.VerticalAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBaseJustification(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DocumentModel.Math.VerticalAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetHidePlaceholder(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHidePlaceholder(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.HidePlaceholder, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public static Int64? GetRowSpacingRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacingRule");
  }
  
  public static void SetRowSpacingRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacingRule");
  }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public static Int64? GetColumnGapRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnGapRule");
  }
  
  public static void SetColumnGapRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnGapRule");
  }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public static UInt16? GetRowSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacing");
  }
  
  public static void SetRowSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacing");
  }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public static UInt32? GetColumnSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnSpacing");
  }
  
  public static void SetColumnSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnSpacing");
  }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public static UInt16? GetColumnGap(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnGap");
  }
  
  public static void SetColumnGap(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.ColumnGap");
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public static DocumentModel.Math.MatrixColumns? GetMatrixColumns(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MatrixColumnsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMatrixColumns(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.MatrixColumns? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MatrixColumnsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumns>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MatrixProperties? CreateModelElement(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixProperties();
      value.BaseJustification = GetBaseJustification(openXmlElement);
      value.HidePlaceholder = GetHidePlaceholder(openXmlElement);
      value.RowSpacingRule = GetRowSpacingRule(openXmlElement);
      value.ColumnGapRule = GetColumnGapRule(openXmlElement);
      value.RowSpacing = GetRowSpacing(openXmlElement);
      value.ColumnSpacing = GetColumnSpacing(openXmlElement);
      value.ColumnGap = GetColumnGap(openXmlElement);
      value.MatrixColumns = GetMatrixColumns(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MatrixProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
