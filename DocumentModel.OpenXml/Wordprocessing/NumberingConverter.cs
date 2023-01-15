using DocumentFormat.OpenXml.Wordprocessing;
using AbstractNum = DocumentModel.Wordprocessing.AbstractNum;
using Numbering = DocumentFormat.OpenXml.Wordprocessing.Numbering;
using NumberingInstance = DocumentModel.Wordprocessing.NumberingInstance;
using NumberingPictureBullet = DocumentModel.Wordprocessing.NumberingPictureBullet;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Numbering Definitions.
/// </summary>
public static class NumberingConverter
{
  public static Collection<NumberingPictureBullet>? GetNumberingPictureBullets(Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumberingPictureBullet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>())
      {
        var newItem = NumberingPictureBulletConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumberingPictureBullets(Numbering? openXmlElement, Collection<NumberingPictureBullet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumberingPictureBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<AbstractNum>? GetAbstractNums(Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AbstractNum>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>())
      {
        var newItem = AbstractNumConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAbstractNums(Numbering? openXmlElement, Collection<AbstractNum>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AbstractNumConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<NumberingInstance>? GetNumberingInstances(Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumberingInstance>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>())
      {
        var newItem = NumberingInstanceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumberingInstances(Numbering? openXmlElement, Collection<NumberingInstance>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumberingInstanceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Int32? GetNumberingIdMacAtCleanup(Numbering? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingIdMacAtCleanup>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingIdMacAtCleanup(Numbering? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingIdMacAtCleanup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberingIdMacAtCleanup { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Numbering? CreateModelElement(Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Numbering();
      value.NumberingPictureBullets = GetNumberingPictureBullets(openXmlElement);
      value.AbstractNums = GetAbstractNums(openXmlElement);
      value.NumberingInstances = GetNumberingInstances(openXmlElement);
      value.NumberingIdMacAtCleanup = GetNumberingIdMacAtCleanup(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Numbering? value)
    where OpenXmlElementType : Numbering, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingPictureBullets(openXmlElement, value?.NumberingPictureBullets);
      SetAbstractNums(openXmlElement, value?.AbstractNums);
      SetNumberingInstances(openXmlElement, value?.NumberingInstances);
      SetNumberingIdMacAtCleanup(openXmlElement, value?.NumberingIdMacAtCleanup);
      return openXmlElement;
    }
    return default;
  }
}