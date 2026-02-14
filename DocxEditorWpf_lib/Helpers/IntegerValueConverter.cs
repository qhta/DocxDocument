namespace DocxEditor.Helpers;

/// <summary>
/// Converts integer values to double and back for data binding scenarios in WPF.
/// </summary>
public class IntegerValueConverter : IValueConverter
{
    /// <summary>
    /// Converts an integer value to a double for use in the target binding.
    /// </summary>
    /// <param name="value">The source value, expected to be an integer.</param>
    /// <param name="targetType">The type of the binding target property.</param>
    /// <param name="parameter">Optional parameter for the converter (not used).</param>
    /// <param name="culture">The culture to use in the converter.</param>
    /// <returns>
    /// A double representation of the integer value, or null if the input is null.
    /// Throws <see cref="NotImplementedException"/> if conversion is not supported.
    /// </returns>
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
        if (value == null)
        {
            return null;
        }
        if (value is int intValue && targetType == typeof(Double))
        {
            return System.Convert.ToDouble(intValue);
        }
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a double value back to an integer for use in the source binding.
    /// </summary>
    /// <param name="value">The value produced by the binding target, expected to be a double.</param>
    /// <param name="targetType">The type to convert to, typically integer.</param>
    /// <param name="parameter">Optional parameter for the converter (not used).</param>
    /// <param name="culture">The culture to use in the converter.</param>
    /// <returns>
    /// An integer representation of the double value, or null if the input is null.
    /// Throws <see cref="NotImplementedException"/> if conversion is not supported.
    /// </returns>
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null)
            return null;
        targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
        if (targetType == typeof(object))
            targetType = typeof(int);
        if (value is double doubleValue && targetType == typeof(int))
        {
            return System.Convert.ToInt32(doubleValue);
        }
        throw new NotImplementedException();
    }
}
