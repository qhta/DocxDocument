namespace DocumentModel;
/// <summary>
/// Dual HPS. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
public record FontSizes
{
  private readonly IHps? _Val, _ValCS;
  /// <summary>
  /// Value for regular script.
  /// </summary>
  public IHps? Val { get => _Val; }
  /// <summary>
  /// Value for complex script.
  /// </summary>
  public IHps? ValCS { get => _ValCS; }
}