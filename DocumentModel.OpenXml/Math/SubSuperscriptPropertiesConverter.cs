namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public static class SubSuperscriptPropertiesConverter
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetAlignScripts(DocumentFormat.OpenXml.Math.SubSuperscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAlignScripts(DocumentFormat.OpenXml.Math.SubSuperscriptProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.AlignScripts, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.SubSuperscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.SubSuperscriptProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
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
  
  public static DocumentModel.Math.SubSuperscriptProperties? CreateModelElement(DocumentFormat.OpenXml.Math.SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SubSuperscriptProperties();
      value.AlignScripts = GetAlignScripts(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SubSuperscriptProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.SubSuperscriptProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignScripts(openXmlElement, value?.AlignScripts);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
