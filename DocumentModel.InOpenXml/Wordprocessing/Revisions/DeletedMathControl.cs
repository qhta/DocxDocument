namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked deletion revision for math control elements in a WordprocessingML document.
/// This interface provides properties for author, date, annotation identifier, and run formatting, enabling tracking and management of mathematical content deletions within the document.
/// </summary>
public partial class DeletedMathControl : IdentifiedChange
{
  /// <summary>
  /// Run properties for the deleted math control, specifying character-level formatting.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}