namespace DocumentModel.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public partial class TitlesOfPartsImpl: ModelElementImpl, TitlesOfParts
{
  public DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TitlesOfPartsImpl(): base() {}
  
  public TitlesOfPartsImpl(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public DocumentModel.VariantTypes.VTVector? VTVector
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
