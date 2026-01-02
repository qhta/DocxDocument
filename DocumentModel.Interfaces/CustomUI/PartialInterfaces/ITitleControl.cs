namespace DocumentModel;

/// <summary>
/// Defines members for specifying a title to be displayed by a control, either as a static string or by referencing a
/// callback function that determines the title at runtime.
/// </summary>
/// <remarks>Implementations should ensure that only one of the Title or GetTitle properties is set at a time, as
/// they are mutually exclusive. If neither property is set, no title is displayed for the control.</remarks>
public interface ITitleControl
{
  /// <summary>
  ///   Specifies a string to be displayed as the title of the control.
  ///
  ///   The Title and GetTitle attributes are mutually exclusive. If neither attribute is specified, no title SHOULD be shown.
  /// </summary>
  public string? Title { get; set; }
  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the title of this control.
  ///
  ///  The Title and GetTitle attributes are mutually exclusive. If neither attribute is specified no title SHOULD be shown.
  /// </summary>
  public string? GetTitle { get; set; }
}