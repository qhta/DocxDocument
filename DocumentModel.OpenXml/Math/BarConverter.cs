namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Bar.
/// </summary>
public static class BarConverter
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  private static DocumentModel.Math.BarProperties? GetBarProperties(DocumentFormat.OpenXml.Math.Bar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BarProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BarPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBarProperties(DocumentFormat.OpenXml.Math.Bar openXmlElement, DocumentModel.Math.BarProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BarProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BarPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BarProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Bar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.Bar openXmlElement, DocumentModel.Math.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Bar? CreateModelElement(DocumentFormat.OpenXml.Math.Bar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Bar();
      value.BarProperties = GetBarProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Bar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Bar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarProperties(openXmlElement, value?.BarProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
