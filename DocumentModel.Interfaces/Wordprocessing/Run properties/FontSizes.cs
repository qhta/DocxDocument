namespace DocumentModel;
/// <summary>
/// Dual HPS. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
public interface FontSizes
{

  /// <summary>
  /// Value for regular script.
  /// </summary>
  public IHps? Val { get; set; }
  /// <summary>
  /// Value for complex script.
  /// </summary>
  public IHps? ValCS { get; set; }
}