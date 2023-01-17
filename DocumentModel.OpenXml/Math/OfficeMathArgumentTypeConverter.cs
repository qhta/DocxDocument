namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the OfficeMathArgumentType Class.
/// </summary>
public static class OfficeMathArgumentTypeConverter
{
  /// <summary>
  /// Argument Properties.
  /// </summary>
  private static DocumentModel.Math.ArgumentProperties? GetArgumentProperties(DocumentFormat.OpenXml.Math.OfficeMathArgumentType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ArgumentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArgumentProperties(DocumentFormat.OpenXml.Math.OfficeMathArgumentType openXmlElement, DocumentModel.Math.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ArgumentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.OfficeMathArgumentType? CreateModelElement(DocumentFormat.OpenXml.Math.OfficeMathArgumentType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.OfficeMathArgumentType();
      value.ArgumentProperties = GetArgumentProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.OfficeMathArgumentType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.OfficeMathArgumentType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentProperties(openXmlElement, value?.ArgumentProperties);
      return openXmlElement;
    }
    return default;
  }
}
