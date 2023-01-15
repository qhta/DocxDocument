using DocumentModel.Drawings;
using PictureBullet = DocumentFormat.OpenXml.Drawing.PictureBullet;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Picture Bullet.
/// </summary>
public static class PictureBulletConverter
{
  /// <summary>
  ///   Blip.
  /// </summary>
  public static Blip? GetBlip(PictureBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
    if (itemElement != null)
      return BlipConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlip(PictureBullet? openXmlElement, Blip? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blip>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PictureBullet? CreateModelElement(PictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureBullet();
      value.Blip = GetBlip(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PictureBullet? value)
    where OpenXmlElementType : PictureBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlip(openXmlElement, value?.Blip);
      return openXmlElement;
    }
    return default;
  }
}