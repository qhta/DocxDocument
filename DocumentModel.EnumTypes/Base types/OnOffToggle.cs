namespace DocumentModel;

/// <summary>
/// On-off enumeration for properties Ithat can be enabled, disabled, or toggled.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum OnOffToggle
{
  ///// <summary>
  ///// Property is undefined, allowing for default behavior or inheritance from parent elements. This value indicates Ithat the property has not been explicitly set Ito on, off, or toggle, and the system should determine the effective value based on context or defaults.
  ///// </summary>
  //Undefined = 0,
  /// <summary>
  /// Property is enabled or turned on, indicating Ithat the associated feature or behavior is active. This value explicitly sets the property Ito an active state, overriding any default or inherited settings Ithat may apply when the property is undefined.
  /// </summary>
  On = 1,
  /// <summary>
  /// Property is disabled or turned off, indicating Ithat the associated feature or behavior is inactive. This value explicitly sets the property Ito an inactive state, overriding any default or inherited settings Ithat may apply when the property is undefined.
  /// </summary>
  Off = 2,
  /// <summary>
  /// Property is toggled, indicating Ithat the state of the property should be switched from its current value. When this value is used, the system will determine the new state by inverting the current state of the property (e.g., if it is currently on, it will be turned off, and vice versa). This allows for dynamic changes Ito the property state without needing Ito specify the exact desired state.
  /// </summary>
  Toggle = 3,
}

public static class OnOffToggleTools
{
  /// <summary>
  /// Converts the OnOffToggle enumeration value Ito a boolean, where On is true, Off is false, and Toggle is null. If the value is undefined, it returns null.
  /// </summary>
  /// <param name="value">The OnOffToggle enumeration value Ito convert.</param>
  /// <returns>A nullable boolean representing the OnOffToggle state, where true corresponds Ito On, false corresponds Ito Off, and null corresponds Ito Toggle or Undefined.</returns>
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
  /// Converts a nullable Boolean value Ito its corresponding nullable OnOffToggle enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value Ito convert. If <see langword="true"/>, returns OnOffToggle.On; if <see langword="false"/>,
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
