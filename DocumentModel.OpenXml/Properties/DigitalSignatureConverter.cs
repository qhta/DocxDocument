namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Digital Signature.
/// </summary>
public static class DigitalSignatureConverter
{
  /// <summary>
  ///   Binary Blob.
  /// </summary>
  public static byte[]? GetVTBlob(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? openXmlElement)
  {
    if (openXmlElement?.VTBlob?.Text != null)
      return Convert.FromBase64String(openXmlElement.VTBlob.Text);
    return null;
  }

  public static void SetVTBlob(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? openXmlElement, byte[]? value)
  {
    if (openXmlElement?.VTBlob != null)
    {
      if (value != null)
        openXmlElement.VTBlob.Text = Convert.ToBase64String(value);
      else
        openXmlElement.VTBlob = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new VTBlob { Text = Convert.ToBase64String(value) });
    }
  }

  public static DocumentModel.Properties.DigitalSignature? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.DigitalSignature();
      value.VTBlob = GetVTBlob(openXmlElement)?.ToString();
      return value;
    }
    return null;
  }

  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature openXmlElement, DocumentModel.Properties.DigitalSignature? value)
  {
    if (value?.VTBlob != null)
      SetVTBlob(openXmlElement, Convert.FromBase64String(value.VTBlob));
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? CreateOpenXmlElement(DocumentModel.Properties.DigitalSignature? value)
  {
    if (value?.VTBlob != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature();
      SetVTBlob(openXmlElement, Convert.FromBase64String(value.VTBlob));
      return openXmlElement;
    }
    return null;
  }
}