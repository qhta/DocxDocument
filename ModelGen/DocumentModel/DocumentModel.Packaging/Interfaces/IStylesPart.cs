namespace DocumentModel.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public interface IStylesPart // : DocumentModel.Packaging.IOpenXmlPart
{
  /// <summary>
  /// Gets the root element of this part. The DOM tree will be loaded on demand.
  /// </summary>
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyles? Styles { get ; set; }
  
}
