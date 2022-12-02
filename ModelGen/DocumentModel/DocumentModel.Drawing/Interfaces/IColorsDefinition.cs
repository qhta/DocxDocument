namespace DocumentModel.Drawing;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public interface IColorsDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  public Collection<IColorDefinitionTitle>? ColorDefinitionTitles { get ; set; }
  
  public Collection<IColorTransformDescription>? ColorTransformDescriptions { get ; set; }
  
  public IColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public Collection<IColorTransformStyleLabel>? ColorTransformStyleLabels { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
