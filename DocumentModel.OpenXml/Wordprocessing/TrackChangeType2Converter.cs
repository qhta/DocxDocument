using DocumentModel.Wordprocessing;
using TrackChangeType = DocumentFormat.OpenXml.Office2010.Word.TrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TrackChangeType Class.
/// </summary>
public static class TrackChangeType2Converter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(TrackChangeType? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(TrackChangeType? openXmlElement, String? value)
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
  public static DateTime? GetDate(TrackChangeType? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(TrackChangeType? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TrackChangeType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TrackChangeType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static TrackChangeType2? CreateModelElement(TrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new TrackChangeType2();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(TrackChangeType2? value)
    where OpenXmlElementType : TrackChangeType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}