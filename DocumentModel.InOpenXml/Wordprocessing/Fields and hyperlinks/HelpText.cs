namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents help text associated with a form field in a WordprocessingML document.
/// This interface provides properties for the type and value of help text, enabling advanced user guidance and contextual assistance for interactive form fields within documents.
/// </summary>
public class HelpText: ModelElement
{
  /// <summary>
  /// Type of help text, specifying the context or display mode (e.g., tooltip, status bar).
  /// </summary>
  public InfoTextKind? Type { get; set; }

  /// <summary>
  /// Value of the help text, containing the actual guidance or information to be displayed to the user.
  /// </summary>
  public string? Val { get; set; }
}