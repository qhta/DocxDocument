namespace DocumentModel;

/// <summary>
/// Represents the xsd:base64Binary value for attributes.
/// </summary>
public class Base64BinaryValueImpl: ModelObjectImpl, Base64BinaryValue
{
  public DocumentFormat.OpenXml.Base64BinaryValue? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Base64BinaryValue?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the Base64 binary string value.
  /// </summary>
  public String? Value
  {
    get => (String?)OpenXmlElement?.Value;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Base64BinaryValue).GetProperty("Value").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
