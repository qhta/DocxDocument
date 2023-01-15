using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   External Content Import Properties.
/// </summary>
public static class AltChunkPropertiesConverter
{
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  public static Boolean? GetMatchSource(AltChunkProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MatchSource>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMatchSource(AltChunkProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MatchSource>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MatchSource();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.AltChunkProperties? CreateModelElement(AltChunkProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AltChunkProperties();
      value.MatchSource = GetMatchSource(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AltChunkProperties? value)
    where OpenXmlElementType : AltChunkProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatchSource(openXmlElement, value?.MatchSource);
      return openXmlElement;
    }
    return default;
  }
}