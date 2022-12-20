namespace DocumentModel.Properties;

/// <summary>
/// Defines the VectorVariantType Class.
/// </summary>
public partial class VectorVariantTypeImpl: ModelElementImpl, VectorVariantType
{
  public DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public VectorVariantTypeImpl(): base() {}
  
  public VectorVariantTypeImpl(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public virtual DocumentModel.VariantTypes.VTVector? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTVectorImpl(item);
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
          var newItem = (value as DocumentModel.VariantTypes.VTVectorImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
}
