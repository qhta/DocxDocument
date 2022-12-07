namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public class StylesPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, StylesPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Styles? Styles
  {
    get;
    set;
  }
  
}
