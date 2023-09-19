namespace DocumentModel;


/// <summary>
///   Represents the xsd:base64Binary value for attributes.
/// </summary>
public partial class Base64BinaryValue
{
  
  /// <summary>
  ///   Gets or sets the Base64 binary string value.
  /// </summary>
  [Nullable((Byte)2)]
  public String? Value { get; set; }
  
}
