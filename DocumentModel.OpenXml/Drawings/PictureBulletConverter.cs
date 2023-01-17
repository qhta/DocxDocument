namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public static class PictureBulletConverter
{
  /// <summary>
  /// Blip.
  /// </summary>
  private static DocumentModel.Drawings.Blip? GetBlip(DocumentFormat.OpenXml.Drawing.PictureBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlip(DocumentFormat.OpenXml.Drawing.PictureBullet openXmlElement, DocumentModel.Drawings.Blip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blip>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PictureBullet? CreateModelElement(DocumentFormat.OpenXml.Drawing.PictureBullet? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PictureBullet, new()
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
