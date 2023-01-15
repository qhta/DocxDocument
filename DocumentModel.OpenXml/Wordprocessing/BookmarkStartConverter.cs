using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BookmarkStart = DocumentFormat.OpenXml.Wordprocessing.BookmarkStart;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the BookmarkStart Class.
/// </summary>
public static class BookmarkStartConverter
{
  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(BookmarkStart? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(BookmarkStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   colFirst
  /// </summary>
  public static Int32? GetColumnFirst(BookmarkStart? openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }

  public static void SetColumnFirst(BookmarkStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnFirst = value;
  }

  /// <summary>
  ///   colLast
  /// </summary>
  public static Int32? GetColumnLast(BookmarkStart? openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }

  public static void SetColumnLast(BookmarkStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnLast = value;
  }

  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  public static DisplacedByCustomXmlKind? GetDisplacedByCustomXml(BookmarkStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  public static void SetDisplacedByCustomXml(BookmarkStart? openXmlElement, DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(value);
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(BookmarkStart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(BookmarkStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.BookmarkStart? CreateModelElement(BookmarkStart? openXmlElement)
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
    where OpenXmlElementType : BookmarkStart, new()
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