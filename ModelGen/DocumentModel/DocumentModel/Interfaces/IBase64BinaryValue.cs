namespace DocumentModel;

/// <summary>
/// Represents the xsd:base64Binary value for attributes.
/// </summary>
public interface IBase64BinaryValue // : DocumentModel.IStringValue
{
  /// <summary>
  /// Gets or sets the Base64 binary string value.
  /// </summary>
  public String? Value { get ; set; }
  
}
