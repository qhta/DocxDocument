namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public static DocumentModel.Drawings.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Drawing.Run? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Drawing.Run? openXmlElement, DocumentModel.Drawings.RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public static String? GetText(DocumentFormat.OpenXml.Drawing.Run? openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  public static void SetText(DocumentFormat.OpenXml.Drawing.Run? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Text = new DocumentFormat.OpenXml.Drawing.Text(value);
      else
        openXmlElement.Text = null;
    }
  }
  
  public static DocumentModel.Drawings.Run? CreateModelElement(DocumentFormat.OpenXml.Drawing.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Run();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Run? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetText(openXmlElement, value?.Text);
      return openXmlElement;
    }
    return default;
  }
}
