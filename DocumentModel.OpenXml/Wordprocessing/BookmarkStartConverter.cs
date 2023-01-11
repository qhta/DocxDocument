namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public static class BookmarkStartConverter
{
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }
  
  public static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }
  
  public static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  public static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.BookmarkStart? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BookmarkStart();
      value.Name = GetName(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.BookmarkStart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.BookmarkStart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
