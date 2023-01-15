using DocumentModel.Wordprocessing;
using Ruby = DocumentFormat.OpenXml.Wordprocessing.Ruby;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Phonetic Guide.
/// </summary>
public static class RubyConverter
{
  /// <summary>
  ///   Phonetic Guide Properties.
  /// </summary>
  public static RubyProperties? GetRubyProperties(Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
    if (itemElement != null)
      return RubyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRubyProperties(Ruby? openXmlElement, RubyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phonetic Guide Text.
  /// </summary>
  public static RubyContent? GetRubyContent(Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
    if (itemElement != null)
      return RubyContentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRubyContent(Ruby? openXmlElement, RubyContent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyContentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyContent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phonetic Guide Base Text.
  /// </summary>
  public static RubyBase? GetRubyBase(Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
    if (itemElement != null)
      return RubyBaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRubyBase(Ruby? openXmlElement, RubyBase? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RubyBaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyBase>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Ruby? CreateModelElement(Ruby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Ruby();
      value.RubyProperties = GetRubyProperties(openXmlElement);
      value.RubyContent = GetRubyContent(openXmlElement);
      value.RubyBase = GetRubyBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Ruby? value)
    where OpenXmlElementType : Ruby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRubyProperties(openXmlElement, value?.RubyProperties);
      SetRubyContent(openXmlElement, value?.RubyContent);
      SetRubyBase(openXmlElement, value?.RubyBase);
      return openXmlElement;
    }
    return default;
  }
}