namespace DocumentModel.Drawing;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyleDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public DocumentModel.Drawing.IStyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public DocumentModel.Drawing.IScene3D? Scene3D { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStyleLabel>? StyleLabels { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
