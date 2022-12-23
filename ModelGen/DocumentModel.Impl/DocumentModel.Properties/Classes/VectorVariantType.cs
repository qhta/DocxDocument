namespace DocumentModel.Properties;

/// <summary>
/// Defines the VectorVariantType Class.
/// </summary>
public partial class VectorVariantTypeImpl: ModelElementImpl, VectorVariantType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VectorVariantTypeImpl(): base() {}
  
  public VectorVariantTypeImpl(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public virtual DocumentModel.VectorVariant? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          return new VTVectorImpl(item).GetValue();
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var vtVector = new VTVectorImpl { Value = value }.OpenXmlElement;
          if (vtVector != null)
            OpenXmlElement.AddChild(vtVector);
        }
      }
    }
  }
  
}
