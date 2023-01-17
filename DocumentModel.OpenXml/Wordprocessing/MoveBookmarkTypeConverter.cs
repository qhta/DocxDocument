namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public static class MoveBookmarkTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement.ColumnFirst?.Value;
  }
  
  private static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement.ColumnLast?.Value;
  }
  
  private static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MoveBookmarkType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MoveBookmarkType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
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
