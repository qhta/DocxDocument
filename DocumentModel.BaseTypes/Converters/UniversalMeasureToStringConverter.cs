using System.Reflection;

namespace DocumentModel;

/// <summary>
/// A generic converter class that converts between a specific type of UniversalMeasure and its string representation.
/// </summary>
/// <typeparam name="SpecificType"></typeparam>
public class UniversalMeasureToStringConverter<SpecificType> : TypeToStringConverter, IUniversalMeasureToStringConverter
  where SpecificType : UniversalMeasure
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
  public string? ConvertToString(object? val, MeasureUnit measureUnit) => (val is UniversalMeasure um) ? um.ToString(measureUnit) : null;

  /// <summary>
  /// Converts an object of the specific type to its string representation.
  /// </summary>
  /// <param name="val">The object of the specific type to convert.</param>
  /// <returns>The string representation of the object.</returns>
  public override string? ConvertToString(object? val) => (val is UniversalMeasure um) ? (MeasureUnits != null) ? um.ToString(MeasureUnits.Value) : um.ToString() : null;

  /// <summary>
  /// Converts a string representation back to an object of the specific type.
  /// </summary>
  /// <param name="str">The string representation of the object.</param>
  /// <returns>The object of the specific type represented by the string.</returns>
  public override object? ConvertFromString(string? str)
  {
    var parseMethod = typeof(SpecificType).GetMethod("Parse", BindingFlags.Public | BindingFlags.Static, null, [typeof(string)
    ], null);
    var result = parseMethod!.Invoke(null, [str])!;
    return result;

  }

}