namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Single IColumn Definition.
/// </summary>
public class IColumn: ModelElement
{
  /// <summary>
  ///   IColumn Width
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   Space Before Following IColumn
  /// </summary>
  public string? Space { get; set; }
}
