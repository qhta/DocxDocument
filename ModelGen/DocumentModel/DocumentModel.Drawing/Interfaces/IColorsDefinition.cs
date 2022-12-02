namespace DocumentModel.Drawing;

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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IColorDefinitionTitle>? ColorDefinitionTitles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IColorTransformDescription>? ColorTransformDescriptions { get ; set; }
  
  public DocumentModel.Drawing.IColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IColorTransformStyleLabel>? ColorTransformStyleLabels { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
