namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public partial class ChartStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartStylePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.ChartStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartStylePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartStylePartImpl(): base() {}
  
  public ChartStylePartImpl(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ChartStyle? ChartStyle
  {
    get
    {
      if (OpenXmlElement?.ChartStyle != null)
        return new DocumentModel.Drawings.ChartsStyle.ChartStyleImpl(OpenXmlElement.ChartStyle);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartsStyle.ChartStyleImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ChartStyle = valueImpl.OpenXmlElement;
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
