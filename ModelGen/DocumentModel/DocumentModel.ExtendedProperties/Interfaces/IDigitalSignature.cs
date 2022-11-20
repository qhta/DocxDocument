namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Digital Signature.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBlob))]
public interface IDigitalSignature // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public IVTBlob? VTBlob { get ; set; }
  
}
