namespace DocumentModel;

/// <summary>
/// Represent the xsd:hexBinary value for attributes.
/// </summary>
public interface IHexBinaryValue // : DocumentModel.IStringValue
{
  public System.Boolean? IsValid { get ; set; }
  
  public System.Int32? Length { get ; set; }
  
  /// <summary>
  /// Gets or sets the hex binary value
  /// </summary>
  public System.String? Value { get ; set; }
  
}
