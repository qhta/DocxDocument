namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Upper Limit Properties.
/// </summary>
public static class LimitUpperPropertiesConverter
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.LimitUpperProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.LimitUpperProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Math.LimitUpperProperties? CreateModelElement(DocumentFormat.OpenXml.Math.LimitUpperProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitUpperProperties();
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitUpperProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.LimitUpperProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
