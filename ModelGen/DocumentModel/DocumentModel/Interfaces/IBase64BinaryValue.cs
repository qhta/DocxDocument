namespace DocumentModel;

/// <summary>
/// Represents the xsd:base64Binary value for attributes.
/// </summary>
public interface IBase64BinaryValue // : DocumentModel.IStringValue
{
  /// <summary>
  /// Gets or sets the Base64 binary string value.
  /// </summary>
  public System.String? Value { get ; set; }
  
  public System.Boolean? IsValid { get ; set; }
  
  public System.Int32? Length { get ; set; }
  
}
