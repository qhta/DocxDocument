namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public static class FramesetSplitbarConverter
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  public static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Width");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Width");
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public static DocumentModel.Wordprocessing.Color? GetColor(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement, DocumentModel.Wordprocessing.Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoBorder(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBorder>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNoBorder(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoBorder, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetFlatBorders(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FlatBorders>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFlatBorders(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FlatBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FlatBorders, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.FramesetSplitbar? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FramesetSplitbar();
      value.Width = GetWidth(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.NoBorder = GetNoBorder(openXmlElement);
      value.FlatBorders = GetFlatBorders(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FramesetSplitbar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetColor(openXmlElement, value?.Color);
      SetNoBorder(openXmlElement, value?.NoBorder);
      SetFlatBorders(openXmlElement, value?.FlatBorders);
      return openXmlElement;
    }
    return default;
  }
}
