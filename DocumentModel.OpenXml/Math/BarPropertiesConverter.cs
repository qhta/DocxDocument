namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public static class BarPropertiesConverter
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public static DocumentModel.Math.VerticalJustificationKind? GetPosition(DocumentFormat.OpenXml.Math.BarProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Math.BarProperties? openXmlElement, DocumentModel.Math.VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Position, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.BarProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.BarProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
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
  
  public static DocumentModel.Math.BarProperties? CreateModelElement(DocumentFormat.OpenXml.Math.BarProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BarProperties();
      value.Position = GetPosition(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.BarProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.BarProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
