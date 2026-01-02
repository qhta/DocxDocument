namespace DocumentModel;

/// <summary>
/// Interface for controls that can perform actions when invoked by the user.
/// </summary>
public interface IActionControl
{
  /// <summary>
  ///   Specifies the name of a callback function to be called when this control is invoked by the user.
  /// </summary>
  public string? OnAction { get; set; }
}