using DocumentFormat.OpenXml.Wordprocessing;
using PreviousTablePropertyExceptions = DocumentModel.Wordprocessing.PreviousTablePropertyExceptions;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Table-Level Property Exceptions.
/// </summary>
public static class TablePropertyExceptionsChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(TablePropertyExceptionsChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(TablePropertyExceptionsChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(TablePropertyExceptionsChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(TablePropertyExceptionsChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TablePropertyExceptionsChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TablePropertyExceptionsChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Table-Level Property Exceptions.
  /// </summary>
  public static PreviousTablePropertyExceptions? GetPreviousTablePropertyExceptions(TablePropertyExceptionsChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions>();
    if (itemElement != null)
      return PreviousTablePropertyExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousTablePropertyExceptions(TablePropertyExceptionsChange? openXmlElement, PreviousTablePropertyExceptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTablePropertyExceptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TablePropertyExceptionsChange? CreateModelElement(TablePropertyExceptionsChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TablePropertyExceptionsChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTablePropertyExceptions = GetPreviousTablePropertyExceptions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TablePropertyExceptionsChange? value)
    where OpenXmlElementType : TablePropertyExceptionsChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTablePropertyExceptions(openXmlElement, value?.PreviousTablePropertyExceptions);
      return openXmlElement;
    }
    return default;
  }
}