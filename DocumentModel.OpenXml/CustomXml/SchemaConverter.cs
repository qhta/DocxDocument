using DocumentFormat.OpenXml.CustomXmlSchemaReferences;

namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
///   Custom XML Schema Reference.
/// </summary>
public static class SchemaConverter
{
  /// <summary>
  ///   Custom XML Schema Namespace
  /// </summary>
  public static String? GetUri(Schema? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  /// <summary>
  ///   Resource File Location
  /// </summary>
  public static String? GetManifestLocation(Schema? openXmlElement)
  {
    return openXmlElement?.ManifestLocation?.Value;
  }

  public static void SetManifestLocation(Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ManifestLocation = new StringValue { Value = value };
      else
        openXmlElement.ManifestLocation = null;
  }

  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  public static String? GetSchemaLocation(Schema? openXmlElement)
  {
    return openXmlElement?.SchemaLocation?.Value;
  }

  public static void SetSchemaLocation(Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SchemaLocation = new StringValue { Value = value };
      else
        openXmlElement.SchemaLocation = null;
  }

  public static DocumentModel.CustomXml.Schema? CreateModelElement(Schema? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.Schema();
      value.Uri = GetUri(openXmlElement);
      value.ManifestLocation = GetManifestLocation(openXmlElement);
      value.SchemaLocation = GetSchemaLocation(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.Schema? value)
    where OpenXmlElementType : Schema, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetManifestLocation(openXmlElement, value?.ManifestLocation);
      SetSchemaLocation(openXmlElement, value?.SchemaLocation);
      return openXmlElement;
    }
    return default;
  }
}