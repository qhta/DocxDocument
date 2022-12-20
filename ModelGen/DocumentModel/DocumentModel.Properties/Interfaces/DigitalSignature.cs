namespace DocumentModel.Properties;

/// <summary>
/// Digital Signature.
/// </summary>
public partial interface DigitalSignature
{
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public DocumentModel.VariantTypes.VTBlob? VTBlob { get; set; }
  
}
