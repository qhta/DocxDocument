namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public static class BackgroundRemovalConverter
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeTop(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeTop?.Value;
  }
  
  private static void SetMarqueeTop(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeTop = value;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeBottom(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeBottom?.Value;
  }
  
  private static void SetMarqueeBottom(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeBottom = value;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeLeft(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeLeft?.Value;
  }
  
  private static void SetMarqueeLeft(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeLeft = value;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetMarqueeRight(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    return openXmlElement.MarqueeRight?.Value;
  }
  
  private static void SetMarqueeRight(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, Int32? value)
  {
    openXmlElement.MarqueeRight = value;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ForegroundMark> GetForegroundMarks(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ForegroundMark>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ForegroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetForegroundMarks(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ForegroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ForegroundMarkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BackgroundMark> GetBackgroundMarks(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BackgroundMark>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.BackgroundMarkConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBackgroundMarks(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BackgroundMark>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.BackgroundMarkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.BackgroundRemoval? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval, new()
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
