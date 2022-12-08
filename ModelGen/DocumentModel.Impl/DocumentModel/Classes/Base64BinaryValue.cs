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
    get;
    set;
  }
  
}
