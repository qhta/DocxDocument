namespace DocumentModel;

/// <summary>
/// Interface for converting specific types to and from their string representations, with support for specifying measure units.
/// </summary>
public interface IUniversalMeasureToStringConverter
{

  /// <summary>
  /// Gets or sets the measure units to be used for conversion.
  /// This property allows specifying the desired units (e.g., "mm", "cm", "pt", "in") for converting the specific type to and from its string representation.
  /// </summary>
  public MeasureUnit? MeasureUnits { get; set; }

  /// <summary>
  /// Converts an object of the specific type to its string representation using the specified measure unit.
  /// </summary>
  /// <param name="val">The object of the specific type to convert.</param>
  /// <param name="measureUnit">The measure unit to use for the conversion.</param>
  /// <returns>The string representation of the object.</returns>
  public string? ConvertToString(object? val, MeasureUnit measureUnit);

}