namespace DocumentModel;

/// <summary>
/// Represents the xsd:base64Binary value for attributes.
/// </summary>
public class Base64BinaryValue: IBase64BinaryValue
{
  /// <summary>
  /// Gets or sets the Base64 binary string value.
  /// </summary>
  public string? Value
  {
    get;
    set;
  }
  
}
