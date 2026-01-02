namespace DocumentModel;

/// <summary>
/// Represents a collection of selectable items within a user interface element, such as a list or combo box.
/// </summary>
public interface ISelectionItems: IElementCollection<ISelectionItem>
{
  /// <summary>
  ///   Specifies a string to be used as the label for this control.
  /// </summary>
  public string? Label { get; set; }

}