namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public static class CellMergeConverter
{
  /// <summary>
  /// vMerge
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalMergeRevisionKind? GetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }
  
  public static void SetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, DocumentModel.Wordprocessing.VerticalMergeRevisionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalMergeRevisionKind? GetVerticalMergeOriginal(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }
  
  public static void SetVerticalMergeOriginal(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, DocumentModel.Wordprocessing.VerticalMergeRevisionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// date
  /// </summary>
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, DateTime? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
