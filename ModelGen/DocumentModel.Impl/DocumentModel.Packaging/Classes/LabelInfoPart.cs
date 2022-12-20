namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LabelInfoPart
/// </summary>
public partial class LabelInfoPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, LabelInfoPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.LabelInfoPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.LabelInfoPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LabelInfoPartImpl(): base() {}
  
  public LabelInfoPartImpl(DocumentFormat.OpenXml.Packaging.LabelInfoPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.ClassificationLabelList? ClassificationLabelList
  {
    get
    {
      if (OpenXmlElement?.ClassificationLabelList != null)
        return new DocumentModel.ClassificationLabelListImpl(OpenXmlElement.ClassificationLabelList);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.ClassificationLabelListImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ClassificationLabelList = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
