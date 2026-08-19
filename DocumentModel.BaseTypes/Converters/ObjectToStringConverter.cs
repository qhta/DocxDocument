using System.Reflection;

namespace DocumentModel;

/// <summary>
/// Converter class for converting objects to their string representation. This class maintains a mapping of types to custom conversion functions, allowing for flexible and extensible string conversion logic. When an object is passed to the ConvertToString method, it checks if there is a registered converter for the object's type and uses it to convert the object to a string. If no converter is found, it falls back to the default ToString() method of the object. This design allows for easy customization of how specific types are represented as strings without modifying the core logic of the conversion process.
/// </summary>
public static class ObjectToStringConverter
{
  private static readonly Dictionary<Type, TypeToStringConverter> _converts = new();


  static ObjectToStringConverter()
  {
    RegisterConverter(typeof(string), new ObjToStringConverter());
    RegisterConverter(typeof(Boolean), new BooleanToStringConverter());
    RegisterConverter(typeof(SByte), new SByteToStringConverter());
    RegisterConverter(typeof(Int16), new Int16TypeToStringConverter());
    RegisterConverter(typeof(Int32), new Int32TypeToStringConverter());
    RegisterConverter(typeof(Int64), new Int64TypeToStringConverter());
    RegisterConverter(typeof(Byte), new ByteToStringConverter());
    RegisterConverter(typeof(UInt16), new UInt16TypeToStringConverter());
    RegisterConverter(typeof(UInt32), new UInt32TypeToStringConverter());
    RegisterConverter(typeof(UInt64), new UInt64TypeToStringConverter());
    RegisterConverter(typeof(Single), new SingleToStringConverter());
    RegisterConverter(typeof(Double), new DoubleToStringConverter());
    RegisterConverter(typeof(Decimal), new DecimalToStringConverter());
    RegisterConverter(typeof(DateTime), new DateTimeToStringConverter());
    RegisterConverter(typeof(HexBinary), new HexBinaryToStringConverter());
    RegisterConverter(typeof(HexByte), new HexByteToStringConverter());
    RegisterConverter(typeof(HexChar), new HexCharToStringConverter());
    RegisterConverter(typeof(HexColor), new HexColorToStringConverter());
    RegisterConverter(typeof(HexInt), new HexIntToStringConverter());
    RegisterConverter(typeof(HexLong), new HexLongToStringConverter());
    RegisterConverter(typeof(HexPercent), new HexPercentToStringConverter());
    RegisterConverter(typeof(BytePercent), new BytePercentToStringConverter());
    RegisterConverter(typeof(Percentage), new PercentageToStringConverter());
    RegisterConverter(typeof(Degrees), new DegreesToStringConverter());
    RegisterConverter(typeof(StringList), new StringListToStringConverter());
  }

  /// <summary>
  /// Registers a custom converter for a specific type, allowing for flexible and extensible string conversion logic.
  /// The converter parameter is an instance of the TypeToStringConverter class,
  /// which encapsulates the logic for converting an object of the specified type to its string representation and vice versa.
  /// By registering this converter, you can customize how the specified type is represented as a string
  /// and how it is reconstructed from its string representation without modifying the core logic of the conversion process.
  /// </summary>
  /// <param name="type">The type for which the converter is being registered.</param>
  /// <param name="converter">The TypeToStringConverter instance that handles the conversion logic for the specified type.</param>
  public static void RegisterConverter(Type type, TypeToStringConverter converter)
  {
    _converts[type] = converter;
  }

  /// <summary>
  /// Converts an object to its string representation using a predefined mapping of types to conversion functions.
  /// If the object's type is not found in the mapping, it converts the object using the JsonSerializer Serialize method.
  /// </summary>
  /// <param name="value">The object to convert to a string.</param>
  /// <returns>The string representation of the object, or null if the object is null.</returns>
  public static string? ConvertToJsonString(object? value)
  {
    if (value == null)
      return null;

    var type = value.GetType();
    if (_converts.TryGetValue(type, out var converter))
    {
      return converter.ConvertToString(value);
    }
    else if (value is Enum enumValue)
    {
      return enumValue.ToString();
    }
    var str = JsonSerializer.Serialize(value, type, new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull });
    str = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(str));
    return str;
  }


  /// <summary>
  /// Converts an object to its string representation using a predefined mapping of types to conversion functions.
  /// If the object's type is not found in the mapping, and the value type has Parse(string) method, it falls back to the default ToString() method.
  /// Otherwise, it returns null.
  /// </summary>
  /// <param name="value">The object to convert to a string.</param>
  /// <param name="measureUnits">A string representing the measure units to use in the conversion.</param>
  /// <returns>The string representation of the object, or null if the object is null.</returns>
  public static string? ConvertToString(object? value, MeasureUnit? measureUnits = null)
  {
    if (value == null)
      return null;

    var type = value.GetType();
    if (type == typeof(Twips))
      Debug.Assert(true);
    if (_converts.TryGetValue(type, out var converter))
    {
      if (converter is IUniversalMeasureToStringConverter umConverter && measureUnits != null)
        return umConverter.ConvertToString(value, measureUnits.Value);
      else
        return converter.ConvertToString(value);
    }
    else if (value is Enum enumValue)
    {
      return enumValue.ToString();
    }
    var targetType = value.GetType();
    var parseMethod = targetType.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static,  null, [typeof(string)], null);
    // To assure deserialization, the value will be converted to string only when the type has a Parse(string) method.
    if (parseMethod is not null)
    {
      {
        var str = value.ToString();
        return str;
      }
    }
    return null;
  }

  /// <summary>
  /// Converts a string back to an object of the specified target type using a predefined mapping of types to conversion functions.
  /// If the target type is not found in the mapping, it converts the string using the JsonSerializer Deserialize method.
  /// </summary>
  /// <param name="str">The string representation of the object to convert.</param>
  /// <param name="targetType">The target type to convert the string to.</param>
  /// <returns>The converted object, or null if the conversion fails or the target type is not found.</returns>
  public static object? ConvertFromJsonString(string? str, Type targetType)
  {
    if (str == null)
      return null;

    if (_converts.TryGetValue(targetType, out var converter))
    {
      var result = converter.ConvertFromString(str);
      return result;
    }
    else if (targetType.IsEnum)
    {
      return Enum.Parse(targetType, str);
    }
    else
    {
      str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(str));
      var result = JsonSerializer.Deserialize(str, targetType);
      return result;
    }
  }

  /// <summary>
  /// Converts a string back to an object of the specified target type using a predefined mapping of types to conversion functions.
  /// If the target type is not found in the mapping, it converts the string using the type Parse(string) method.
  /// </summary>
  /// <param name="str">The string representation of the object to convert.</param>
  /// <param name="targetType">The target type to convert the string to.</param>
  /// <returns>The converted object, or null if the conversion fails or the target type is not found.</returns>
  public static object? ConvertFromString(string? str, Type targetType)
  {
    if (str == null)
      return null;

    if (_converts.TryGetValue(targetType, out var converter))
    {
      var result = converter.ConvertFromString(str);
      return result;
    }
    else if (targetType.IsEnum)
    {
      return Enum.Parse(targetType, str);
    }
    else
    {
      var parseMethod = targetType.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static, null, [typeof(string)], null);
      var result = parseMethod!.Invoke(null, [str])!;
      return result;
    }
  }

  /// <summary>
  /// A converter class that provides methods to convert an object to a string and vice versa.
  /// Used as a default converter for types that do not have specific conversion logic defined.
  /// </summary>
  public class ObjToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts an object to its string representation. If the object is null, it returns null. Otherwise, it casts the object to a string and returns it.
    /// </summary>
    /// <param name="val">The object to convert to a string.</param>
    /// <returns>The string representation of the object, or null if the object is null.</returns>
    public override string? ConvertToString(object? val) => (string?)val;
    /// <summary>
    /// Converts a string back to an object. If the string is null, it returns null. Otherwise, it casts the string to an object and returns it.  
    /// </summary>
    /// <param name="str">The string to convert to an object.</param>
    /// <returns>The object representation of the string, or null if the string is null.</returns>
    public override object? ConvertFromString(string? str) => (string?)str;
  }

  /// <summary>
  /// A converter class that provides methods to convert a boolean value to a string and vice versa.
  /// </summary>
  public class BooleanToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a boolean val to its string representation. If the val is null, it returns null. Otherwise, it converts the boolean to a lowercase string ("true" or "false").
    /// </summary>
    /// <param name="val">The boolean val to convert to a string.</param>
    /// <returns>The string representation of the boolean val, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString()?.ToLower();
    /// <summary>
    /// Converts a string back to a boolean value. If the string is null or empty, it returns null. Otherwise, it parses the string to a boolean value.
    /// </summary>
    /// <param name="str">The string to convert to a boolean value.</param>
    /// <returns>The boolean value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Boolean.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a signed byte (sbyte) value to a string and vice versa.
  /// </summary>
  public class SByteToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a signed byte (sbyte) value to its string representation. If the val is null, it returns null. Otherwise, it converts the sbyte to a string.
    /// </summary>
    /// <param name="val">The signed byte (sbyte) value to convert to a string.</param>
    /// <returns>The string representation of the signed byte (sbyte) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a signed byte (sbyte) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a signed byte (sbyte) value.
    /// </summary>
    /// <param name="str">The string to convert to a signed byte (sbyte) value.</param>
    /// <returns>The signed byte (sbyte) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : SByte.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a 32-bit signed integer (Int32) value to a string and vice versa.
  /// </summary>
  public class Int32TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 32-bit signed integer (Int32) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Int32 to a string.
    /// </summary>
    /// <param name="val">The 32-bit signed integer (Int32) value to convert to a string.</param>
    /// <returns>The string representation of the 32-bit signed integer (Int32) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 32-bit signed integer (Int32) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 32-bit signed integer (Int32) value.
    /// </summary>
    /// <param name="str">The string to convert to a 32-bit signed integer (Int32) value.</param>
    /// <returns>The 32-bit signed integer (Int32) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Int32.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a 64-bit signed integer (Int64) value to a string and vice versa.
  /// </summary>
  public class Int64TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 64-bit signed integer (Int64) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Int64 to a string. 
    /// </summary>
    /// <param name="val">The 64-bit signed integer (Int64) value to convert to a string.</param>
    /// <returns>The string representation of the 64-bit signed integer (Int64) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 64-bit signed integer (Int64) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 64-bit signed integer (Int64) value.
    /// </summary>
    /// <param name="str">The string to convert to a 64-bit signed integer (Int64) value.</param>
    /// <returns>The 64-bit signed integer (Int64) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Int64.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a 16-bit signed integer (Int16) value to a string and vice versa.
  /// </summary>
  public class Int16TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 16-bit signed integer (Int16) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Int16 to a string.
    /// </summary>
    /// <param name="val">The 16-bit signed integer (Int16) value to convert to a string.</param>
    /// <returns>The string representation of the 16-bit signed integer (Int16) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 16-bit signed integer (Int16) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 16-bit signed integer (Int16) value.
    /// </summary>
    /// <param name="str">The string to convert to a 16-bit signed integer (Int16) value.</param>
    /// <returns>The 16-bit signed integer (Int16) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Int16.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert an 8-bit unsigned integer (Byte) value to a string and vice versa.
  /// </summary>
  public class ByteToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts an 8-bit unsigned integer (Byte) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Byte to a string.
    /// </summary>
    /// <param name="val">The 8-bit unsigned integer (Byte) value to convert to a string.</param>
    /// <returns>The string representation of the 8-bit unsigned integer (Byte) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to an 8-bit unsigned integer (Byte) value. If the string is null or empty, it returns null. Otherwise, it parses the string to an 8-bit unsigned integer (Byte) value.
    /// </summary>
    /// <param name="str">The string to convert to an 8-bit unsigned integer (Byte) value.</param>
    /// <returns>The 8-bit unsigned integer (Byte) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Byte.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a 16-bit unsigned integer (UInt16) value to a string and vice versa.
  /// </summary>
  public class UInt16TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 16-bit unsigned integer (UInt16) value to its string representation. If the val is null, it returns null. Otherwise, it converts the UInt16 to a string.
    /// </summary>
    /// <param name="val">The 16-bit unsigned integer (UInt16) value to convert to a string.</param>
    /// <returns>The string representation of the 16-bit unsigned integer (UInt16) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 16-bit unsigned integer (UInt16) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 16-bit unsigned integer (UInt16) value.
    /// </summary>
    /// <param name="str">The string to convert to a 16-bit unsigned integer (UInt16) value.</param>
    /// <returns>The 16-bit unsigned integer (UInt16) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : UInt16.Parse(str);
  }   

  /// <summary>
  /// A converter class that provides methods to convert a 32-bit unsigned integer (UInt32) value to a string and vice versa.
  /// </summary>
  public class UInt32TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 32-bit unsigned integer (UInt32) value to its string representation. If the val is null, it returns null. Otherwise, it converts the UInt32 to a string.   
    /// </summary>
    /// <param name="val">The 32-bit unsigned integer (UInt32) value to convert to a string.</param>
    /// <returns>The string representation of the 32-bit unsigned integer (UInt32) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 32-bit unsigned integer (UInt32) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 32-bit unsigned integer (UInt32) value.
    /// </summary>
    /// <param name="str">The string to convert to a 32-bit unsigned integer (UInt32) value.</param>
    /// <returns>The 32-bit unsigned integer (UInt32) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : UInt32.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a 64-bit unsigned integer (UInt64) value to a string and vice versa.
  /// </summary>
  public class UInt64TypeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a 64-bit unsigned integer (UInt64) value to its string representation. If the val is null, it returns null. Otherwise, it converts the UInt64 to a string.
    /// </summary>
    /// <param name="val">The 64-bit unsigned integer (UInt64) value to convert to a string.</param>
    /// <returns>The string representation of the 64-bit unsigned integer (UInt64) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => val?.ToString();
    /// <summary>
    /// Converts a string back to a 64-bit unsigned integer (UInt64) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a 64-bit unsigned integer (UInt64) value.
    /// </summary>
    /// <param name="str">The string to convert to a 64-bit unsigned integer (UInt64) value.</param>
    /// <returns>The 64-bit unsigned integer (UInt64) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : UInt64.Parse(str);
  }

  /// <summary>
  /// A converter class that provides methods to convert a single-precision floating-point (Single) value to a string and vice versa.
  /// </summary>
  public class SingleToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a single-precision floating-point (Single) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Single to a string using the "R" format specifier and invariant culture.
    /// </summary>
    /// <param name="val">The single-precision floating-point (Single) value to convert to a string.</param>
    /// <returns>The string representation of the single-precision floating-point (Single) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as Single?)?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
    /// <summary>
    /// Converts a string back to a single-precision floating-point (Single) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a single-precision floating-point (Single) value.
    /// </summary>
    /// <param name="str">The string to convert to a single-precision floating-point (Single) value.</param>
    /// <returns>The single-precision floating-point (Single) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Single.Parse(str, System.Globalization.CultureInfo.InvariantCulture);
  } 

  /// <summary>
  /// A converter class that provides methods to convert a double-precision floating-point (Double) value to a string and vice versa.
  /// </summary>
  public class DoubleToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a double-precision floating-point (Double) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Double to a string using the "R" format specifier and invariant culture.
    /// </summary>
    /// <param name="val">The double-precision floating-point (Double) value to convert to a string.</param>
    /// <returns>The string representation of the double-precision floating-point (Double) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as Double?)?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
    /// <summary>
    /// Converts a string back to a double-precision floating-point (Double) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a double-precision floating-point (Double) value.
    /// </summary>
    /// <param name="str">The string to convert to a double-precision floating-point (Double) value.</param>
    /// <returns>The double-precision floating-point (Double) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Double.Parse(str, System.Globalization.CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// A converter class that provides methods to convert a decimal (Decimal) value to a string and vice versa.
  /// </summary>
  public class DecimalToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a decimal (Decimal) value to its string representation. If the val is null, it returns null. Otherwise, it converts the Decimal to a string using the "R" format specifier and invariant culture.  
    /// </summary>
    /// <param name="val">The decimal (Decimal) value to convert to a string.</param>
    /// <returns>The string representation of the decimal (Decimal) value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as Decimal?)?.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
    /// <summary>
    /// Converts a string back to a decimal (Decimal) value. If the string is null or empty, it returns null. Otherwise, it parses the string to a decimal (Decimal) value.
    /// </summary>
    /// <param name="str">The string to convert to a decimal (Decimal) value.</param>
    /// <returns>The decimal (Decimal) value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : Decimal.Parse(str, System.Globalization.CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// A converter class that provides methods to convert a DateTime value to a string and vice versa.
  /// </summary>
  public class DateTimeToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a DateTime value to its string representation in ISO 8601 format. If the val is null, it returns null. Otherwise, it converts the DateTime to a string using the "o" format specifier.
    /// </summary>
    /// <param name="val">The DateTime value to convert to a string.</param>
    /// <returns>The string representation of the DateTime value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as DateTime?)?.ToString("o");
    /// <summary>
    /// Converts a string back to a DateTime value. If the string is null or empty, it returns null. Otherwise, it parses the string to a DateTime value.
    /// </summary>
    /// <param name="str">The string to convert to a DateTime value.</param>
    /// <returns>The DateTime value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : DateTime.Parse(str, null, System.Globalization.DateTimeStyles.RoundtripKind);
  } 

  /// <summary>
  /// A converter class that provides methods to convert a HexBinary value to a string and vice versa.
  /// </summary>
  public class HexBinaryToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexBinary value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexBinary to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexBinary value to convert to a string.</param>
    /// <returns>The string representation of the HexBinary value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexBinary)?.ToString();
    /// <summary>
    /// Converts a string back to a HexBinary value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexBinary value.
    /// </summary>
    /// <param name="str">The string to convert to a HexBinary value.</param>
    /// <returns>The HexBinary value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? null : HexBinary.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexByte value to a string and vice versa.
  /// </summary>
  public class HexByteToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexByte value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexByte to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexByte value to convert to a string.</param>
    /// <returns>The string representation of the HexByte value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexByte?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexByte value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexByte value.
    /// </summary>
    /// <param name="str">The string to convert to a HexByte value.</param>
    /// <returns>The HexByte value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexByte.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexChar value to a string and vice versa.
  /// </summary>
  public class HexCharToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexChar value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexChar to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexChar value to convert to a string.</param>
    /// <returns>The string representation of the HexChar value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexChar?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexChar value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexChar value.
    /// </summary>
    /// <param name="str">The string to convert to a HexChar value.</param>
    /// <returns>The HexChar value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexChar.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexColor value to a string and vice versa.
  /// </summary>
  public class HexColorToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexColor value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexColor to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexColor value to convert to a string.</param>
    /// <returns>The string representation of the HexColor value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexColor?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexColor value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexColor value.
    /// </summary>
    /// <param name="str">The string to convert to a HexColor value.</param>
    /// <returns>The HexColor value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexColor.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexInt value to a string and vice versa.
  /// </summary>
  public class HexIntToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexInt value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexInt to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexInt value to convert to a string.</param>
    /// <returns>The string representation of the HexInt value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexInt?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexInt value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexInt value. 
    /// </summary>
    /// <param name="str">The string to convert to a HexInt value.</param>
    /// <returns>The HexInt value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexInt.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexLong value to a string and vice versa.
  /// </summary>
  public class HexLongToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexLong value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexLong to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexLong value to convert to a string.</param>
    /// <returns>The string representation of the HexLong value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexLong?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexLong value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexLong value.
    /// </summary>
    /// <param name="str">The string to convert to a HexLong value.</param>
    /// <returns>The HexLong value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexLong.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a HexPercent value to a string and vice versa.
  /// </summary>
  public class HexPercentToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a HexPercent value to its string representation. If the val is null, it returns null. Otherwise, it converts the HexPercent to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The HexPercent value to convert to a string.</param>
    /// <returns>The string representation of the HexPercent value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as HexPercent?)?.ToString();
    /// <summary>
    /// Converts a string back to a HexPercent value. If the string is null or empty, it returns null. Otherwise, it parses the string to a HexPercent value.
    /// </summary>
    /// <param name="str">The string to convert to a HexPercent value.</param>
    /// <returns>The HexPercent value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : HexPercent.Parse(str!);
  } 
  
  /// <summary>
  /// A converter class that provides methods to convert a HexByte value to a string and vice versa.
  /// </summary>
  public class BytePercentToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a BytePercent value to its string representation. If the val is null, it returns null. Otherwise, it converts the BytePercent to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The BytePercent value to convert to a string.</param>
    /// <returns>The string representation of the BytePercent value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as BytePercent?)?.ToString();
    /// <summary>
    /// Converts a string back to a BytePercent value. If the string is null or empty, it returns null. Otherwise, it parses the string to a BytePercent value.
    /// </summary>
    /// <param name="str">The string to convert to a BytePercent value.</param>
    /// <returns>The BytePercent value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : BytePercent.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a Percentage value to a string and vice versa.
  /// </summary>
  public class PercentageToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a Percentage value to its string representation. If the val is null, it returns null. Otherwise, it converts the Percentage to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The Percentage value to convert to a string.</param>
    /// <returns>The string representation of the Percentage value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as Percentage?)?.ToString();
    /// <summary>
    /// Converts a string back to a Percentage value. If the string is null or empty, it returns null. Otherwise, it parses the string to a Percentage value.
    /// </summary>
    /// <param name="str">The string to convert to a Percentage value.</param>
    /// <returns>The Percentage value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : Percentage.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a Degrees value to a string and vice versa.
  /// </summary>
  public class DegreesToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a Degrees value to its string representation. If the val is null, it returns null. Otherwise, it converts the Degrees to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The Degrees value to convert to a string.</param>
    /// <returns>The string representation of the Degrees value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as Degrees?)?.ToString();
    /// <summary>
    /// Converts a string back to a Degrees value. If the string is null or empty, it returns null. Otherwise, it parses the string to a Degrees value.
    /// </summary>
    /// <param name="str">The string to convert to a Degrees value.</param>
    /// <returns>The Degrees value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : Degrees.Parse(str!);
  }

  /// <summary>
  /// A converter class that provides methods to convert a StringList value to a string and vice versa.
  /// </summary>
  public class StringListToStringConverter : TypeToStringConverter
  {
    /// <summary>
    /// Converts a StringList value to its string representation. If the val is null, it returns null. Otherwise, it converts the StringList to a string using its ToString() method.
    /// </summary>
    /// <param name="val">The StringList value to convert to a string.</param>
    /// <returns>The string representation of the StringList value, or null if the val is null.</returns>
    public override string? ConvertToString(object? val) => (val as StringList)?.ToString();
    /// <summary>
    /// Converts a string back to a StringList value. If the string is null or empty, it returns null. Otherwise, it parses the string to a StringList value.
    /// </summary>
    /// <param name="str">The string to convert to a StringList value.</param>
    /// <returns>The StringList value represented by the string, or null if the string is null or empty.</returns>
    public override object? ConvertFromString(string? str) => String.IsNullOrEmpty(str) ? (object?)null : StringList.Parse(str!);
  }
}