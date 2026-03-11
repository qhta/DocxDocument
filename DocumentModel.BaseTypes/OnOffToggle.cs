namespace DocumentModel;

/// <summary>
/// Specific logical type for flag values switching between on and off states, with an additional toggle state for switching to the opposite state.
/// </summary>
public enum OnOffToggle
{
  /// <summary>
  /// State is not defined,
  /// which can be used to represent an uninitialized state or a state where the on/off status is not applicable.
  /// </summary>
  Undefined = 0,

  /// <summary>
  /// State is on, indicating that the feature or setting is active or enabled.
  /// </summary>
  On = 1,

  /// <summary>
  /// State is off, indicating that the feature or setting is inactive or disabled.
  /// </summary>
  Off = 2,

  /// <summary>
  /// Represents a toggle control, which allows users to switch between two states such as on and off.
  /// </summary>
  Toggle = 3,
}