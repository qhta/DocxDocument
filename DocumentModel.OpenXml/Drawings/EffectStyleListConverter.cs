namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public static class EffectStyleListConverter
{
  private static DocumentModel.Drawings.EffectStyle? GetEffectStyle(DocumentFormat.OpenXml.Drawing.EffectStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectStyle(DocumentFormat.OpenXml.Drawing.EffectStyleList openXmlElement, DocumentModel.Drawings.EffectStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectStyleList? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyleList();
      value.EffectStyle = GetEffectStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectStyleList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectStyle(openXmlElement, value?.EffectStyle);
      return openXmlElement;
    }
    return default;
  }
}
