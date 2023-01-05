namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Digital Signature.
/// </summary>
public partial class DigitalSignature: ModelElementImpl
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DigitalSignature(): base() {}
  
  public DigitalSignature(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature openXmlElement): base(openXmlElement)
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
          return VariantConverter.CreateModelElement(item).ToBytes();
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
          var newItem = VariantConverter.CreateOpenXmlElement(value);
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
}
