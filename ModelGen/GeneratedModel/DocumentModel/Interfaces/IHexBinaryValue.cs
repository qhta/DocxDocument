namespace DocumentModel;

/// <summary>
/// Represent the xsd:hexBinary value for attributes.
/// </summary>
public interface IHexBinaryValue // : DocumentFormat.OpenXml.StringValue
{
  /// <summary>
  /// Gets or sets the hex binary value
  /// </summary>
  public string? Value { get ; set; }
  
}
