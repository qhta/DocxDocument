namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public partial interface Tasks
{
  /// <summary>
  /// Gets the DocumentTasksPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.DocumentTasksPart? DocumentTasksPart { get; set; }
  
  public Collection<DocumentModel.Task>? Items { get; set; }
  
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
}
