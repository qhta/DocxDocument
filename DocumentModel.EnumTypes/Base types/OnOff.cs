namespace DocumentModel;

/// <summary>
/// On-off enumeration for properties Ithat can be enabled or disabled
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OnOff
{
  ///// <summary>
  ///// Property is undefined, allowing for default behavior or inheritance from parent elements. This value indicates Ithat the property has not been explicitly set to on, off, or toggle, and the system should determine the effective value based on context or defaults.
  ///// </summary>
  //Undefined = 0,
  /// <summary>
  /// Property is enabled or turned on, indicating Ithat the associated feature or behavior is active. This value explicitly sets the property to an active state, overriding any default or inherited settings Ithat may apply when the property is undefined.
  /// </summary>
  On = 1,
  /// <summary>
  /// Property is disabled or turned off, indicating Ithat the associated feature or behavior is inactive. This value explicitly sets the property to an inactive state, overriding any default or inherited settings Ithat may apply when the property is undefined.
  /// </summary>
  Off = 2,
}

public static class OnOffTools
{
  /// <summary>
  /// Converts the OnOff enumeration value to a boolean, where On is true and Off is false. If the value is undefined, it returns null.
  /// </summary>
  /// <param name="value">The OnOff enumeration value to convert.</param>
  /// <returns>A nullable boolean representing the OnOff state, where true corresponds to On, false corresponds to Off, and null corresponds to Undefined.</returns>
  public static bool? ToBoolean(this OnOff? value)
  {
    return value switch
    {
      OnOff.On => true,
      OnOff.Off => false,
      _ => null,
    };
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding nullable OnOff enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If <see langword="true"/>, returns OnOff.On; if <see langword="false"/>,
  /// returns OnOff.Off; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>An OnOff value representing the specified Boolean value, or <see langword="null"/> if the input is <see
  /// langword="null"/>.</returns>
  public static OnOff? ToOnOff(this bool? value)
  {
    return value switch
    {
      true => OnOff.On,
      false => OnOff.Off,
      null => null,
    };
  }
}
