namespace DocumentModel;

/// <summary>
/// Represent the xsd:hexBinary value for attributes.
/// </summary>
public interface IHexBinaryValue // : DocumentModel.IStringValue
{
  /// <summary>
  /// Gets or sets the hex binary value
  /// </summary>
  public String? Value { get ; set; }
  
}
