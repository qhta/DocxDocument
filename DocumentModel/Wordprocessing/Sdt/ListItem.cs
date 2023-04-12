namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Combo Box List Item.
/// </summary>
public class ListItem: ModelElement
{
  /// <summary>
  ///   List Entry Display Text
  /// </summary>
  public String? DisplayText { get; set; }

  /// <summary>
  ///   List Entry Value
  /// </summary>
  public String? Value { get; set; }
}