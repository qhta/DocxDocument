namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a change to paragraph numbering properties in a WordprocessingML document.
/// This interface extends <see cref="IdentifiedChange"/> and provides a property for the original numbering value, enabling tracking and management of revisions to paragraph numbering.
/// </summary>
public interface NumberingChange : IdentifiedChange
{
  /// <summary>
  /// Original numbering value before the change, used for comparison and revision tracking.
  /// </summary>
  public string? Original { get; set; }
}