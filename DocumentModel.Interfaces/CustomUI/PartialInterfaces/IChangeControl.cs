namespace DocumentModel;

/// <summary>
/// Interface for controls that support change notification when their content is modified by the user.
/// </summary>
public interface IChangeControl
{
  /// <summary>
  ///   Specifies the name of a callback function to be called when the text in the control has been changed by the user.
  /// </summary>
  public string? OnChange { get; set; }
}