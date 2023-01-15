using DocumentModel.Wordprocessing;
using RunTrackChangeType = DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the RunTrackChangeType Class.
/// </summary>
public static class RunTrackChangeType2Converter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(RunTrackChangeType? openXmlElement, String? value)
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
  public static DateTime? GetDate(RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(RunTrackChangeType? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(RunTrackChangeType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static RunTrackChangeType2? CreateModelElement(RunTrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new RunTrackChangeType2();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(RunTrackChangeType2? value)
    where OpenXmlElementType : RunTrackChangeType, new()
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