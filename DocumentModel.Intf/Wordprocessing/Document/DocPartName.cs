namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Entry Name.
/// </summary>
public class DocPartName: ModelElement
{
  /// <summary>
  ///   Name Value
  /// </summary>
  public string? Val { get; set; }

  /// <summary>
  ///   Built-In Entry
  /// </summary>
  public bool? Decorated { get; set; }
}