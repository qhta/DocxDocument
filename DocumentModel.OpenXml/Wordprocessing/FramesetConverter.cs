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
    return openXmlElement?.FrameSize?.Val?.Value;
  }
  
  public static void SetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.FramesetSplitbar? GetFramesetSplitbar(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFramesetSplitbar(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.FramesetSplitbar? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildFrameset(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Frame? GetFrame(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFrame(DocumentFormat.OpenXml.Wordprocessing.Frameset? openXmlElement, DocumentModel.Wordprocessing.Frame? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
