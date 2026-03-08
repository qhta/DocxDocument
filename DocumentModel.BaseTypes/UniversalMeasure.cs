using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentModel;

/// <summary>
/// Represents abstract universal measurement in some length unit measure.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// UniversalMeasure provide a precise, integer-based unit for document measurements.
/// This supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// </remarks>
public abstract class UniversalMeasure: IComparable<UniversalMeasure>, IEquatable<UniversalMeasure>
{
  /// <summary>
  /// internal storage for the length value. This can be of type Int64, UInt64, Decimal, or Double, depending on how the instance was initialized.
  /// </summary>
  protected internal  object? _value;

  /// <summary>
  /// Internal storage for the unit of measurement associated with this length value.
  /// </summary>
  protected internal LengthUnit? _unit;


  /// <summary>
  /// Unit of measurement for this length value.
  /// This can be set based on the input string during initialization (e.g., "mm", "cm", "in", "pt")
  /// or left null if the unit is not specified.
  /// </summary>
  [NotMapped]
  public LengthUnit? Unit { get => _unit; protected set => _unit = value; }

  /// <summary>
  /// Checks if the instance is empty, meaning it has not been initialized with a value.
  /// </summary>
  public bool IsEmpty => _value == null;

  /// <summary>
  /// Checks if the instance has been initialized with a value.
  /// </summary>
  public bool HasValue => _value != null;

  /// <summary>
  /// Checks if the instance represents an integer value.
  /// </summary>
  public bool IsInteger => _value is Int64;

  /// <summary>
  /// Checks if the instance represents an unsigned integer value.
  /// </summary>
  public bool IsUnsignedInteger => _value is UInt64;

  /// <summary>
  /// Checks if the instance represents a decimal value.
  /// </summary>
  public bool IsDecimal => _value is Decimal;

  /// <summary>
  /// Checks if the instance represents a double value.
  /// </summary>
  public bool IsDouble => _value is Double;

  /// <summary>
  /// Gets the Int64 value represented by this instance.
  /// If the instance was initialized with a Double or Decimal value, the value will be converted to Int64 by rounding
  /// away from zero.
  /// </summary>
  public Int64 IntValue => IsInteger ? (Int64)_value! 
    : IsUnsignedInteger ? Convert.ToInt64((UInt64)_value!)
    : IsDecimal ? (Int64)Math.Round((Decimal)_value!, MidpointRounding.AwayFromZero) 
    : IsDouble ? (Int64)Math.Round((Double)_value!, MidpointRounding.AwayFromZero) : 0;

  /// <summary>
  /// Gets the UInt64 value represented by this instance.
  /// If the instance was initialized with a Double or Decimal value, the value will be converted to UInt64 by rounding
  /// away from zero.
  /// </summary>
  public UInt64 UIntValue => IsUnsignedInteger ? (UInt64)_value!
    : IsInteger ? Convert.ToUInt64((Int64)_value!)
    : IsDecimal ? Convert.ToUInt64(Math.Round((Decimal)_value!, MidpointRounding.AwayFromZero))
    : IsDouble ? Convert.ToUInt64(Math.Round((Double)_value!, MidpointRounding.AwayFromZero)) : 0;

  /// <summary>
  /// Gets the Decimal value represented by this instance.
  /// If the instance was initialized with an Int64 or Double value, it will be converted to Decimal.
  /// </summary>
  public Decimal DecimalValue => IsDecimal? (Decimal) _value!
    : IsInteger ? Convert.ToDecimal((Int64)_value!)
    : IsUnsignedInteger ? Convert.ToDecimal((UInt64)_value!)
    : IsDouble ? Convert.ToDecimal((Double)_value!) : 0;


  /// <summary>
  /// Gets the Double value represented by this instance.
  /// If the instance was initialized with an Int64 or Decimal value, it will be converted to double.
  /// </summary>
  public Double DoubleValue => IsDouble ? (Double)_value! :
    IsDecimal ? Convert.ToDouble((Decimal)_value!) :
    IsInteger ? Convert.ToDouble((Int64)_value!) :
    IsUnsignedInteger ? Convert.ToDouble((UInt64)_value!) : 0;

  /// <summary>
  /// Gets the number of UniversalMeasure per inch for the current measurement system.
  /// </summary>
  /// <remarks>This property provides the conversion factor used to translate measurements from inches to the
  /// unit defined by the current context. It is essential for calculations involving dimensions and scaling.</remarks>
  protected abstract double UnitsPerInch { get; }

  /// <summary>
  /// Gets the equivalent measurement in millimeters for the current unit value, based on the number of UniversalMeasure per inch.
  /// </summary>
  /// <remarks>This property converts the unit measurement from inches to millimeters using the standard
  /// conversion factor of 25.4.</remarks>
  protected double UnitsPerMM => UnitsPerInch / 25.4;

  /// <summary>
  /// Gets the equivalent measurement in centimeters based on the current unit per inch value.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per inch to centimeters by dividing by 2.54, the number
  /// of centimeters in an inch.</remarks>
  protected double UnitsInCM => UnitsPerInch / 2.54;

  /// <summary>
  /// Gets the number of measurement UniversalMeasure in a single point, based on the number of UniversalMeasure per inch.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per inch to points by dividing by 72.0, the number
  /// of points in an inch.</remarks>
  protected double UnitsPerPoint => UnitsPerInch / 72.0;

  /// <summary>
  /// Gets the number of measurement UniversalMeasure in one Twips, based on the number of UniversalMeasure per point.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per point to Twips by dividing by 20.0, the number
  /// of Twips in a point.</remarks>
  protected double UnitsPerTwips => UnitsPerPoint / 20.0;

  #region Constructors

  /// <summary>
  /// Initializes a new instance of the UniversalMeasure class.
  /// </summary>
  protected UniversalMeasure()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as integer value</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points</description></item>
  /// <item><description>"1in" - inches</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  protected virtual void Init(string str)
  {
    str = str.Replace(",", ".").Trim();
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      _value = Double.Parse(str, CultureInfo.InvariantCulture) * UnitsPerMM;
      _unit = LengthUnit.Millimeters;
      return;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      _value = Double.Parse(str, CultureInfo.InvariantCulture) * UnitsInCM;
      _unit = LengthUnit.Centimeters;
      return;
    }
    if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      // ReSharper disable once VirtualMemberCallInConstructor
      _value = Double.Parse(str, CultureInfo.InvariantCulture) * UnitsPerInch;
      _unit = LengthUnit.Inches;
      return;
    }
    if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      _value = Double.Parse(str, CultureInfo.InvariantCulture) * UnitsPerPoint;
      _unit = LengthUnit.Points;
      return;
    }
    if (str.EndsWith("tw"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      _value = Double.Parse(str, CultureInfo.InvariantCulture) * UnitsPerTwips;
      _unit = LengthUnit.Twips;
      return;
    }
    if (Int64.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var int64Value))
    {
      _value = int64Value;
      return;
    }
    if (UInt64.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var uint64Value))
    {
      _value = uint64Value;
      return;
    }
    if (Decimal.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var decimalValue))
    {
      _value = decimalValue;
      return;
    }
    if (Double.TryParse(str, CultureInfo.InvariantCulture, out var dblValue))
    {
      _value = dblValue;
      return;
    }
    if (str != string.Empty)
      throw new FormatException($"Invalid UniversalMeasure string: {str}");
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from an Int64 integer value.
  /// </summary>
  /// <param name="int64Value">The value in UniversalMeasure.</param>
  protected void Init(Int64 int64Value)
  {
    this._value = int64Value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a UInt64 value.
  /// </summary>
  /// <param name="uint64Value">The value in UniversalMeasure.</param>
  protected void Init(UInt64 uint64Value)
  {
    this._value = uint64Value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a Decimal value.
  /// </summary>
  /// <param name="decimalValue">The value in UniversalMeasure.</param>
  protected void Init(Decimal decimalValue)
  {
    this._value = decimalValue;
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a Double value.
  /// </summary>
  /// <param name="doubleValue">The value in UniversalMeasure.</param>
  protected void Init(Double doubleValue)
  {
    this._value = doubleValue;
  }

  #endregion

  #region Conversion Methods

  /// <summary>
  /// Converts the UniversalMeasure value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM() => DoubleValue / UnitsPerMM;

  /// <summary>
  /// Converts the UniversalMeasure value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM() => DoubleValue / UnitsInCM;

  /// <summary>
  /// Converts the UniversalMeasure value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch() => DoubleValue / UnitsPerInch;

  /// <summary>
  /// Converts the UniversalMeasure value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// A point is defined as 1/72 of an inch.
  /// </remarks>
  public double ToPT() => DoubleValue / UnitsPerPoint;

  /// <summary>
  /// Converts the UniversalMeasure value to Twips.
  /// </summary>
  /// <returns>The measurement in Twips as a double-precision floating-point number.</returns>
  /// <remarks>
  /// A twips is defined as 1/20 of a point.
  /// </remarks>
  public double ToTwips() => DoubleValue;

  /// <summary>
  /// Converts the current length value to the specified unit of measurement.
  /// </summary>
  /// <param name="units">The target unit to which the length value will be converted. Supported units include Twips, Points, Millimeters,
  /// Centimeters, and Inches.</param>
  /// <returns>The length value converted to the specified unit.</returns>
  /// <exception cref="ArgumentException">Thrown if the specified unit is not supported.</exception>
  public double ConvertTo(LengthUnit units)
  {
    return units switch
    {
      LengthUnit.Twips => ToTwips(),
      LengthUnit.Points => ToPT(),
      LengthUnit.Millimeters => ToMM(),
      LengthUnit.Centimeters => ToCM(),
      LengthUnit.Inches => ToInch(),
      _ => throw new ArgumentException($"Unsupported length unit: {units}", nameof(units))
    };
  }
  #endregion

  #region ToString conversions

  /// <summary>
  /// Converts the current length measure to its string representation. Raw number formats are expected in InvariantCulture.
  /// </summary>
  public override string ToString()
  {
    if (IsDouble)
      return ((Double)_value!).ToString(CultureInfo.InvariantCulture);
    if (IsDecimal)
      return ((Decimal)_value!).ToString(CultureInfo.InvariantCulture); 
    if (IsInteger)
      return ((Int64)_value!).ToString(CultureInfo.InvariantCulture);
    if (IsUnsignedInteger)
      return ((UInt64)_value!).ToString(CultureInfo.InvariantCulture);
    return string.Empty;
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format provider.
  /// This allows for culture-specific formatting of the output string, such as using different decimal separators
  /// based on the culture settings provided by the formatProvider.
  /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
  public virtual string ToString(IFormatProvider? formatProvider)
  {
    if (IsDouble)
      return ((Double)_value!).ToString(formatProvider);
    if (IsDecimal)
      return ((Decimal)_value!).ToString(formatProvider);
    if (IsInteger)
      return ((Int64)_value!).ToString(formatProvider);
    if (IsUnsignedInteger)
      return ((UInt64)_value!).ToString(formatProvider);
    return string.Empty;
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format string and format provider.
  /// The format string can specify how the numeric value should be formatted (e.g., number of decimal places, unit symbols)
  /// while the format provider allows for culture-specific formatting.
  /// If the format string is null or empty, a default numeric format should be used.
  /// If the format provider is null, invariant culture's formatting conventions should be applied.
  /// </summary>
  /// <param name="format">A standard or custom numeric format string. If null or empty, a default numeric format is used.</param>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information.
  /// If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure,
  /// formatted according to the specified format string and format provider.</returns>
  public virtual string ToString(string? format, IFormatProvider? formatProvider)
  {
    if (IsDouble)
      return ((Double)_value!).ToString(format, formatProvider);
    if (IsDecimal)
      return ((Decimal)_value!).ToString(format, formatProvider);
    if (IsInteger)
      return ((Int64)_value!).ToString(format, formatProvider);
    if (IsUnsignedInteger)
      return ((UInt64)_value!).ToString(format, formatProvider);
    return string.Empty;
  }

  /// <summary>
  /// Converts the current instance to its string representation using the specified format string.
  /// </summary>
  /// <remarks>If the format string is not recognized or is invalid, a FormatException may be thrown. Supported
  /// format strings may include both standard and custom formats, depending on the implementation.</remarks>
  /// <param name="format">A format string that defines how the value should be represented.
  /// If null, a default format is used.</param>
  /// <returns>A string representation of the current instance, formatted according to the specified format string.</returns>
  public virtual string ToString(string? format)
  {
    if (IsDouble)
      return ((Double)_value!).ToString(format);
    if (IsDecimal)
      return ((Decimal)_value!).ToString(format);
    if (IsInteger)
      return ((Int64)_value!).ToString(format);
    if (IsUnsignedInteger)
      return ((UInt64)_value!).ToString(format);
    return string.Empty;
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="units">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit.</returns>
  public string ToString(LengthUnit units)
    => $"{ConvertTo(units).ToString(CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit and format provider.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <param name="units">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit and format provider.</returns>
  public string ToString(IFormatProvider? formatProvider, LengthUnit units)
  => $"{ConvertTo(units).ToString(formatProvider ?? CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Converts the current length value to its string representation using the specified unit, format, and format
  /// provider. 
  /// The output should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// Format string should not include unit symbols, as they will be added based on the specified unit parameter.
  /// If the format string is null or empty, a default numeric format should be used.
  /// </summary>
  /// <param name="format">A standard or custom numeric format string that defines how the value is formatted. If null, the default format is
  ///   used.</param>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, the current culture is used.</param>
  /// <param name="units">The unit of length to use when formatting the value.</param>
  /// <returns>A string representation of the current length value, formatted according to the specified unit, format, and format
  /// provider.</returns>
  public string ToString(string? format, IFormatProvider? formatProvider, LengthUnit units)
      => $"{ConvertTo(units).ToString(format, formatProvider ?? CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Converts the current length value to its string representation using the specified unit and format string.
  /// The output should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="format">A standard or custom numeric format string that defines how the value is formatted. If null, the default format is used.</param>
  /// <param name="units">The unit of length to use when formatting the value.</param>
  /// <returns>A string representation of the current length value, formatted according to the specified unit and format string.</returns>
  public string ToString(string? format, LengthUnit units)
        => $"{ConvertTo(units).ToString(format, CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Suffixes for length UniversalMeasure that can be used in string representations of length measures.
  /// The order of the suffixes corresponds to the order of the LengthUnit enum values.
  /// </summary>
  public static string[] UnitSuffixed { get; } = ["tw", "pt", "mm", "cm", "in"];

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a <see cref="UniversalMeasure"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="UniversalMeasure"/> value to convert.</param>
  /// <returns>A string representation of the UniversalMeasure value.</returns>
  public static implicit operator string(UniversalMeasure value)
  {
    return value.ToString();
  }
  
  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to an Int32 value.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of UniversalMeasure values in contexts where an Int32 is
  /// expected. Ensure that the UniversalMeasure value is within the range of Int32 to avoid overflow.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert.</param>
  public static implicit operator Int32(UniversalMeasure value)
  {
    return Convert.ToInt32(value.IntValue);
  }

  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to an Int64 value.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of UniversalMeasure values in contexts where a Int64 is
  /// expected. Ensure that the UniversalMeasure value is within the range of Int64 to avoid overflow.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert.</param>
  public static implicit operator Int64(UniversalMeasure value)
  {
    return value.IntValue;
  }


  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to a UInt32 value.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of UniversalMeasure values in contexts where a UInt32 is
  /// expected. Ensure that the UniversalMeasure value is within the range of UInt32 to avoid overflow.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert.</param>
  public static implicit operator UInt32(UniversalMeasure value)
  {
    return Convert.ToUInt32(value.UIntValue);
  }

  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to a UInt64 value.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of UniversalMeasure values in contexts where a UInt64 is
  /// expected. Ensure that the UniversalMeasure value is within the range of UInt64 to avoid overflow.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert.</param>
  public static implicit operator UInt64(UniversalMeasure value)
  {
    return value.UIntValue;
  }


  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to its equivalent Decimal value.
  /// </summary>
  /// <remarks>This conversion returns the value of the DecimalValue property, representing the UniversalMeasure
  /// in decimal format. This allows UniversalMeasure instances to be used in contexts where a decimal is expected
  /// without explicit casting.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert to a decimal.</param>
  public static implicit operator Decimal(UniversalMeasure value)
  {
    return value.DecimalValue;
  }

  /// <summary>
  /// Implicitly converts a UniversalMeasure instance to equivalent Double value
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of UniversalMeasure values in contexts where a Double is
  /// expected. Ensure that the UniversalMeasure value is within the range of Double to avoid overflow.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert.</param>
  public static implicit operator Double(UniversalMeasure value)
  {
    return value.DoubleValue;
  }

  #endregion

  #region IComparable and IEquatable Implementations

  /// <summary>
  /// Compares this instance to a specified <see cref="UniversalMeasure"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="UniversalMeasure"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(UniversalMeasure? other)
  {
    if (other == null)
      throw new ArgumentNullException(nameof(other), "Cannot compare to null.");
    return 
      ToInch().CompareTo(other.ToInch());
  }
  
  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
    return base.GetHashCode();
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(UniversalMeasure? other)
  {
    if (other == null)
      return IsEmpty;
    return System.Math.Abs(ToInch() - other.ToInch()) < 1e-10;

  }

  /// <summary>
  /// Determines whether the specified object is equal to the current UniversalMeasure instance.
  /// </summary>
  /// <remarks>This method supports value comparison for UniversalMeasure instances. It returns false if the provided
  /// object is not a UniversalMeasure instance.</remarks>
  /// <param name="obj">The object to compare with the current instance. This parameter can be null.</param>
  /// <returns>true if the specified object is a UniversalMeasure instance equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is UniversalMeasure otherUniversalMeasure)
      return Equals(otherUniversalMeasure);

    if (obj is IConvertible convertible)
    {
      var doubleValue = Convert.ToDouble(convertible);
      return System.Math.Abs(DoubleValue - doubleValue) < 1e-10;
    }
    return false;
  }

  #endregion
}