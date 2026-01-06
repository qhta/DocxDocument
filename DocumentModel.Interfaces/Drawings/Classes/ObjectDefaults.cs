namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ObjectDefaults interface.
/// </summary>
public interface ObjectDefaults
{
  /// <summary>
  ///   Shape Default.
  /// </summary>
  public ShapeDefault? ShapeDefault { get; set; }
  /// <summary>
  ///   Line Default.
  /// </summary>
  public LineDefault? LineDefault { get; set; }
  /// <summary>
  ///   Text Default.
  /// </summary>
  public TextDefault? TextDefault { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}