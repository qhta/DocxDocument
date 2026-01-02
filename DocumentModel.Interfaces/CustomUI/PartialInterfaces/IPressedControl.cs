namespace DocumentModel;

/// <summary>
/// Interface for controls that can be in a pressed (toggled) state.
/// </summary>
public interface IPressedControl
{
  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the toggled state of this control.
  ///
  ///If this attribute is omitted, the control SHOULD default to the off state.
  /// </summary>
  public string? GetPressed { get; set; }
}