namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked move-to revision for math control elements in a WordprocessingML document.
/// This interface provides properties for run formatting, inserted math control, and deleted math control, enabling revision tracking and management of mathematical content moves within the document.
/// </summary>
public partial class MoveToMathControl : ModelElement<DXW.MoveToMathControl>
{
  /// <summary>
  /// Run properties for the moved math control, specifying character-level formatting.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  /// <summary>
  /// Inserted math control revision information, tracking newly added mathematical content.
  /// </summary>
  public InsertedMathControl? InsertedMathControl { get; set; }
  /// <summary>
  /// Deleted math control revision information, tracking removed mathematical content.
  /// </summary>
  public DeletedMathControl? DeletedMathControl { get; set; }
}