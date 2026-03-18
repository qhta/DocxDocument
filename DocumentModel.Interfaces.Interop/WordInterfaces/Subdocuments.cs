namespace DocumentModel.Interop;

/// <summary>
/// A collection of Subdocument objects that represent the subdocuments in a range or document.
/// </summary>
public partial interface Subdocuments : InteropObject, InteropCollection<Subdocument>
{
  /// <summary>
  /// The expanded.
  /// </summary>
  public bool Expanded { get; set; }
}
