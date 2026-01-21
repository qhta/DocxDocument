namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents status text associated with a form field in a WordprocessingML document.
/// This interface provides properties for the type and value of status text, enabling advanced user feedback and contextual information for interactive form fields within documents.
/// </summary>
public partial class StatusText : ModelElement<DXW.StatusText>
{
  /// <summary>
  /// Type of status text, specifying the context or display mode (e.g., tooltip, status bar).
  /// </summary>
  public InfoTextKind? Type { get; set; }
  /// <summary>
  /// Value of the status text, containing the actual information or message to be displayed to the user.
  /// </summary>
  public string? Val { get; set; }
}