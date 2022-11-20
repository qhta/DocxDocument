namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Digital Signature.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBlob))]
public class DigitalSignature: IDigitalSignature
{
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public IVTBlob? VTBlob
  {
    get;
    set;
  }
  
}
