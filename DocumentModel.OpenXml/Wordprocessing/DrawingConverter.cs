using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Drawings.Wordprocessing;
using DocumentModel.OpenXml.Drawings.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   DrawingML Object.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  public static Anchor? GetAnchor(Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
    if (itemElement != null)
      return AnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAnchor(Drawing? openXmlElement, Anchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  public static Inline? GetInline(Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
    if (itemElement != null)
      return InlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInline(Drawing? openXmlElement, Inline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Drawing? CreateModelElement(Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawing();
      value.Anchor = GetAnchor(openXmlElement);
      value.Inline = GetInline(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawing? value)
    where OpenXmlElementType : Drawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAnchor(openXmlElement, value?.Anchor);
      SetInline(openXmlElement, value?.Inline);
      return openXmlElement;
    }
    return default;
  }
}