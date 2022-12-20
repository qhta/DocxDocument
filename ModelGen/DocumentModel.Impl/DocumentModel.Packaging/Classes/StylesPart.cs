namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public partial class StylesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, StylesPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.StylesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StylesPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StylesPartImpl(): base() {}
  
  public StylesPartImpl(DocumentFormat.OpenXml.Packaging.StylesPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Styles? Styles
  {
    get
    {
      if (OpenXmlElement?.Styles != null)
        return new DocumentModel.Wordprocessing.StylesImpl(OpenXmlElement.Styles);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.StylesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Styles = valueImpl.OpenXmlElement;
    }
  }
  
}
