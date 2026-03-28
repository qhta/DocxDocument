namespace DocumentModel.Interop;

/// <summary>
/// A collection of Comment objects that represent the comments in a selection, range, or document.
/// </summary>
public partial interface Comments : InteropObject, InteropCollection<Comment>
{
  /// <summary>
  /// The show by.
  /// </summary>
  public string ShowBy { get; set; }
}
