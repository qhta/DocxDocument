namespace DocumentModel;


/// <summary>
///   Represent the xsd:hexBinary value for attributes.
/// </summary>
public partial class HexBinaryValue
{
  
  /// <summary>
  ///   Gets or sets the hex binary value
  /// </summary>
  [Nullable((Byte)2)]
  public String? Value { get; set; }
  
}
