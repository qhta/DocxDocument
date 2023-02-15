using DocumentFormat.OpenXml.CustomProperties;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Custom File Property.
/// </summary>
public static class CustomDocumentPropertyConverter
{
  /// <summary>
  ///   Format ID
  /// </summary>
  public static String? GetFormatId(CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.FormatId;
  }

  public static void SetFormatId(CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.FormatId = value;
  }

  /// <summary>
  ///   Property ID
  /// </summary>
  public static Int32? GetPropertyId(CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.PropertyId?.Value;
  }

  public static void SetPropertyId(CustomDocumentProperty openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PropertyId = value;
  }

  /// <summary>
  ///   Custom File Property Name
  /// </summary>
  public static String? GetName(CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.Name;
  }

  public static void SetName(CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Name = value;
  }

  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  public static String? GetLinkTarget(CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.LinkTarget;
  }

  public static void SetLinkTarget(CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.LinkTarget = value;
  }

  /// <summary>
  ///   Variant Value
  /// </summary>
  public static Variant? GetValue(CustomDocumentProperty openXmlElement)
  {
    if (openXmlElement != null)
    {
      var valueElement = openXmlElement.Elements().FirstOrDefault(item => item.GetType().Name.StartsWith("VT"));
      if (valueElement != null)
        return VariantConverter.GetVariant(valueElement);
    }
    return null;
  }

  public static void SetValue(CustomDocumentProperty openXmlElement, object? value)
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

  public static DocumentModel.DocumentProperty? CreateModelElement(CustomDocumentProperty? openXmlElement)
  {
    var value = new DocumentModel.DocumentProperty();
    if (openXmlElement != null)
    {
      //value.FormatId = GetFormatId(openXmlElement);
      value.PropertyId = GetPropertyId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.LinkTarget = GetLinkTarget(openXmlElement);
      value.Value = GetValue(openXmlElement);
    }
    return value;
  }

  public static CustomDocumentProperty? CreateOpenXmlElement(DocumentModel.DocumentProperty? value)
  {
    if (value != null)
    {
      var openXmlElement = new CustomDocumentProperty();
      //SetFormatId(openXmlElement, value.FormatId);
      SetFormatId(openXmlElement, FMTIDS.UserDefinedProperties);
      SetPropertyId(openXmlElement, value.PropertyId);
      SetName(openXmlElement, value.Name);
      SetLinkTarget(openXmlElement, value.LinkTarget);
      SetValue(openXmlElement, value.Value);
      return openXmlElement;
    }
    return null;
  }
}