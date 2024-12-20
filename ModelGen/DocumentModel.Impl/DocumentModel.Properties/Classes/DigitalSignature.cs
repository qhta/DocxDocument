namespace DocumentModel.Properties;

/// <summary>
/// Digital Signature.
/// </summary>
public partial class DigitalSignatureImpl: ModelElementImpl, DigitalSignature
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DigitalSignatureImpl(): base() {}
  
  public DigitalSignatureImpl(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public byte[]? VTBlob
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
        if (item != null)
          return new DocumentModel.VariantImpl(item).Value as byte[];
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          //var newItem = (value as DocumentModel.VariantTypes.VTBlobImpl)?.OpenXmlElement;
          //if (newItem != null)
          //  OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
}
