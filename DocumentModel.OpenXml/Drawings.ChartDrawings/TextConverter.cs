using DocumentModel.Drawings.ChartDrawings;
using Text = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Text Class.
/// </summary>
public static class TextConverter
{
  /// <summary>
  ///   TextData.
  /// </summary>
  public static TextData? GetTextData(Text? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
    if (itemElement != null)
      return TextDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextData(Text? openXmlElement, TextData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RichTextBody.
  /// </summary>
  public static RichTextBody? GetRichTextBody(Text? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
    if (itemElement != null)
      return RichTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRichTextBody(Text? openXmlElement, RichTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RichTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Text? CreateModelElement(Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Text();
      value.TextData = GetTextData(openXmlElement);
      value.RichTextBody = GetRichTextBody(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Text? value)
    where OpenXmlElementType : Text, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextData(openXmlElement, value?.TextData);
      SetRichTextBody(openXmlElement, value?.RichTextBody);
      return openXmlElement;
    }
    return default;
  }
}