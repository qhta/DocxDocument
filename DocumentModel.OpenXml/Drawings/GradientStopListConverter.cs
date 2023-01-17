namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public static class GradientStopListConverter
{
  private static DocumentModel.Drawings.GradientStop? GetGradientStop(DocumentFormat.OpenXml.Drawing.GradientStopList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientStopConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientStop(DocumentFormat.OpenXml.Drawing.GradientStopList openXmlElement, DocumentModel.Drawings.GradientStop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GradientStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientStop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.GradientStopList? CreateModelElement(DocumentFormat.OpenXml.Drawing.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientStopList();
      value.GradientStop = GetGradientStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GradientStopList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.GradientStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStop(openXmlElement, value?.GradientStop);
      return openXmlElement;
    }
    return default;
  }
}
