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
  public static Int32? GetRowSpacingRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRowSpacingRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public static Int32? GetColumnGapRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnGapRule(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public static UInt16? GetRowSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRowSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public static UInt32? GetColumnSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnSpacing(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public static UInt16? GetColumnGap(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnGap(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public static DocumentModel.Math.MatrixColumns? GetMatrixColumns(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMatrixColumns(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.MatrixColumns? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.MatrixProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
