using DocumentModel.Drawings.Charts;
using ChartText = DocumentFormat.OpenXml.Drawing.Charts.ChartText;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ChartText Class.
/// </summary>
public static class ChartTextConverter
{
  /// <summary>
  ///   String Reference.
  /// </summary>
  public static StringReference? GetStringReference(ChartText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringReference(ChartText? openXmlElement, StringReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Rich Text.
  /// </summary>
  public static RichText? GetRichText(ChartText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
    if (itemElement != null)
      return RichTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRichText(ChartText? openXmlElement, RichText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RichTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   String Literal.
  /// </summary>
  public static StringLiteral? GetStringLiteral(ChartText? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      return StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringLiteral(ChartText? openXmlElement, StringLiteral? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ChartText? CreateModelElement(ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartText();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartText? value)
    where OpenXmlElementType : ChartText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetRichText(openXmlElement, value?.RichText);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}