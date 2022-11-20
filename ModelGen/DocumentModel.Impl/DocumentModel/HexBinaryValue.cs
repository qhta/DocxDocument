namespace DocumentModel;

/// <summary>
/// Represent the xsd:hexBinary value for attributes.
/// </summary>
public class HexBinaryValue: IHexBinaryValue
{
  /// <summary>
  /// Gets or sets the hex binary value
  /// </summary>
  public string? Value
  {
    get;
    set;
  }
  
}
