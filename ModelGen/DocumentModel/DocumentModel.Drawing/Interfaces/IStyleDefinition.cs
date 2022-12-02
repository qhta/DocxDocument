namespace DocumentModel.Drawing;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyleDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  public Collection<IStyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public Collection<IStyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public IStyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public IScene3D? Scene3D { get ; set; }
  
  public Collection<IStyleLabel>? StyleLabels { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
