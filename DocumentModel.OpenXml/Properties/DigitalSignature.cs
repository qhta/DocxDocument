namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Digital Signature.
/// </summary>
public class DigitalSignature : ModelElementImpl
{
  public DigitalSignature()
  {
  }

  public DigitalSignature(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }

  /// <summary>
  ///   Binary Blob.
  /// </summary>
  public byte[]? VTBlob
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTBlob>();
        if (item != null)
          return VariantConverter.GetVariant(item).ToBytes();
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTBlob>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = VariantConverter.CreateOpenXmlElement(value);
          if (newItem != null)
            OpenXmlElement.AppendChild(newItem);
        }
      }
    }
  }
}