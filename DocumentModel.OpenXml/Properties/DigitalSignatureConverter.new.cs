namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Digital Signature converter from/to OpenXml.
///</summary>
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

  public static byte[]? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      return GetVTBlob(openXmlElement);
    }
    return null;
  }

  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature openXmlElement, byte[]? value)
  {
    SetVTBlob(openXmlElement, value);
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? CreateOpenXmlElement(byte[]? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature();
      SetVTBlob(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}