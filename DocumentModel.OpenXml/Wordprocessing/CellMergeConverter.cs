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
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.CellMerge? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CellMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CellMerge();
      value.VerticalMerge = GetVerticalMerge(openXmlElement);
      value.VerticalMergeOriginal = GetVerticalMergeOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CellMerge? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CellMerge, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
