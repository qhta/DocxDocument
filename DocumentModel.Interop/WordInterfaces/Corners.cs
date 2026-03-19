namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the corners of a 3-D chart.
/// </summary>
public partial interface Corners : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
}
