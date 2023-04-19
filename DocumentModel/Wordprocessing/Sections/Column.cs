namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Single Column Definition.
/// </summary>
public class Column: ModelElement
{
  /// <summary>
  ///   Column Width
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   Space Before Following Column
  /// </summary>
  public string? Space { get; set; }
}