using DocumentFormat.OpenXml.Wordprocessing;
using Drawing = DocumentModel.Wordprocessing.Drawing;
using PictureBulletBase = DocumentModel.Wordprocessing.PictureBulletBase;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Picture Numbering Symbol Definition.
/// </summary>
public static class NumberingPictureBulletConverter
{
  /// <summary>
  ///   numPicBulletId
  /// </summary>
  public static Int32? GetNumberingPictureBulletId(NumberingPictureBullet? openXmlElement)
  {
    return openXmlElement?.NumberingPictureBulletId?.Value;
  }

  public static void SetNumberingPictureBulletId(NumberingPictureBullet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberingPictureBulletId = value;
  }

  /// <summary>
  ///   PictureBulletBase.
  /// </summary>
  public static PictureBulletBase? GetPictureBulletBase(NumberingPictureBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
    if (itemElement != null)
      return PictureBulletBaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureBulletBase(NumberingPictureBullet? openXmlElement, PictureBulletBase? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureBulletBaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Drawing.
  /// </summary>
  public static Drawing? GetDrawing(NumberingPictureBullet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DrawingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDrawing(NumberingPictureBullet? openXmlElement, Drawing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.NumberingPictureBullet? CreateModelElement(NumberingPictureBullet? openXmlElement)
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
    where OpenXmlElementType : NumberingPictureBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingPictureBulletId(openXmlElement, value?.NumberingPictureBulletId);
      SetPictureBulletBase(openXmlElement, value?.PictureBulletBase);
      SetDrawing(openXmlElement, value?.Drawing);
      return openXmlElement;
    }
    return default;
  }
}