namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public static class BookmarkStartConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement)
  {
    return openXmlElement.ColumnFirst?.Value;
  }
  
  private static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement)
  {
    return openXmlElement.ColumnLast?.Value;
  }
  
  private static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetColumnFirst(openXmlElement, value?.ColumnFirst);
      SetColumnLast(openXmlElement, value?.ColumnLast);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
