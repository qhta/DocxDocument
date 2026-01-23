namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked insertion revision for math control elements in a WordprocessingML document.
/// This class provides properties for author, date, annotation identifier, run formatting, and deleted math control, enabling tracking and management of mathematical content insertions within the document.
/// </summary>
public partial class InsertedMathControl : IdentifiedChange<DXW.InsertedMathControl>
{
  /// <summary>
  /// Run properties for the inserted math control, specifying character-level formatting.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  /// <summary>
  /// Deleted math control revision information, tracking removed mathematical content related to the insertion.
  /// </summary>
  public DeletedMathControl? DeletedMathControl { get; set; }
}