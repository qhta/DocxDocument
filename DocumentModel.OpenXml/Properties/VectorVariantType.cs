namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Defines the VectorVariantType Class.
/// </summary>
public class VectorVariantType : ModelElementImpl
{
  public VectorVariantType()
  {
  }

  public VectorVariantType(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }

  /// <summary>
  ///   Vector.
  /// </summary>
  public virtual VectorVariant? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTVector>();
        if (item != null)
          return VTVectorConverter.CreateModelElement(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTVector>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var vtVector = VTVectorConverter.CreateOpenXmlElement(value);
          if (vtVector != null)
            OpenXmlElement.AppendChild(vtVector);
        }
      }
    }
  }
}