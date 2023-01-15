using DocumentFormat.OpenXml.Office2010.Drawing;
using ImageEffect = DocumentModel.Drawings.ImageEffect;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public static class ImageLayerConverter
{
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetEmbed(ImageLayer? openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }

  public static void SetEmbed(ImageLayer? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Embed = new StringValue { Value = value };
      else
        openXmlElement.Embed = null;
  }

  public static Collection<ImageEffect>? GetImageEffects(ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ImageEffect>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>())
      {
        var newItem = ImageEffectConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetImageEffects(ImageLayer? openXmlElement, Collection<ImageEffect>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ImageEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ImageLayer? CreateModelElement(ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageLayer();
      value.Embed = GetEmbed(openXmlElement);
      value.ImageEffects = GetImageEffects(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ImageLayer? value)
    where OpenXmlElementType : ImageLayer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbed(openXmlElement, value?.Embed);
      SetImageEffects(openXmlElement, value?.ImageEffects);
      return openXmlElement;
    }
    return default;
  }
}