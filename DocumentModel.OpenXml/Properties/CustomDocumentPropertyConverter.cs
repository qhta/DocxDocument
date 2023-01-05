namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public static class CustomDocumentPropertyConverter
{
  /// <summary>
  /// Format ID
  /// </summary>
  public static String? GetFormatId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.FormatId;
  }
  
  public static void SetFormatId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.FormatId = value;
  }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public static Int32? GetPropertyId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.PropertyId?.Value;
  }
  
  public static void SetPropertyId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PropertyId = value;
  }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.Name;
  }
  
  public static void SetName(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Name = value;
  }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public static String? GetLinkTarget(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.LinkTarget;
  }
  
  public static void SetLinkTarget(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.LinkTarget = value;
  }

  /// <summary>
  /// Variant Value
  /// </summary>
  public static object? GetValue(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    if (openXmlElement != null)
    {
      var valueElement = openXmlElement.Elements().FirstOrDefault(item => item.GetType().Name.StartsWith("VT"));
      if (valueElement != null)
        return VariantConverter.GetValue(valueElement);
    }
    return null;
  }
  public static void SetValue(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, object? value)
  {
    if (openXmlElement != null)
    {
      var valueElement = openXmlElement.Elements().FirstOrDefault(item => item.LocalName.StartsWith("VT"));
      if (valueElement != null)
        valueElement.Remove();
      if (value != null)
      {
        valueElement = VariantConverter.CreateOpenXmlElement(value);
        if (valueElement != null)
          openXmlElement.AddChild(valueElement);
      }
    }
  }

  public static DocumentModel.Properties.CustomDocumentProperty? CreateModelElement(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? openXmlElement)
  {
    var value = new DocumentModel.Properties.CustomDocumentProperty();
    if (openXmlElement != null)
    {
      value.FormatId = GetFormatId(openXmlElement);
      value.PropertyId = GetPropertyId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.LinkTarget = GetLinkTarget(openXmlElement);
      value.Value = GetValue(openXmlElement);
    }
    return value;
  }
  
  public static DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? CreateOpenXmlElement(DocumentModel.Properties.CustomDocumentProperty? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty();
      SetFormatId(openXmlElement, value.FormatId);
      SetPropertyId(openXmlElement, value.PropertyId);
      SetName(openXmlElement, value.Name);
      SetLinkTarget(openXmlElement, value.LinkTarget);
      SetValue(openXmlElement, value.Value);
      return openXmlElement;
    }
    return null;
  }
}
