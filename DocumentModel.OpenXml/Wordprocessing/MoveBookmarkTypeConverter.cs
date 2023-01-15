using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using MoveBookmarkType = DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MoveBookmarkType Class.
/// </summary>
public static class MoveBookmarkTypeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(MoveBookmarkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }

  /// <summary>
  ///   date
  /// </summary>
  public static DateTime? GetDate(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(MoveBookmarkType? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(MoveBookmarkType? openXmlElement, String? value)
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
  public static Int32? GetColumnFirst(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }

  public static void SetColumnFirst(MoveBookmarkType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnFirst = value;
  }

  /// <summary>
  ///   colLast
  /// </summary>
  public static Int32? GetColumnLast(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }

  public static void SetColumnLast(MoveBookmarkType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnLast = value;
  }

  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  public static DisplacedByCustomXmlKind? GetDisplacedByCustomXml(MoveBookmarkType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  public static void SetDisplacedByCustomXml(MoveBookmarkType? openXmlElement, DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(value);
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(MoveBookmarkType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(MoveBookmarkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.MoveBookmarkType? CreateModelElement(MoveBookmarkType? openXmlElement)
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
    where OpenXmlElementType : MoveBookmarkType, new()
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