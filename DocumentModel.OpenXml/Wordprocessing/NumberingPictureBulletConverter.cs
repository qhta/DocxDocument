namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public static class NumberingPictureBulletConverter
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public static Int32? GetNumberingPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement)
  {
    return openXmlElement?.NumberingPictureBulletId?.Value;
  }
  
  public static void SetNumberingPictureBulletId(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberingPictureBulletId = value;
  }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public static DocumentModel.Wordprocessing.PictureBulletBase? GetPictureBulletBase(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PictureBulletBaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureBulletBase(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement, DocumentModel.Wordprocessing.PictureBulletBase? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PictureBulletBaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public static DocumentModel.Wordprocessing.Drawing? GetDrawing(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDrawing(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement, DocumentModel.Wordprocessing.Drawing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.NumberingPictureBullet? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingPictureBullet();
      value.NumberingPictureBulletId = GetNumberingPictureBulletId(openXmlElement);
      value.PictureBulletBase = GetPictureBulletBase(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingPictureBullet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
