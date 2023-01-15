using DocumentFormat.OpenXml.Office2010.Drawing;
using BackgroundMark = DocumentModel.Drawings.BackgroundMark;
using ForegroundMark = DocumentModel.Drawings.ForegroundMark;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BackgroundRemoval Class.
/// </summary>
public static class BackgroundRemovalConverter
{
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetMarqueeTop(BackgroundRemoval? openXmlElement)
  {
    return openXmlElement?.MarqueeTop?.Value;
  }

  public static void SetMarqueeTop(BackgroundRemoval? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.MarqueeTop = value;
  }

  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetMarqueeBottom(BackgroundRemoval? openXmlElement)
  {
    return openXmlElement?.MarqueeBottom?.Value;
  }

  public static void SetMarqueeBottom(BackgroundRemoval? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.MarqueeBottom = value;
  }

  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetMarqueeLeft(BackgroundRemoval? openXmlElement)
  {
    return openXmlElement?.MarqueeLeft?.Value;
  }

  public static void SetMarqueeLeft(BackgroundRemoval? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.MarqueeLeft = value;
  }

  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetMarqueeRight(BackgroundRemoval? openXmlElement)
  {
    return openXmlElement?.MarqueeRight?.Value;
  }

  public static void SetMarqueeRight(BackgroundRemoval? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.MarqueeRight = value;
  }

  public static Collection<ForegroundMark>? GetForegroundMarks(BackgroundRemoval? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ForegroundMark>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>())
      {
        var newItem = ForegroundMarkConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetForegroundMarks(BackgroundRemoval? openXmlElement, Collection<ForegroundMark>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ForegroundMarkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<BackgroundMark>? GetBackgroundMarks(BackgroundRemoval? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BackgroundMark>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>())
      {
        var newItem = BackgroundMarkConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBackgroundMarks(BackgroundRemoval? openXmlElement, Collection<BackgroundMark>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BackgroundMarkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.BackgroundRemoval? CreateModelElement(BackgroundRemoval? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundRemoval();
      value.MarqueeTop = GetMarqueeTop(openXmlElement);
      value.MarqueeBottom = GetMarqueeBottom(openXmlElement);
      value.MarqueeLeft = GetMarqueeLeft(openXmlElement);
      value.MarqueeRight = GetMarqueeRight(openXmlElement);
      value.ForegroundMarks = GetForegroundMarks(openXmlElement);
      value.BackgroundMarks = GetBackgroundMarks(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundRemoval? value)
    where OpenXmlElementType : BackgroundRemoval, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMarqueeTop(openXmlElement, value?.MarqueeTop);
      SetMarqueeBottom(openXmlElement, value?.MarqueeBottom);
      SetMarqueeLeft(openXmlElement, value?.MarqueeLeft);
      SetMarqueeRight(openXmlElement, value?.MarqueeRight);
      SetForegroundMarks(openXmlElement, value?.ForegroundMarks);
      SetBackgroundMarks(openXmlElement, value?.BackgroundMarks);
      return openXmlElement;
    }
    return default;
  }
}