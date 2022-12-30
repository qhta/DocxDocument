namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public partial class Run
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties { get; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public String? Text { get; set; }
  
}
