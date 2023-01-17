namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public static class CellMergeConverter
{
  /// <summary>
  /// vMerge
  /// </summary>
  private static DocumentModel.Wordprocessing.VerticalMergeRevisionKind? GetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }
  
  private static void SetVerticalMerge(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement, DocumentModel.Wordprocessing.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  private static DocumentModel.Wordprocessing.VerticalMergeRevisionKind? GetVerticalMergeOriginal(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }
  
  private static void SetVerticalMergeOriginal(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement, DocumentModel.Wordprocessing.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DocumentModel.Wordprocessing.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVerticalMerge(openXmlElement, value?.VerticalMerge);
      SetVerticalMergeOriginal(openXmlElement, value?.VerticalMergeOriginal);
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
