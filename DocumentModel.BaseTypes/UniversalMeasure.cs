namespace DocumentModel;

/// <summary>
/// Represents abstract universal measurement in some length unit measure.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// UniversalMeasure provides a precise, integer-based unit for document measurements.
/// It supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// </remarks>
public abstract class UniversalMeasure : IComparable<UniversalMeasure>, IEquatable<UniversalMeasure>, IConvertible
{
  /// <summary>
  /// internal storage for the length value. This can be of type Int64, UInt64, Decimal, or Double, depending on how the instance was initialized.
  /// </summary>
  protected internal Decimal? value;

  /// <summary>
  /// Internal storage for the unit of measurement associated with this length value.
  /// </summary>
  protected internal MeasureUnit? unit;

  /// <summary>
  /// Unit of measurement for the numeric value.
  /// It can be set based on the input string during initialization (e.g., "mm", "cm", "in", "pt")
  /// or left null if the unit is not specified.
  /// </summary>
  [NotMapped]
  public MeasureUnit? Unit { get => unit; protected set => unit = value; }

  /// <summary>
  /// Checks if the instance is empty, meaning it has not been initialized with a value.
  /// </summary>
  public bool IsEmpty => value == null;

  /// <summary>
  /// Checks if the instance has been initialized with a value.
  /// </summary>
  public bool HasValue => value != null;

  /// <summary>
  /// Gets the Int64 value represented by this instance.
  /// If the instance was initialized with a Double or Decimal value, the value will be converted to Int64 by rounding
  /// away from zero.
  /// </summary>
  public Int64 IntValue => (Int64)Math.Round((Decimal)value!, MidpointRounding.AwayFromZero);

  /// <summary>
  /// Gets the UInt64 value represented by this instance.
  /// If the instance was initialized with a Double or Decimal value, the value will be converted to UInt64 by rounding
  /// away from zero.
  /// </summary>
  public UInt64 UIntValue => (UInt64)Math.Round((Decimal)value!, MidpointRounding.AwayFromZero);

  /// <summary>
  /// Gets the Decimal value represented by this instance.
  /// If the instance was initialized with an Int64 or Double value, it will be converted to Decimal.
  /// </summary>
  public Decimal DecimalValue => (Decimal)value!;


  /// <summary>
  /// Gets the Double value represented by this instance.
  /// If the instance was initialized with an Int64 or Decimal value, it will be converted to Decimal.
  /// </summary>
  public Double DoubleValue => (Double)value!;

  /// <summary>
  /// Gets the number of UniversalMeasure per inch for the current measurement system.
  /// </summary>
  /// <remarks>This property provides the conversion factor used to translate measurements from inches to the
  /// unit defined by the current context. It is essential for calculations involving dimensions and scaling.</remarks>
  protected abstract Decimal UnitsPerInch { get; }

  /// <summary>
  /// Gets the equivalent measurement in millimeters for the current unit value, based on the number of UniversalMeasure per inch.
  /// </summary>
  /// <remarks>This property converts the unit measurement from inches to millimeters using the standard
  /// conversion factor of 25.4.</remarks>
  protected Decimal UnitsPerMM => UnitsPerInch / 25.4m;

  /// <summary>
  /// Gets the equivalent measurement in centimeters based on the current unit per inch value.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per inch to centimeters by dividing by 2.54, the number
  /// of centimeters in an inch.</remarks>
  protected Decimal UnitsInCM => UnitsPerInch / 2.54m;

  /// <summary>
  /// Gets the number of measurement UniversalMeasure in a single point, based on the number of UniversalMeasure per inch.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per inch to points by dividing by 72.0, the number
  /// of points in an inch.</remarks>
  protected Decimal UnitsPerPoint => UnitsPerInch / 72.0m;

  /// <summary>
  /// Gets the number of measurement UniversalMeasure in one Twips, based on the number of UniversalMeasure per point.
  /// </summary>
  /// <remarks>This property converts the value of UniversalMeasure per point to Twips by dividing by 20.0, the number
  /// of Twips in a point.</remarks>
  protected Decimal UnitsPerTwips => UnitsPerPoint / 20.0m;

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
  /// <para>Commas in the input string are replaced with periods before parsing to ensure Decimal separator consistency.</para>
  /// </remarks>
  protected void Init(string str)
  {
    if (!TryInit(str))
      throw new FormatException($"Invalid UniversalMeasure string: {str}");
  }

  /// <summary>
  /// Attempts to initialize a new instance of the <see cref="UniversalMeasure"/> from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <returns>True if the initialization was successful; otherwise, false.</returns>
  public bool TryInit(string str)
  {
    str = str.Replace(",", ".").Trim();
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsPerMM;
        unit = MeasureUnit.Millimeters;
        return true;
      }
      return false;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsInCM;
        unit = MeasureUnit.Centimeters;
        return true;
      }
      return false;
    }
    if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsPerInch;
        unit = MeasureUnit.Inches;
        return true;
      }
      return false;
    }
    if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsPerPoint;
        unit = MeasureUnit.Points;
        return true;
      }
      return false;
    }
    if (str.EndsWith("tw"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsPerTwips;
        unit = MeasureUnit.Twips;
        return true;
      }
      return false;
    }
    if (str.EndsWith("twips"))
    {
      str = str.Substring(0, str.Length - 5).Trim();
      if (Decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
      {
        this.value = value * UnitsPerTwips;
        unit = MeasureUnit.Twips;
        return true;
      }
      return false;
    }
    if (Int64.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var int64Value))
    {
      value = int64Value;
      return true;
    }
    if (UInt64.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var uint64Value))
    {
      value = uint64Value;
      return true;
    }
    if (Decimal.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out var DecimalValue))
    {
      value = DecimalValue;
      return true;
    }
    if (Double.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out var dblValue))
    {
      value = (Decimal)dblValue;
      return true;
    }
    return false;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from an Int64 integer value.
  /// </summary>
  /// <param name="int64Value">The value in UniversalMeasure.</param>
  protected void Init(Int64 int64Value)
  {
    this.value = int64Value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a UInt64 value.
  /// </summary>
  /// <param name="uint64Value">The value in UniversalMeasure.</param>
  protected void Init(UInt64 uint64Value)
  {
    this.value = uint64Value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a Decimal value.
  /// </summary>
  /// <param name="DecimalValue">The value in UniversalMeasure.</param>
  protected void Init(Decimal DecimalValue)
  {
    this.value = DecimalValue;
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="UniversalMeasure"/> from a Double value.
  /// </summary>
  /// <param name="doubleValue">The value in UniversalMeasure.</param>
  protected void Init(Double doubleValue)
  {
    this.value = (Decimal)doubleValue;
  }

  #endregion

  #region Conversion Methods

  /// <summary>
  /// Converts the UniversalMeasure value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a Decimal-precision floating-point number.</returns>
  public Decimal ToMillimeters() => DecimalValue / UnitsPerMM;

  /// <summary>
  /// Converts the UniversalMeasure value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a Decimal-precision floating-point number.</returns>
  public Decimal ToCentimeters() => DecimalValue / UnitsInCM;

  /// <summary>
  /// Converts the UniversalMeasure value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a Decimal-precision floating-point number.</returns>
  public Decimal ToInch() => DecimalValue / UnitsPerInch;

  /// <summary>
  /// Converts the UniversalMeasure value to points.
  /// </summary>
  /// <returns>The measurement in points as a Decimal-precision floating-point number.</returns>
  /// <remarks>
  /// A point is defined as 1/72 of an inch.
  /// </remarks>
  public Decimal ToPoints() => DecimalValue / UnitsPerPoint;

  /// <summary>
  /// Converts the UniversalMeasure value to Twips.
  /// </summary>
  /// <returns>The measurement in Twips as a Decimal-precision floating-point number.</returns>
  /// <remarks>
  /// A twips is defined as 1/20 of a point.
  /// </remarks>
  public Decimal ToTwips() => DecimalValue / UnitsPerTwips;

  /// <summary>
  /// Converts the current length value to the specified unit of measurement.
  /// </summary>
  /// <param name="units">The target unit to which the length value will be converted. Supported units include Twips, IPoints, Millimeters,
  /// Centimeters, and Inches.</param>
  /// <returns>The length value converted to the specified unit.</returns>
  /// <exception cref="ArgumentException">Thrown if the specified unit is not supported.</exception>
  public Decimal ConvertTo(MeasureUnit units)
  {
    return units switch
    {
      MeasureUnit.Twips => ToTwips(),
      MeasureUnit.Points => ToPoints(),
      MeasureUnit.Millimeters => ToMillimeters(),
      MeasureUnit.Centimeters => ToCentimeters(),
      MeasureUnit.Inches => ToInch(),
      _ => throw new ArgumentException($"Unsupported length unit: {units}", nameof(units))
    };
  }
  #endregion

  #region IConvertible Implementation

  /// <summary>
  /// Gets the TypeCode for the current instance, indicating the underlying data type of the value stored in this UniversalMeasure.
  /// </summary>
  /// <returns>The TypeCode representing the underlying data type of the value.</returns>
  public TypeCode GetTypeCode()
  {
    return TypeCode.Decimal;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Boolean.
  /// </summary>
  /// <remarks>This method is not implemented and will throw a NotImplementedException if called.</remarks>
  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Converts the current value to an 8-bit unsigned integer.  
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>An 8-bit unsigned integer equivalent to the current value.</returns>
  public byte ToByte(IFormatProvider? provider)
  {
    return Convert.ToByte((Decimal)value!);
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent Unicode character.
  /// </summary>
  /// <remarks>This method is not implemented and will throw a NotImplementedException if called.</remarks>
  public char ToChar(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Converts the current instance to a DateTime object.
  /// </summary>
  /// <remarks>This method is not implemented and will throw a NotImplementedException if called.</remarks>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Converts the current instance to a Decimal value.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A Decimal value equivalent to the current value.</returns>
  public Decimal ToDecimal(IFormatProvider? provider)
  {
    return (Decimal)value!;
  }

  /// <summary>
  /// Converts the current value to a Decimal-precision floating-point number. 
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A Decimal-precision floating-point number equivalent to the current value.</returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return Convert.ToDouble((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 16-bit signed integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 16-bit signed integer equivalent to the current value.</returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return Convert.ToInt16((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 32-bit signed integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 32-bit signed integer equivalent to the current value.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return Convert.ToInt32((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 64-bit signed integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 64-bit signed integer equivalent to the current value.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return Convert.ToInt64((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 8-bit signed integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>An 8-bit signed integer equivalent to the current value.</returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return Convert.ToSByte((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a single-precision floating-point number.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A single-precision floating-point number equivalent to the current value.</returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return Convert.ToSingle((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to an object of the specified type, using the provided format information if necessary.
  /// </summary>
  /// <param name="conversionType">The type to which to convert the current value.</param>
  /// <param name="provider">An object that supplies culture-specific formatting information, or null to use the current culture.</param>
  /// <returns>An object of the specified type that is equivalent to the current value.</returns>
  /// <exception cref="NotImplementedException">Thrown if the specified conversion type is not supported.</exception>
  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(Double))
      return ToDouble(provider);
    if (conversionType == typeof(Decimal))
      return ToDecimal(provider);
    if (conversionType == typeof(Single))
      return ToSingle(provider);
    if (conversionType == typeof(SByte))
      return ToSByte(provider);
    if (conversionType == typeof(Int16))
      return ToInt16(provider);
    if (conversionType == typeof(Int32))
      return ToInt32(provider);
    if (conversionType == typeof(UInt16))
      return ToUInt16(provider);
    if (conversionType == typeof(UInt32))
      return ToUInt32(provider);
    if (conversionType == typeof(UInt64))
      return ToUInt64(provider);
    if (conversionType == typeof(Byte))
      return ToByte(provider);
    throw new NotImplementedException();
  }

  /// <summary>
  /// Converts the current value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 16-bit unsigned integer equivalent to the current value.</returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return Convert.ToUInt16((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 32-bit unsigned integer equivalent to the current value.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return Convert.ToUInt32((Decimal)value!);
  }

  /// <summary>
  /// Converts the current value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">Unused. This parameter is included to match the IConvertible interface.</param>
  /// <returns>A 64-bit unsigned integer equivalent to the current value.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return Convert.ToUInt64((Decimal)value!);
  }

  #endregion

  #region ToString conversions

  /// <summary>
  /// Converts the current length measure to its string representation in InvariantCulture.
  /// Trailing zeros after the decimal point are removed, and if the result ends with a decimal point, it is also removed.
  /// </summary>
  public override string ToString()
  {
    var str = ((Decimal)value!).ToString(CultureInfo.InvariantCulture);
    while (str.Last() == '0' && str.Contains('.'))
      str = str.Substring(0, str.Length - 1);
    if (str.Last() == '.')
      str = str.Substring(0, str.Length - 1);
    return str;
  }

  /// <summary>
  /// Converts the current length measure to its string representation.
  /// This allows for culture-specific formatting of the output string, such as using different Decimal separators
  /// based on the culture settings provided by the formatProvider.
  /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
  public virtual string ToString(IFormatProvider? formatProvider)
  {
    return ((Decimal)value!).ToString(formatProvider);
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format string and format provider.
  /// The format string can specify how the numeric value should be formatted (e.g., number of Decimal places, unit symbols)
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
    return ((Decimal)value!).ToString(format, formatProvider);
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
    return ((Decimal)value!).ToString(format);
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="units">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit.</returns>
  public string ToString(MeasureUnit units)
    => $"{ConvertTo(units).ToString(CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit and format provider.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <param name="units">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit and format provider.</returns>
  public string ToString(IFormatProvider? formatProvider, MeasureUnit units)
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
  public string ToString(string? format, IFormatProvider? formatProvider, MeasureUnit units)
      => $"{ConvertTo(units).ToString(format, formatProvider ?? CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Converts the current length value to its string representation using the specified unit and format string.
  /// The output should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="format">A standard or custom numeric format string that defines how the value is formatted. If null, the default format is used.</param>
  /// <param name="units">The unit of length to use when formatting the value.</param>
  /// <returns>A string representation of the current length value, formatted according to the specified unit and format string.</returns>
  public string ToString(string? format, MeasureUnit units)
        => $"{ConvertTo(units).ToString(format, CultureInfo.InvariantCulture)} {UnitSuffixed[(int)units]}";

  /// <summary>
  /// Suffixes for length UniversalMeasure that can be used in string representations of length measures.
  /// The order of the suffixes corresponds to the order of the MeasureUnit enum values.
  /// </summary>
  public static string[] UnitSuffixed { get; } = ["", "tw", "pt", "mm", "cm", "in"];

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
  /// in Decimal format. This allows UniversalMeasure instances to be used in contexts where a Decimal is expected
  /// without explicit casting.</remarks>
  /// <param name="value">The UniversalMeasure instance to convert to a Decimal.</param>
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
    return System.Math.Abs(ToInch() - other.ToInch()) < 1e-10m;

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
