namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Defines the VectorVariantType Class.
/// </summary>
public partial class VectorVariantType: ModelElementImpl
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VectorVariantType(): base() {}
  
  public VectorVariantType(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType openXmlElement): base(openXmlElement)
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
          return VTVectorConverter.GetValue(item);
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
          var vtVector = VTVectorConverter.CreateOpenXmlElement(value);
          if (vtVector != null)
            OpenXmlElement.AddChild(vtVector);
        }
      }
    }
  }
  
}
