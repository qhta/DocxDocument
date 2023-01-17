namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Lower Limit Properties.
/// </summary>
public static class LimitLowerPropertiesConverter
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.LimitLowerProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.LimitLowerProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.LimitLowerProperties? CreateModelElement(DocumentFormat.OpenXml.Math.LimitLowerProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitLowerProperties();
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitLowerProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.LimitLowerProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
