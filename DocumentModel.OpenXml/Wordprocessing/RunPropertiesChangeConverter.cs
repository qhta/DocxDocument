using DocumentFormat.OpenXml.Wordprocessing;
using PreviousRunProperties = DocumentModel.Wordprocessing.PreviousRunProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the RunPropertiesChange Class.
/// </summary>
public static class RunPropertiesChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(RunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(RunPropertiesChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(RunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(RunPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(RunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(RunPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Run Properties.
  /// </summary>
  public static PreviousRunProperties? GetPreviousRunProperties(RunPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousRunProperties>();
    if (itemElement != null)
      return PreviousRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousRunProperties(RunPropertiesChange? openXmlElement, PreviousRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RunPropertiesChange? CreateModelElement(RunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousRunProperties = GetPreviousRunProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunPropertiesChange? value)
    where OpenXmlElementType : RunPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousRunProperties(openXmlElement, value?.PreviousRunProperties);
      return openXmlElement;
    }
    return default;
  }
}