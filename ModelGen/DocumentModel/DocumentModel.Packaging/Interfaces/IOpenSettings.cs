namespace DocumentModel.Packaging;

/// <summary>
/// Represents the settings when opening a document.
/// </summary>
public interface IOpenSettings // : 
{
  /// <summary>
  /// Gets or sets a value indicating whether to auto save document modifications.
  /// </summary>
  public System.Boolean? AutoSave { get ; set; }
  
  /// <summary>
  /// Gets or sets the value of the markup compatibility processing mode.
  /// </summary>
  public DocumentModel.Packaging.IMarkupCompatibilityProcessSettings? MarkupCompatibilityProcessSettings { get ; set; }
  
}
