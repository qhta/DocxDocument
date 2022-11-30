namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public interface IColorsDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IColorDefinitionTitle>? ColorDefinitionTitles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IColorTransformDescription>? ColorTransformDescriptions { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IColorTransformStyleLabel>? ColorTransformStyleLabels { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
