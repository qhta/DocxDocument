//#define TraceSetValue

using System;
using System.ComponentModel;

using DocumentModel;

using Qhta.Conversion;
using Qhta.TypeUtils;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Variant implementation. Value is of any type.
/// </summary>
[JsonConverter(typeof(VariantJsonConverter))]
public partial class Variant : IConvertible, IEquatable<Variant>
{
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

  protected readonly object? _value;

  protected readonly VariantType _variantType;

  protected readonly Type? _valueType;

  public Variant()
  {
  }

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

  public Variant(VariantType variantType, object? value) : this(variantType, null, value)
  {
  }

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

  [XmlIgnore]
  public virtual VariantType VariantType
  {
    get => _variantType;
  }

  public virtual string TypeName
  {
    get
    {
      if (VariantType == VariantType.Enum)
        return ValueType?.FullName ?? "Enum";
      if (VariantType == VariantType.Object)
        return ValueType?.FullName ?? "Object";
      return VariantType.ToString();
    }
  }

  [XmlIgnore]
  public virtual Type? ValueType => _valueType;

  public virtual object? Value
  {
    get => GetValue();
  }

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

  public virtual bool ToBoolean(IFormatProvider? provider = null)
  {
    if (Value is string str)
    {
      if (str == "1") return true;
      if (str == "0") return false;
    }
    return Convert.ToBoolean(Value);
  }

  public virtual byte ToByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Byte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToByte(Value);
  }

  public virtual sbyte ToSByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return SByte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToSByte(Value);
  }

  public virtual short ToInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt16(Value);
  }

  public virtual ushort ToUInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt16(Value);
  }

  public virtual int ToInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt32(Value);
  }

  public virtual uint ToUInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt32(Value);
  }

  public virtual long ToInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt64(Value);
  }

  public virtual ulong ToUInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt64(Value);
  }

  public virtual decimal ToDecimal(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToDecimal(str);
    return Convert.ToDecimal(Value);
  }

  public virtual float ToSingle(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToSingle(str);
    return Convert.ToSingle(Value);
  }

  public virtual double ToDouble(IFormatProvider? provider = null)
  {
    if (_value is string str)
      return XmlConvert.ToDouble(str);
    return Convert.ToDouble(Value);
  }

  public virtual DateTime ToDateTime(IFormatProvider? provider = null)
  {
    if (Value is DateOnly dateOnly)
      return dateOnly.ToDateTime(default);
    return Convert.ToDateTime(Value);
  }

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

  public virtual char ToChar(IFormatProvider? provider = null)
  {
    return Convert.ToChar(Value);
  }

  public virtual EnumType ToEnum<EnumType>(IFormatProvider? provider = null)
  where EnumType : struct, IConvertible
  {
    if (Value is string str)
      return Enum.Parse<EnumType>(str);
    if (Value != null)
      return (EnumType)Enum.ToObject(typeof(EnumType), Value);
    throw new InvalidOperationException($"ValueType is null when converting variant to Enum");
  }

  public override bool Equals(object? obj)
  {
    if (obj == null) return false;
    if (obj is Variant other)
      return Equals(other);
    other = new Variant(obj);
    return Equals(other);
  }

  public virtual bool Equals(Variant? other)
  {
    if (other == null) return false;
    var result = false;
    if (this.Value == null && other.Value == null)
      return true;
    if (this.Value is byte[] thisBytes && other.Value is byte[] otherBytes)
      result = thisBytes.SequenceEqual(otherBytes);
    else if (this.Value is Variant thisVariant && other.Value is Variant otherVariant)
      result = thisVariant.Equals(otherVariant);
    else
    {
      result = this.Value?.Equals(other.Value) == true;
      if (!result)
      {
        var thisValueStr = this.ToString(CultureInfo.InvariantCulture);
        var otherValueStr = other.ToString(CultureInfo.InvariantCulture);
        result = String.Equals(thisValueStr, otherValueStr);
      }
    }
    return result;
  }

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

  public static implicit operator DateOnly(Variant value)
  {
    return value.ToDateOnly();
  }

  public static implicit operator Variant(DateOnly value)
  {
    return new Variant(VariantType.Date, value);
  }

  public static implicit operator DateTime(Variant value)
  {
    return value.ToDateTime();
  }

  public static implicit operator Variant(DateTime value)
  {
    return new Variant(VariantType.DateTime, value);
  }

  public static implicit operator string?(Variant value)
  {
    return value.ToString();
  }

  public static implicit operator Variant(string? value)
  {
    return new Variant(VariantType.Lpwstr, value);
  }

  public static implicit operator Char(Variant value)
  {
    return value.ToChar();
  }

  public static implicit operator Variant(Char value)
  {
    return new Variant(VariantType.Char, value);
  }

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
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType} to Guid");
  }

  public static implicit operator Guid(Variant value)
  {
    return value.ToGuid();
  }

  public static implicit operator Variant(Guid value)
  {
    return new Variant(VariantType.Guid, value);
  }

  public virtual byte[] ToBytes(IFormatProvider? provider = null)
  {
    if (Value is null)
      return new byte[0];
    if (Value is Guid guid)
      return guid.ToByteArray();
    if (Value is String str)
      return Convert.FromBase64String(str);
    if (Value is byte[] bytes)
      return bytes;
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType} to byte[]");
  }

  public static implicit operator byte[](Variant value)
  {
    return value.ToBytes();
  }

  public static implicit operator Variant(byte[] value)
  {
    return new Variant(VariantType.Blob, value);
  }

  public static object? Convert_ChangeType(object? value, Type targetType)
  {
    if (value is DateOnly dateOnly)
    {
      if (targetType == typeof(DateOnly))
        return dateOnly;
      if (targetType == typeof(DateTime))
        return dateOnly.ToDateTime(default);
      if (targetType == typeof(string))
        return dateOnly.ToString("yyyy-MM-dd");

      //if (Value == null)
      //  throw new InvalidOperationException($"Can't convert null value to DateOnly");
      throw new InvalidOperationException($"Can't convert DateOnly to {targetType} type");
    }
    if (targetType == typeof(DateOnly))
    {
      if (value is DateTime dateTime)
        return DateOnly.FromDateTime(dateTime);
      if (value is string str)
        return DateOnly.Parse(str);
      if (value == null)
        throw new InvalidOperationException("Can't convert null value to DateOnly type");
      throw new InvalidOperationException($"Can't convert value of type {value.GetType()} to DateOnly type");
    }
    return Convert.ChangeType(value, targetType);
  }

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
        return vWord.ToString();
      return Convert.ToString(value);
    }
    throw new InvalidOperationException($"Can't convert variant value to {destinationType}");
  }

  public static object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (context?.Instance is Variant variant)
    {
      var val = ConvertValue(variant.VariantType, value);
      return val;
    }
    return value;
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(VariantType, _value);
  }

  public override string? ToString()
  {
    return ToString(CultureInfo.InvariantCulture) + $" ({TypeName})";
  }
}