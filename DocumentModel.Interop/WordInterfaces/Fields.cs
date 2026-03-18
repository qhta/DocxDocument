namespace DocumentModel.Interop;

/// <summary>
/// A collection of Field objects that represent all the fields in a selection, range, or document.
/// </summary>
public partial interface Fields : InteropObject, InteropCollection<Field>
{
  /// <summary>
  /// The locked.
  /// </summary>
  public int Locked { get; set; }
}
