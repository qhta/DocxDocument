namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public static class ColorChangeConverter
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public static Boolean? GetUseAlpha(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement)
  {
    return openXmlElement?.UseAlpha?.Value;
  }
  
  public static void SetUseAlpha(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseAlpha = null;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public static DocumentModel.Drawings.ColorFrom? GetColorFrom(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorFromConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorFrom(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement, DocumentModel.Drawings.ColorFrom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ColorFromConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorFrom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public static DocumentModel.Drawings.ColorTo? GetColorTo(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorToConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorTo(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement, DocumentModel.Drawings.ColorTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ColorToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ColorChange? CreateModelElement(DocumentFormat.OpenXml.Drawing.ColorChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorChange();
      value.UseAlpha = GetUseAlpha(openXmlElement);
      value.ColorFrom = GetColorFrom(openXmlElement);
      value.ColorTo = GetColorTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ColorChange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ColorChange, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
