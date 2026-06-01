namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Combo Box IList Item.
/// </summary>
public class ListItem: ModelElement
{
  /// <summary>
  ///   IList Entry Display Text
  /// </summary>
  public string? DisplayText { get; set; }

  /// <summary>
  ///   IList Entry Value
  /// </summary>
  public string? Value { get; set; }
}
