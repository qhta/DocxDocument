namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public class StylesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, StylesPart
{
  public new DocumentFormat.OpenXml.Packaging.StylesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StylesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Styles? Styles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
