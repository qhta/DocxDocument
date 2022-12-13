namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public interface StylesPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Styles? Styles { get ; set; }
  
}
