namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ObjectDefaults Class.
/// </summary>
public class ObjectDefaults: ModelElement
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