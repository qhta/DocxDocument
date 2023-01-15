using DocumentFormat.OpenXml.Wordprocessing;
using AltChunkProperties = DocumentModel.Wordprocessing.AltChunkProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the AltChunk Class.
/// </summary>
public static class AltChunkConverter
{
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public static String? GetId(AltChunk? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(AltChunk? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  public static AltChunkProperties? GetAltChunkProperties(AltChunk? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>();
    if (itemElement != null)
      return AltChunkPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAltChunkProperties(AltChunk? openXmlElement, AltChunkProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AltChunkPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.AltChunk? CreateModelElement(AltChunk? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AltChunk();
      value.Id = GetId(openXmlElement);
      value.AltChunkProperties = GetAltChunkProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AltChunk? value)
    where OpenXmlElementType : AltChunk, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAltChunkProperties(openXmlElement, value?.AltChunkProperties);
      return openXmlElement;
    }
    return default;
  }
}