using DocumentModel.Wordprocessing;
using VbaSuppData = DocumentFormat.OpenXml.Office.Word.VbaSuppData;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the VbaSuppData Class.
/// </summary>
public static class VbaSuppDataConverter
{
  /// <summary>
  ///   DocEvents.
  /// </summary>
  public static DocEvents? GetDocEvents(VbaSuppData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
    if (itemElement != null)
      return DocEventsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocEvents(VbaSuppData? openXmlElement, DocEvents? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocEventsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.DocEvents>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Mcds.
  /// </summary>
  public static Mcds? GetMcds(VbaSuppData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
    if (itemElement != null)
      return McdsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMcds(VbaSuppData? openXmlElement, Mcds? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = McdsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Mcds>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.VbaSuppData? CreateModelElement(VbaSuppData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.VbaSuppData();
      value.DocEvents = GetDocEvents(openXmlElement);
      value.Mcds = GetMcds(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.VbaSuppData? value)
    where OpenXmlElementType : VbaSuppData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocEvents(openXmlElement, value?.DocEvents);
      SetMcds(openXmlElement, value?.Mcds);
      return openXmlElement;
    }
    return default;
  }
}