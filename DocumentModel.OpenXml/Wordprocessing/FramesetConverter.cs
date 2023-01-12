namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public static class FramesetConverter
{
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public static String? GetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.FrameSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.FramesetSplitbar? GetFramesetSplitbar(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FramesetSplitbarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFramesetSplitbar(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.FramesetSplitbar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FramesetSplitbarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public static DocumentModel.Wordprocessing.FrameLayoutKind? GetFrameLayout(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameLayout>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DocumentModel.Wordprocessing.FrameLayoutKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFrameLayout(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.FrameLayoutKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FrameLayout, DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DocumentModel.Wordprocessing.FrameLayoutKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Frameset? GetChildFrameset(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FramesetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildFrameset(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FramesetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Frameset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Frame? GetFrame(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFrame(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.Frame? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FrameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Frame>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Frameset? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Frameset();
      value.FrameSize = GetFrameSize(openXmlElement);
      value.FramesetSplitbar = GetFramesetSplitbar(openXmlElement);
      value.FrameLayout = GetFrameLayout(openXmlElement);
      value.ChildFrameset = GetChildFrameset(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Frameset? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Frameset, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFrameSize(openXmlElement, value?.FrameSize);
      SetFramesetSplitbar(openXmlElement, value?.FramesetSplitbar);
      SetFrameLayout(openXmlElement, value?.FrameLayout);
      return openXmlElement;
    }
    return default;
  }
}
