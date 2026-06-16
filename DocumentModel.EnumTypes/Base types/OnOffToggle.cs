namespace DocumentModel;

/// <summary>
/// On-off enumeration for properties that can be enabled, disabled, or toggled.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OnOffToggle
{
  ///// <summary>
  ///// Property is undefined, allowing for default behavior or inheritance from parent elements. This value indicates that the property has not been explicitly set to on, off, or toggle, and the system should determine the effective value based on context or defaults.
  ///// </summary>
  //Undefined = 0,
  /// <summary>
  /// Property is enabled or turned on, indicating that the associated feature or behavior is active. This value explicitly sets the property to an active state, overriding any default or inherited settings that may apply when the property is undefined.
  /// </summary>
  On = 1,
  /// <summary>
  /// Property is disabled or turned off, indicating that the associated feature or behavior is inactive. This value explicitly sets the property to an inactive state, overriding any default or inherited settings that may apply when the property is undefined.
  /// </summary>
  Off = 2,
  /// <summary>
  /// Property is toggled, indicating that the state of the property should be switched from its current value. When this value is used, the system will determine the new state by inverting the current state of the property (e.g., if it is currently on, it will be turned off, and vice versa). This allows for dynamic changes to the property state without needing to specify the exact desired state.
  /// </summary>
  Toggle = 3,
}

/// <summary>
/// Extension methods for the OnOffToggle enumeration, providing convenient conversions between OnOffToggle values and boolean values, with support for the Toggle state.
/// </summary>
public static class OnOffToggleTools
{
  /// <summary>
  /// Converts the OnOffToggle enumeration value to a boolean, where On is true, Off is false, and Toggle is null. If the value is undefined, it returns null.
  /// </summary>
  /// <param name="value">The OnOffToggle enumeration value to convert.</param>
  /// <returns>A nullable boolean representing the OnOffToggle state, where true corresponds to On, false corresponds to Off, and null corresponds to Toggle or Undefined.</returns>
  public static bool? ToBoolean(this OnOffToggle? value)
  {
    return value switch
    {
      OnOffToggle.On => true,
      OnOffToggle.Off => false,
      _ => null,
    };
  }
  /// <summary>
  /// Converts a nullable Boolean value to its corresponding nullable OnOffToggle enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If <see langword="true"/>, returns OnOffToggle.On; if <see langword="false"/>,
  /// returns OnOffToggle.Off; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>An OnOffToggle value representing the specified Boolean value, or <see langword="null"/> if the input is <see
  /// langword="null"/>.</returns>
  public static OnOffToggle? ToOnOffToggle(this bool? value)
  {
    return value switch
    {
      true => OnOffToggle.On,
      false => OnOffToggle.Off,
      null => null,
    };
  }
}
