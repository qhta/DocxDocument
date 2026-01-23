
namespace DocumentModel.OpenXml;


/// <summary>
/// Provides utility methods for converting simple values between types, including support for implicit conversion operators.
/// </summary>
public static class SimpleValueConverter
{
  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ChangeType(object? value, Type targetType)
  {
    if (TryImplicitConvert(value, targetType, out var result))
      return result;
    return Convert.ChangeType(value, targetType);

  }

  /// <summary>
  /// Attempts to convert a value to the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public static bool TryImplicitConvert(object? source, Type targetType, out object? result)
  {
    result = null;
    if (source == null) return true;

    var sourceType = source.GetType();
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static));

    var op = methods.FirstOrDefault(m =>
      m.Name == "op_Implicit" &&
      m.ReturnType == targetType &&
      m.GetParameters() is [{ ParameterType: var p }] &&
      p.IsAssignableFrom(sourceType));

    if (op == null) return false;

    result = op.Invoke(null, [source]);
    return true;
  }
}
