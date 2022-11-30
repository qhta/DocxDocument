namespace DocumentModel.Drawing.Diagrams;

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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IStyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IStyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IStyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IScene3D? Scene3D { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IStyleLabel>? StyleLabels { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
