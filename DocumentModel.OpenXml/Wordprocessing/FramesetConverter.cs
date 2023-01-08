namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public static class FramesetConverter
{
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
  
}
