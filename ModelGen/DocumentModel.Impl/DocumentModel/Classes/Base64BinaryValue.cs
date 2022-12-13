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
  
  public Base64BinaryValueImpl(): base() {}
  
  public Base64BinaryValueImpl(DocumentFormat.OpenXml.Base64BinaryValue openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the Base64 binary string value.
  /// </summary>
  public String? Value
  {
    get => (System.String?)OpenXmlElement?.Value;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Base64BinaryValue).GetProperty("Value").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
