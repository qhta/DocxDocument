namespace DocumentModel;

/// <summary>
/// Defines members that allow a control to specify or determine its enabled state.
/// </summary>
/// <remarks>Implement this interface to provide support for enabling or disabling a control, either by setting a
/// fixed enabled state or by specifying a callback function to determine the state dynamically. The Enabled and
/// GetEnabled properties are mutually exclusive; only one should be set. If neither property is specified, the control
/// is considered enabled by default. This interface does not allow enabling built-in controls that are disabled by the
/// application.</remarks>
public interface IEnableControl
{
  /// <summary>
  ///   Specifies the enabled state of the control.
  ///
  ///   The GetEnabled and Enabled attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled.
  ///
  ///   This attribute cannot be used to enable a built-in control that would otherwise be disabled by the application.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the enabled state of this control.
  ///
  ///   The GetEnabled and Enabled attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled.
  /// </summary>
  public string? GetEnabled { get; set; }


}