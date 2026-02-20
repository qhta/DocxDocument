//#define TraceSetValue

using System;
using System.ComponentModel;

using DocumentModel;

using Qhta.Conversion;
using Qhta.TypeUtils;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Represents a variant value that can hold any supported type, similar to a COM VARIANT.
/// </summary>
[JsonConverter(typeof(VariantJsonConverter))]
[SimpleType]
public partial class Variant : IConvertible, IEquatable<Variant>
{
  /// <summary>
  /// Maps <see cref="VariantType"/> values to their corresponding .NET types.
  /// </summary>
  public static Dictionary<VariantType, Type> ItemTypes = new()
  {
    { VariantType.SByte, typeof(SByte) },
    { VariantType.Int16, typeof(Int16) },
    { VariantType.Int32, typeof(Int32) },
    { VariantType.Int64, typeof(Int64) },
    { VariantType.Byte, typeof(Byte) },
    { VariantType.UInt16, typeof(UInt16) },
    { VariantType.UInt32, typeof(UInt32) },
    { VariantType.UInt64, typeof(UInt64) },
    { VariantType.Integer, typeof(decimal) },
    { VariantType.UnsignedInteger, typeof(decimal) },
    { VariantType.Decimal, typeof(decimal) },
    { VariantType.Currency, typeof(decimal) },
    { VariantType.Single, typeof(Single) },
    { VariantType.Double, typeof(Double) },
    { VariantType.Char, typeof(Char) },
    { VariantType.String, typeof(string) },
    { VariantType.Bstr, typeof(String) },
    { VariantType.Lpstr, typeof(String) },
    { VariantType.Lpwstr, typeof(String) },
    { VariantType.Date, typeof(DateOnly) },
    { VariantType.DateTime, typeof(DateTime) },
    { VariantType.Boolean, typeof(Boolean) },
    { VariantType.Null, typeof(DBNull) },
    { VariantType.HexInt, typeof(HexInt) },
    { VariantType.Guid, typeof(Guid) },
    { VariantType.ClipboardData, typeof(byte[]) },
    { VariantType.Variant, typeof(Variant) }
  };

  /// <summary>
  /// Stores the value of the variant.
  /// </summary>
  protected readonly object? _value;

  /// <summary>
  /// Stores the type of the variant value.
  /// </summary>
  protected readonly VariantType _variantType;

  /// <summary>
  /// Stores the .NET type of the value, if known.
  /// </summary>
  protected readonly Type? _valueType;

  /// <summary>
  /// Initializes a new, empty variant.
  /// </summary>
  public Variant()
  {
  }

  /// <summary>
  /// Initializes a new variant with the specified value. The variant type is inferred from the value.
  /// </summary>
  /// <param name="value">The value to store in the variant.</param>
  public Variant(object? value)
  {
    if (value is Boolean vBool)
    {
      _variantType = VariantType.Boolean;
      _value = vBool;
      return;
    }

    if (value is string vString)
    {
      //if (vString.IsAscii())
      _variantType = VariantType.Lpstr;
      //else
      //if (vString.IsUnicode())
      // VariantType = VariantType.Lpwstr;
      //else
      // VariantType = VariantType.Bstr;
      _value = vString;
      return;
    }

    if (value is Byte vByte)
    {
      _variantType = VariantType.Byte;
      _value = vByte;
      return;
    }

    if (value is SByte vSByte)
    {
      _variantType = VariantType.SByte;
      _value = vSByte;
      return;
    }

    if (value is short vShort)
    {
      _variantType = VariantType.Int16;
      _value = vShort;
      return;
    }

    if (value is ushort vUShort)
    {
      _variantType = VariantType.UInt16;
      _value = vUShort;
      return;
    }

    if (value is Int32 vInt32)
    {
      _variantType = VariantType.Int32;
      _value = vInt32;
      return;
    }

    if (value is UInt32 vUInt32)
    {
      _variantType = VariantType.UInt32;
      _value = vUInt32;
      return;
    }

    if (value is Int64 vInt64)
    {
      _variantType = VariantType.Int64;
      _value = vInt64;
      return;
    }

    if (value is UInt64 vUInt64)
    {
      _variantType = VariantType.UInt64;
      _value = vUInt64;
      return;
    }

    if (value is float vFloat)
    {
      _variantType = VariantType.Single;
      _value = vFloat;
      return;
    }

    if (value is Double vDouble)
    {
      _variantType = VariantType.Double;
      _value = vDouble;
      return;
    }

    if (value is Decimal vDecimal)
    {
      _variantType = VariantType.Decimal;
      _value = vDecimal;
      return;
    }

    if (value is DateOnly vDate)
    {
      _variantType = VariantType.Date;
      _value = vDate;
      return;
    }

    if (value is DateTime vFileTime)
    {
      _variantType = VariantType.DateTime;
      _value = vFileTime;
      return;
    }

    if (value is DBNull)
    {
      _variantType = VariantType.Null;
      _value = DBNull.Value;
      return;
    }

    if (value is null)
    {
      _variantType = VariantType.Empty;
      _value = null;
      return;
    }

    if (value is Guid vclassId)
    {
      _variantType = VariantType.Guid;
      _value = vclassId;
      return;
    }

    if (value is HexInt vError)
    {
      _variantType = VariantType.HexInt;
      _value = vError;
      return;
    }

    if (value is byte[] vBlob)
    {
      _variantType = VariantType.Blob;
      _value = vBlob;
      return;
    }

    if (value is object[] oBlob)
    {
      _variantType = VariantType.OBlob;
      _value = oBlob;
      return;
    }
    ;

    if (value is Variant variant)
    {
      _variantType = VariantType.Variant;
      _value = variant;
      return;
    }

    if (value is Object vObj)
    {
      _variantType = VariantType.Object;
      _value = vObj;
    }
  }

  /// <summary>
  /// Initializes a new variant with the specified variant type and value.
  /// </summary>
  /// <param name="variantType">The variant type.</param>
  /// <param name="value">The value to store.</param>
  public Variant(VariantType variantType, object? value) : this(variantType, value?.GetType(), value)
  {
  }

  /// <summary>
  /// Initializes a new variant with the specified variant type, value type, and value.
  /// </summary>
  /// <param name="variantType">The variant type.</param>
  /// <param name="valueType">The .NET type of the value.</param>
  /// <param name="value">The value to store.</param>
  public Variant(VariantType variantType, Type? valueType, object? value)
  {
    _variantType = variantType;
    if (variantType == VariantType.Empty)
      return;
    if (value != null)
    {
      if (valueType == null)
        valueType = value.GetType();
      _valueType = valueType;
    }
    _value = ConvertValue(variantType, value);
  }

  /// <summary>
  /// Returns the variant type of the value.
  /// </summary>
  [XmlIgnore]
  public virtual VariantType VariantType
  {
    get => _variantType;
  }

  /// <summary>
  /// Returns the type name of the value.
  /// </summary>
  public virtual string TypeName
  {
    get
    {
      if (VariantType == VariantType.Enum)
        return ValueType?.FullName ?? "Enum";
      if (VariantType == VariantType.Object)
        return ValueType?.FullName ?? "Object";
      return VariantType.ToString(CultureInfo.InvariantCulture);
    }
  }

  /// <summary>
  /// Returns the .NET type of the value, if known.
  /// </summary>
  [XmlIgnore]
  public virtual Type? ValueType => _valueType;

  /// <summary>
  /// Returns the value stored in the variant.
  /// </summary>
  public virtual object? Value => GetValue();

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for the value stored in the variant.
  /// </summary>
  public virtual TypeCode GetTypeCode()
  {
    if (Value is null)
      return TypeCode.Empty;
    if (Value is Boolean)
      return TypeCode.Boolean;
    if (Value is Byte)
      return TypeCode.Byte;
    if (Value is Char)
      return TypeCode.Char;
    if (Value is DateOnly)
      return TypeCode.DateTime;
    if (Value is DateTime)
      return TypeCode.DateTime;
    if (Value is Decimal)
      return TypeCode.Decimal;
    if (Value is Double)
      return TypeCode.Double;
    if (Value is Int16)
      return TypeCode.Int16;
    if (Value is Int32)
      return TypeCode.Int32;
    if (Value is Int64)
      return TypeCode.Int64;
    if (Value is SByte)
      return TypeCode.SByte;
    if (Value is Single)
      return TypeCode.Single;
    if (Value is String)
      return TypeCode.String;
    if (Value is UInt16)
      return TypeCode.UInt16;
    if (Value is UInt32)
      return TypeCode.UInt32;
    if (Value is UInt64)
      return TypeCode.UInt64;
    if (Value is DBNull)
      return TypeCode.DBNull;
    return TypeCode.Object;
  }
  /// <summary>
  /// Returns the <see cref="TypeCode"/> for the specified type.
  /// </summary>
  /// <param name="type">The type to evaluate.</param>
  /// <returns>The corresponding <see cref="TypeCode"/>.</returns>
  public static TypeCode ToTypeCode(Type type)
  {
    if (type.Name.StartsWith("Nullable`"))
      type = type.GenericTypeArguments[0];
    if (type == typeof(Boolean))
      return TypeCode.Boolean;
    if (type == typeof(Byte))
      return TypeCode.Byte;
    if (type == typeof(Char))
      return TypeCode.Char;
    if (type == typeof(DateOnly))
      return TypeCode.DateTime;
    if (type == typeof(DateTime))
      return TypeCode.DateTime;
    if (type == typeof(Decimal))
      return TypeCode.Decimal;
    if (type == typeof(Double))
      return TypeCode.Double;
    if (type == typeof(Int16))
      return TypeCode.Int16;
    if (type == typeof(Int32))
      return TypeCode.Int32;
    if (type == typeof(Int64))
      return TypeCode.Int64;
    if (type == typeof(SByte))
      return TypeCode.SByte;
    if (type == typeof(Single))
      return TypeCode.Single;
    if (type == typeof(String))
      return TypeCode.String;
    if (type == typeof(UInt16))
      return TypeCode.UInt16;
    if (type == typeof(UInt32))
      return TypeCode.UInt32;
    if (type == typeof(UInt64))
      return TypeCode.UInt64;
    if (type == typeof(DBNull))
      return TypeCode.DBNull;
    return TypeCode.Object;
  }

  /// <summary>
  /// Converts the value to the specified type.
  /// </summary>
  /// <param name="conversionType">The target type.</param>
  /// <param name="provider">The format provider.</param>
  /// <returns>The converted value.</returns>
  public virtual object? ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType.Name.StartsWith("Nullable`"))
      conversionType = conversionType.GetGenericArguments()[0];
    if (_value?.GetType() == conversionType)
      return _value;
    if (conversionType == typeof(Boolean)) return ToBoolean(provider);
    if (conversionType == typeof(Byte)) return ToByte(provider);
    if (conversionType == typeof(SByte)) return ToSByte(provider);
    if (conversionType == typeof(Int16)) return ToInt16(provider);
    if (conversionType == typeof(UInt16)) return ToUInt16(provider);
    if (conversionType == typeof(Int32)) return ToInt32(provider);
    if (conversionType == typeof(UInt32)) return ToUInt32(provider);
    if (conversionType == typeof(Int64)) return ToInt64(provider);
    if (conversionType == typeof(UInt64)) return ToUInt64(provider);
    if (conversionType == typeof(Decimal)) return ToDecimal(provider);
    if (conversionType == typeof(Double)) return ToDouble(provider);
    if (conversionType == typeof(Single)) return ToSingle(provider);
    if (conversionType == typeof(DateOnly)) return ToDateOnly(provider);
    if (conversionType == typeof(DateTime)) return ToDateTime(provider);
    if (conversionType.IsEnum) return typeof(Variant).GetMethod("ToEnum")?.MakeGenericMethod(conversionType).Invoke(this, new object?[] { provider });
    if (conversionType == typeof(String)) return ToString(provider);
    if (conversionType == typeof(Char)) return ToChar(provider);
    if (conversionType == typeof(Guid)) return ToGuid(provider);
    if (conversionType == typeof(byte[])) return ToBytes(provider);
    if (conversionType == typeof(Variant)) return this;
    if (conversionType == typeof(object)) return this;
    if (conversionType == typeof(VectorVariant))
      return new VectorVariant { this };

    if (conversionType.TryGetConverter(out var typeConverter) && typeConverter != null)
    {
      if (_value is string && typeConverter.CanConvertFrom(typeof(string)))
        return typeConverter.ConvertFrom(_value);
    }
    throw new InvalidOperationException($"Can't convert Variant to {conversionType} type");
  }

  /// <summary>
  /// Converts the value to a boolean.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The boolean value.</returns>
  public virtual bool ToBoolean(IFormatProvider? provider = null)
  {
    if (Value is string str)
    {
      if (str == "1") return true;
      if (str == "0") return false;
    }
    return Convert.ToBoolean(Value);
  }

  /// <summary>
  /// Converts the value to a byte.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The byte value.</returns>
  public virtual byte ToByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Byte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToByte(Value);
  }

  /// <summary>
  /// Converts the value to an sbyte.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The sbyte value.</returns>
  public virtual sbyte ToSByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return SByte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToSByte(Value);
  }

  /// <summary>
  /// Converts the value to a short.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The short value.</returns>
  public virtual short ToInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt16(Value);
  }

  /// <summary>
  /// Converts the value to an unsigned short.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The ushort value.</returns>
  public virtual ushort ToUInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt16(Value);
  }

  /// <summary>
  /// Converts the value to an int.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The int value.</returns>
  public virtual int ToInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt32(Value);
  }

  /// <summary>
  /// Converts the value to an unsigned int.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The uint value.</returns>
  public virtual uint ToUInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt32(Value);
  }

  /// <summary>
  /// Converts the value to a long.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The long value.</returns>
  public virtual long ToInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt64(Value);
  }

  /// <summary>
  /// Converts the value to an unsigned long.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The ulong value.</returns>
  public virtual ulong ToUInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt64(Value);
  }

  /// <summary>
  /// Converts the value to a decimal.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The decimal value.</returns>
  public virtual decimal ToDecimal(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToDecimal(str);
    return Convert.ToDecimal(Value);
  }

  /// <summary>
  /// Converts the value to a float.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The float value.</returns>
  public virtual float ToSingle(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToSingle(str);
    return Convert.ToSingle(Value);
  }

  /// <summary>
  /// Converts the value to a double.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The double value.</returns>
  public virtual double ToDouble(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToDouble(str);
    return Convert.ToDouble(Value);
  }

  /// <summary>
  /// Converts the value to a DateTime.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The DateTime value.</returns>
  public virtual DateTime ToDateTime(IFormatProvider? provider = null)
  {
    if (Value is DateOnly dateOnly)
      return dateOnly.ToDateTime(default);
    return Convert.ToDateTime(Value);
  }

  /// <summary>
  /// Converts the value to a string.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The string value.</returns>
  public virtual string? ToString(IFormatProvider? provider = null)
  {
    if (Value is byte[] bytes)
      return Convert.ToBase64String(bytes);
    if (VariantType == VariantType.Date)
      return ToDateOnly().ToString("yyyy-MM-dd");
    if (VariantType == VariantType.DateTime)
      return Value?.ToString();
    if (_value?.GetType().TryGetConverter(out var typeConverter) == true)
    {
      if (typeConverter != null && typeConverter.CanConvertTo(typeof(string)))
        return typeConverter.ConvertToInvariantString(_value);
    }
    var result = Convert.ToString(Value, CultureInfo.InvariantCulture);
    return result;
  }

  /// <summary>
  /// Converts the value to a char.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The char value.</returns>
  public virtual char ToChar(IFormatProvider? provider = null)
  {
    return Convert.ToChar(Value);
  }

  /// <summary>
  /// Converts the value to the specified enum type.
  /// </summary>
  /// <typeparam name="EnumType">The enum type to convert to.</typeparam>
  /// <param name="provider">The format provider.</param>
  /// <returns>The enum value.</returns>
  public virtual EnumType ToEnum<EnumType>(IFormatProvider? provider = null)
    where EnumType : struct, IConvertible
  {
    if (Value is string str)
      return Enum.Parse<EnumType>(str);
    if (Value != null)
      return (EnumType)Enum.ToObject(typeof(EnumType), Value);
    throw new InvalidOperationException($"ValueType is null when converting variant to Enum");
  }

  /// <summary>
  /// Returns the value stored in the variant.
  /// </summary>
  /// <returns>The value as an object.</returns>
  public object? GetValue()
  {
#if TraceSetValue
    Debug.WriteLine($"GetValue()");
#endif
    var val = ConvertValue(VariantType, _value);
    if (val != null && VariantType == VariantType.Enum && ValueType != null)
    {
      if (val is string str)
        val = Enum.Parse(ValueType, str);
      else
        val = Enum.ToObject(ValueType, val);
    }
    return val;
  }

  /// <summary>
  /// Converts a value to the appropriate type for the specified variant type.
  /// </summary>
  /// <param name="variantType">The variant type.</param>
  /// <param name="value">The value to convert.</param>
  /// <returns>The converted value.</returns>
  public static object? ConvertValue(VariantType variantType, object? value)
  {
    switch (variantType)
    {
      case VariantType.Variant:
        if (value is Variant vVariant)
          return vVariant;
        return new Variant(value);

      case VariantType.SByte:
        return Convert.ToSByte(value);

      case VariantType.Int16:
        return Convert.ToInt16(value);

      case VariantType.Int32:
        return Convert.ToInt32(value);

      case VariantType.Int64:
        return Convert.ToInt64(value);

      case VariantType.Integer:
        if (value is string)
          return XmlConvert.ToDecimal((string)value);
        return Convert.ToDecimal(value);

      case VariantType.Byte:
        return Convert.ToByte(value);

      case VariantType.UInt16:
        return Convert.ToUInt16(value);

      case VariantType.UInt32:
        return Convert.ToUInt32(value);

      case VariantType.UInt64:
        return Convert.ToUInt64(value);

      case VariantType.UnsignedInteger:
        if (value is string)
          return XmlConvert.ToDecimal((string)value);
        return Convert.ToDecimal(value);

      case VariantType.Single:
        if (value is string)
          return XmlConvert.ToSingle((string)value);
        return Convert.ToSingle(value);

      case VariantType.Double:
        if (value is string)
          return XmlConvert.ToDouble((string)value);
        return Convert.ToDouble(value);

      case VariantType.Decimal:
        if (value is string)
          return XmlConvert.ToDecimal((string)value);
        return Convert.ToDecimal(value);

      case VariantType.Lpstr:
        return Convert.ToString(value);

      case VariantType.Lpwstr:
        return Convert.ToString(value);

      case VariantType.Bstr:
        return Convert.ToString(value);

      case VariantType.Char:
        return Convert.ToChar(value);

      case VariantType.Date:
        if (value is string)
          return DateOnly.Parse((string)value);
        if (value is DateOnly dtOnly)
          return dtOnly;
        return Convert.ToDateTime(value);

      case VariantType.DateTime:
        if (value is string)
          return Convert.ToDateTime((string)value);
        if (value is DateTime dt)
          return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
        return Convert.ToDateTime(value);

      case VariantType.Boolean:
        return Convert.ToBoolean(value);

      case VariantType.Currency:
        if (value is string)
          return XmlConvert.ToDecimal((string)value);
        return Convert.ToDecimal(value);

      case VariantType.Null:
        return DBNull.Value;

      case VariantType.Empty:
        return null;

      case VariantType.HexInt:
        if (value is string hstr)
          return new HexInt(hstr);
        if (value is int int32)
          return (HexInt)int32;
        if (value is ushort uint16)
          return (HexInt)uint16;
        if (value is HexInt hexWord)
          return hexWord;
        if (value != null)
          throw new InvalidOperationException($"Can't assign value of type {value.GetType()} to {variantType} type Variant");
        return null;

      case VariantType.Enum:
        return value;
      case VariantType.Object:
        return value;

      case VariantType.Guid:
        if (value is string gstr)
          return new Guid(gstr);
        if (value is Guid guid)
          return guid;
        if (value != null)
          throw new InvalidOperationException($"Can't assign value of type {value.GetType()} to {variantType} type Variant");
        return null;

      case VariantType.ClipboardData:
        if (value is VClipboardData vClipboardData)
          return vClipboardData;
        if (value != null)
          throw new InvalidOperationException($"Can't assign value of type {value.GetType()} to {variantType} type Variant");
        return null;

      case VariantType.Blob:
      case VariantType.OBlob:
      case VariantType.Storage:
      case VariantType.OStorage:
      case VariantType.Stream:
      case VariantType.OStream:
        if (value is byte[] bytes)
          return bytes;
        if (value is string bstr)
          return Convert.FromBase64String(bstr);
        if (value != null)
          throw new InvalidOperationException($"Can't assign value of type {value.GetType()} to {variantType} type Variant");
        return null;

      case VariantType.VStream:
        if (value is VStreamData vStreamData)
          return vStreamData;
        if (value != null)
          throw new InvalidOperationException($"Can't assign value of type {value.GetType()} to {variantType} type Variant");
        return null;

      case VariantType.Vector:
        if (value is IEnumerable)
          return value;
        throw new InvalidOperationException($"Can't assign value of type {value?.GetType()} to {variantType} type Variant");

      case VariantType.Array:
        if (value is Array array)
          return array;
        throw new InvalidOperationException($"Can't assign value of type {value?.GetType()} to {variantType} type Variant");

      default:
        return value;
    }
  }

  public static implicit operator string(Variant value)
  {
    return value.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
  }

  public static implicit operator Variant(string value)
  {
    return new Variant(VariantType.Lpwstr, value);
  }

  public static implicit operator bool(Variant value)
  {
    return value.ToBoolean();
  }

  public static implicit operator Variant(bool value)
  {
    return new Variant(VariantType.Boolean, value);
  }

  public static implicit operator byte(Variant value)
  {
    return value.ToByte();
  }

  public static implicit operator Variant(byte value)
  {
    return new Variant(VariantType.Byte, value);
  }

  public static implicit operator sbyte(Variant value)
  {
    return value.ToSByte();
  }

  public static implicit operator Variant(sbyte value)
  {
    return new Variant(VariantType.SByte, value);
  }

  public static implicit operator Int16(Variant value)
  {
    return value.ToInt16();
  }

  public static implicit operator Variant(Int16 value)
  {
    return new Variant(VariantType.Int16, value);
  }

  public static implicit operator UInt16(Variant value)
  {
    return value.ToUInt16();
  }

  public static implicit operator Variant(UInt16 value)
  {
    return new Variant(VariantType.UInt16, value);
  }

  public static implicit operator Int32(Variant value)
  {
    return value.ToInt32();
  }

  public static implicit operator Variant(Int32 value)
  {
    return new Variant(VariantType.Int32, value);
  }

  public static implicit operator UInt32(Variant value)
  {
    return value.ToUInt32();
  }

  public static implicit operator Variant(UInt32 value)
  {
    return new Variant(VariantType.UInt32, value);
  }

  public static implicit operator Int64(Variant value)
  {
    return value.ToInt64();
  }

  public static implicit operator Variant(Int64 value)
  {
    return new Variant(VariantType.Int64, value);
  }

  public static implicit operator UInt64(Variant value)
  {
    return value.ToUInt64();
  }

  public static implicit operator Variant(UInt64 value)
  {
    return new Variant(VariantType.UInt64, value);
  }

  public static implicit operator Decimal(Variant value)
  {
    return value.ToDecimal();
  }

  public static implicit operator Variant(Decimal value)
  {
    return new Variant(VariantType.Decimal, value);
  }

  public static implicit operator Single(Variant value)
  {
    return value.ToSingle();
  }

  public static implicit operator Variant(Single value)
  {
    return new Variant(VariantType.Single, value);
  }

  public static implicit operator Double(Variant value)
  {
    return value.ToDouble();
  }

  public static implicit operator Variant(Double value)
  {
    return new Variant(VariantType.Double, value);
  }


  public static implicit operator DateTime(Variant value)
  {
    return value.ToDateTime();
  }

  public static implicit operator Variant(DateTime value)
  {
    return new Variant(VariantType.DateTime, value);
  }

  public static implicit operator byte[](Variant value)
  {
    return value.ToBytes();
  }

  public static implicit operator Variant(byte[] value)
  {
    return new Variant(VariantType.Blob, value);
  }

  /// <summary>
  /// Converts the value to a <see cref="DateOnly"/>.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The <see cref="DateOnly"/> value.</returns>
  public virtual DateOnly ToDateOnly(IFormatProvider? provider = null)
  {
    if (Value is DateOnly dateOnly)
      return dateOnly;
    if (Value is DateTime dateTime)
      return DateOnly.FromDateTime(dateTime);
    if (Value is string str)
      return DateOnly.Parse(str);
    if (Value == null)
      throw new InvalidOperationException("Can't convert null value to DateOnly");
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType()} to DateOnly");
  }

  /// <summary>
  /// Converts the value to a <see cref="Guid"/>.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The <see cref="Guid"/> value.</returns>
  public virtual Guid ToGuid(IFormatProvider? provider = null)
  {
    if (Value is null)
      return Guid.Empty;
    if (Value is Guid guid)
      return guid;
    if (Value is String str)
      return Guid.Parse(str);
    if (Value is byte[] bytes)
      return new Guid(bytes);
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType()} to Guid");
  }

  /// <summary>
  /// Converts the value to a byte array.
  /// </summary>
  /// <param name="provider">The format provider.</param>
  /// <returns>The byte array value.</returns>
  public virtual byte[] ToBytes(IFormatProvider? provider = null)
  {
    if (Value is null)
      return [];
    if (Value is Guid guid)
      return guid.ToByteArray();
    if (Value is String str)
      return Convert.FromBase64String(str);
    if (Value is byte[] bytes)
      return bytes;
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType()} to byte[]");
  }

  /// <summary>
  /// Converts the value to the specified type as a <see cref="Variant"/>.
  /// </summary>
  /// <param name="destinationType">The destination type.</param>
  /// <returns>The converted <see cref="Variant"/>.</returns>
  public Variant? ConvertTo(Type destinationType)
  {
    if (destinationType == typeof(bool))
      return new Variant(VariantType.Boolean, ToBoolean());
    if (destinationType == typeof(string))
      return new Variant(VariantType.Lpwstr, ToString());
    if (destinationType == typeof(int))
      return new Variant(VariantType.Int32, ToInt32());
    if (destinationType == typeof(double))
      return new Variant(VariantType.Double, ToDouble());
    if (destinationType == typeof(DateTime))
      return new Variant(VariantType.DateTime, ToDateTime());
    if (destinationType == typeof(Guid))
      return new Variant(VariantType.Guid, ToGuid());
    if (destinationType == typeof(byte))
      return new Variant(VariantType.Byte, ToByte());
    if (destinationType == typeof(sbyte))
      return new Variant(VariantType.SByte, ToSByte());
    if (destinationType == typeof(byte))
      return new Variant(VariantType.Byte, ToByte());
    if (destinationType == typeof(short))
      return new Variant(VariantType.Int16, ToInt16());
    if (destinationType == typeof(ushort))
      return new Variant(VariantType.UInt16, ToUInt16());
    if (destinationType == typeof(uint))
      return new Variant(VariantType.UInt32, ToUInt32());
    if (destinationType == typeof(long))
      return new Variant(VariantType.Int64, ToInt64());
    if (destinationType == typeof(ulong))
      return new Variant(VariantType.UInt64, ToUInt64());
    if (destinationType == typeof(decimal))
      return new Variant(VariantType.Decimal, ToDecimal());
    if (destinationType == typeof(float))
      return new Variant(VariantType.Single, ToSingle());
    if (destinationType == typeof(DateOnly))
      return new Variant(VariantType.Date, ToDateOnly());
    if (destinationType == typeof(Char))
      return new Variant(VariantType.Char, ToChar());
    if (destinationType == typeof(byte[]))
      return new Variant(VariantType.Blob, ToBytes());

    throw new InvalidOperationException($"Can't convert variant value to {destinationType}");
  }

  /// <summary>
  /// Converts a value to the specified type, using the provided context and culture.
  /// </summary>
  /// <param name="context">The type descriptor context.</param>
  /// <param name="culture">The culture info.</param>
  /// <param name="value">The value to convert.</param>
  /// <param name="destinationType">The destination type.</param>
  /// <returns>The converted value.</returns>
  public static object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (destinationType == typeof(string))
    {
      if (value is null)
        return null;
      if (value is Boolean vBoolean)
        return Convert.ToString(vBoolean);
      if (value is Byte vByte)
        return Convert.ToString(vByte);
      if (value is Char vChar)
        return Convert.ToString(vChar);
      if (value is DateOnly vDateOnly)
        return vDateOnly.ToString("yyyy-MM-dd");
      if (value is DateTime vDateTime)
        return XmlConvert.ToString(vDateTime);
      if (value is Decimal vDecimal)
        return XmlConvert.ToString(vDecimal);
      if (value is Double vDouble)
        return XmlConvert.ToString(vDouble);
      if (value is Int16 vInt16)
        return Convert.ToString(vInt16);
      if (value is Int32 vInt32)
        return Convert.ToString(vInt32);
      if (value is Int64 vInt64)
        return Convert.ToString(vInt64);
      if (value is SByte vSByte)
        return Convert.ToString(vSByte);
      if (value is Single vSingle)
        return XmlConvert.ToString(vSingle);
      if (value is String str)
        return Convert.ToString(str);
      if (value is UInt16 vUInt16)
        return Convert.ToString(vUInt16);
      if (value is UInt32 vUInt32)
        return Convert.ToString(vUInt32);
      if (value is UInt64 vUInt64)
        return Convert.ToString(vUInt64);
      if (value is DBNull)
        return "DBNull";
      if (value is HexInt vWord)
        return vWord.ToString(CultureInfo.InvariantCulture);
      return Convert.ToString(value);
    }
    throw new InvalidOperationException($"Can't convert variant value to {destinationType}");
  }

  /// <summary>
  /// Converts a value from the specified context and culture.
  /// </summary>
  /// <param name="context">The type descriptor context.</param>
  /// <param name="culture">The culture info.</param>
  /// <param name="value">The value to convert.</param>
  /// <returns>The converted value.</returns>
  public static object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (context?.Instance is Variant variant)
    {
      var val = ConvertValue(variant.VariantType, value);
      return val;
    }
    return value;
  }

  /// <summary>
  /// Returns a hash code for the variant.
  /// </summary>
  /// <returns>The hash code.</returns>
  public override int GetHashCode()
  {
    return HashCode.Combine(_value, (int)_variantType, _valueType);
  }

  /// <summary>
  /// Returns a string representation of the variant, including its type name.
  /// </summary>
  /// <returns>The string representation.</returns>
  public override string? ToString()
  {
    return ToString(CultureInfo.InvariantCulture) + $" ({TypeName})";
  }

  /// <summary>
  /// Determines whether the current Variant instance is equal to the specified Variant.
  /// </summary>
  /// <remarks>Equality is determined by comparing the underlying value, variant type, and value type of both
  /// instances.</remarks>
  /// <param name="other">The Variant instance to compare with the current instance. Can be null.</param>
  /// <returns>true if the specified Variant is equal to the current instance; otherwise, false.</returns>
  public bool Equals(Variant? other)
  {
    if (other is null) return false;
    if (ReferenceEquals(this, other)) return true;
    if (_variantType != other._variantType) return false;

    if (_value?.GetType().IsArray == true && other._value?.GetType().IsArray == true)
    {
      var array1 = (Array)_value;
      var array2 = (Array)other._value;
      if (array1.Length != array2.Length) return false;
      for (int i = 0; i < array1.Length; i++)
      {
        var item1 = array1.GetValue(i);
        var item2 = array2.GetValue(i);
        if (!Equals(item1, item2)) return false;
      }
    }
    else
    {
      var str1 = this.ToString(CultureInfo.InvariantCulture);
      var str2 = other.ToString(CultureInfo.InvariantCulture);
      if (!Equals(str1, str2)) return false;
    }

    return true;
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current Variant instance.
  /// </summary>
  /// <remarks>Equality is determined by comparing the type and value of the Variant. If obj is null or of a
  /// different type, the method returns false.</remarks>
  /// <param name="obj">The object to compare with the current Variant. Can be null.</param>
  /// <returns>true if the specified object is a Variant and is equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return Equals((Variant)obj);
  }
}