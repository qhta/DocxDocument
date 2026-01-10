namespace DocumentModel.Wordprocessing.VBA;

/// <summary>
/// Represents a macro WLL (Word Link Library) type for VBA in a Wordprocessing document.
/// This interface provides a property for the macro name, enabling identification and management of macro WLL types in VBA-enabled documents.
/// </summary>
public interface MacroWllType
{

  /// <summary>
  /// The name of the macro associated with this WLL type.
  /// </summary>
  public string? MacroName { get; set; }
}