namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public interface IStylesPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public IStyles? Styles { get ; set; }
  
}
