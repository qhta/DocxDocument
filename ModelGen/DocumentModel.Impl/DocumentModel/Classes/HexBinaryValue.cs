namespace DocumentModel;

/// <summary>
/// Represent the xsd:hexBinary value for attributes.
/// </summary>
public class HexBinaryValueImpl: ModelObjectImpl, HexBinaryValue
{
  public DocumentFormat.OpenXml.HexBinaryValue? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.HexBinaryValue?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HexBinaryValueImpl(): base() {}
  
  public HexBinaryValueImpl(DocumentFormat.OpenXml.HexBinaryValue openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the hex binary value
  /// </summary>
  public String? Value
  {
    get => (String?)OpenXmlElement?.Value;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.HexBinaryValue).GetProperty("Value").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
