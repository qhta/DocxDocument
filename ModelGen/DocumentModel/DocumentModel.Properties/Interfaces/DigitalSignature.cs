namespace DocumentModel.Properties;

/// <summary>
/// Digital Signature.
/// </summary>
public partial interface DigitalSignature
{
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public byte[]? VTBlob { get; set; }
  
}
