using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Variant implementation. Value is of any type.
/// </summary>
[XmlInclude(typeof(DateOnly))]
[XmlInclude(typeof(DBNull))]
public record Variant: IConvertible
{
  public Variant()
  {
  }

  public Variant(object? value)
  {
    SetValue(value);
  }

  public Variant(VariantType variantType)
  {
    VariantType = variantType;
  }

  public Variant(VariantType variantType, object? value)
  {
    SetValue(value);
    VariantType = variantType;
  }

  [XmlAttribute]
  public virtual VariantType VariantType { get; set; }

  public virtual object? Value
  {
    get => _value;
    set => _value = value;
  }
  protected object? _value;

  public void SetValue(object? value)
  {
    if (value is Boolean vBool)
    {
      VariantType = VariantType.Boolean;
      Value = vBool;
      return;
    }

    if (value is string vString)
    {
      VariantType = VariantType.Lpwstr;
      VariantType = VariantType.Boolean;
      Value = vString;
      return;
    }

    if (value is Byte vByte)
    {
      VariantType = VariantType.Byte;
      Value = vByte;
      return;
    }

    if (value is SByte vSByte)
    {
      VariantType = VariantType.SByte;
      Value = vSByte;
      return;
    }

    if (value is short vShort)
    {
      VariantType = VariantType.Int16;
      Value = vShort;
      return;
    }

    if (value is ushort vUShort)
    {
      VariantType = VariantType.UInt16;
      Value = vUShort;
      return;
    }

    if (value is Int32 vInt32)
    {
      VariantType = VariantType.Int32;
      Value = vInt32;
      return;
    }

    if (value is UInt32 vUInt32)
    {
      VariantType = VariantType.UInt32;
      Value = vUInt32;
      return;
    }

    if (value is Int64 vInt64)
    {
      VariantType = VariantType.Int64;
      Value = vInt64;
      return;
    }

    if (value is UInt64 vUInt64)
    {
      VariantType = VariantType.UInt64;
      Value = vUInt64;
      return;
    }

    if (value is float vFloat)
    {
      VariantType = VariantType.Single;
      Value = vFloat;
      return;
    }

    if (value is Double vDouble)
    {
      VariantType = VariantType.Double;
      Value = vDouble;
      return;
    }

    if (value is Decimal vDecimal)
    {
      VariantType = VariantType.Decimal;
      Value = vDecimal;
      return;
    }

    if (value is DateOnly vDate)
    {
      VariantType = VariantType.Date;
      Value = vDate.ToDateTime(default(TimeOnly));
      return;
    }

    if (value is DateTime vFileTime)
    {
      VariantType = VariantType.DateTime;
      Value = vFileTime;
      return;
    }

    if (value is DBNull)
    {
      VariantType = VariantType.Null;
      Value = DBNull.Value;
      return;
    }

    if (value is null)
    {
      VariantType = VariantType.Empty;
      Value = null;
      return;
    }

    if (value is Guid vclassId)
    {
      VariantType = VariantType.Guid;
      Value = vclassId;
      return;
    }

    if (value is HexWord vError)
    {
      VariantType = VariantType.HexInt;
      Value = vError;
      return;
    }

    if (value is byte[] vBlob)
    {
      VariantType = VariantType.Blob;
      Value = vBlob;
      return;
    };

    if (value is object[] oBlob)
    {
      VariantType = VariantType.OBlob;
      Value = oBlob;
      return;
    };

    if (value is Variant variant)
    {
      Value = variant;
      return;
    }

    if (value is Object vObj)
    {
      Value = vObj;
      return;
    }
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
    if (Value is Int16)
      return TypeCode.UInt16;
    if (Value is UInt32)
      return TypeCode.UInt32;
    if (Value is UInt64)
      return TypeCode.UInt64;
    if (Value is DBNull)
      return TypeCode.DBNull;
    return TypeCode.Object;
  }

  public virtual object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(Boolean)) return ToBoolean(provider);
    else if (conversionType == typeof(Byte)) return ToByte(provider);
    else if (conversionType == typeof(SByte)) return ToSByte(provider);
    else if (conversionType == typeof(Int16)) return ToInt16(provider);
    else if (conversionType == typeof(UInt16)) return ToUInt16(provider);
    else if (conversionType == typeof(Int32)) return ToInt32(provider);
    else if (conversionType == typeof(UInt32)) return ToUInt32(provider);
    else if (conversionType == typeof(Int64)) return ToInt64(provider);
    else if (conversionType == typeof(UInt64)) return ToUInt64(provider);
    else if (conversionType == typeof(Decimal)) return ToDecimal(provider);
    else if (conversionType == typeof(Double)) return ToDouble(provider);
    else if (conversionType == typeof(Single)) return ToSingle(provider);
    else if (conversionType == typeof(DateOnly)) return ToDateOnly(provider);
    else if (conversionType == typeof(DateTime)) return ToDateTime(provider);
    else if (conversionType == typeof(String)) return ToString(provider);
    else if (conversionType == typeof(Char)) return ToChar(provider);
    else if (conversionType == typeof(Guid)) return ToGuid(provider);
    else if (conversionType == typeof(byte[])) return ToBytes(provider);
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

  public static implicit operator bool(Variant value) => value.ToBoolean();
  public static implicit operator Variant(bool value) => new Variant(VariantType.Boolean, value);

  public virtual byte ToByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Byte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToByte(Value);
  }

  public static implicit operator byte(Variant value) => value.ToByte();
  public static implicit operator Variant(byte value) => new Variant(VariantType.Byte, value);

  public virtual sbyte ToSByte(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return SByte.Parse(str, NumberStyles.HexNumber);
    return Convert.ToSByte(Value);
  }

  public static implicit operator sbyte(Variant value) => value.ToSByte();
  public static implicit operator Variant(sbyte value) => new Variant(VariantType.SByte, value);

  public virtual short ToInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt16(Value);
  }

  public static implicit operator Int16(Variant value) => value.ToInt16();
  public static implicit operator Variant(Int16 value) => new Variant(VariantType.Int16, value);

  public virtual ushort ToUInt16(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt16.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt16(Value);
  }

  public static implicit operator UInt16(Variant value) => value.ToUInt16();
  public static implicit operator Variant(UInt16 value) => new Variant(VariantType.UInt16, value);

  public virtual int ToInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt32(Value);
  }

  public static implicit operator Int32(Variant value) => value.ToInt32();
  public static implicit operator Variant(Int32 value) => new Variant(VariantType.Int32, value);

  public virtual uint ToUInt32(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt32.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt32(Value);
  }

  public static implicit operator UInt32(Variant value) => value.ToUInt32();
  public static implicit operator Variant(UInt32 value) => new Variant(VariantType.UInt32, value);

  public virtual long ToInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return Int64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToInt64(Value);
  }

  public static implicit operator Int64(Variant value) => value.ToInt64();
  public static implicit operator Variant(Int64 value) => new Variant(VariantType.Int64, value);

  public virtual ulong ToUInt64(IFormatProvider? provider = null)
  {
    if (VariantType == VariantType.HexInt && Value is string str)
      return UInt64.Parse(str, NumberStyles.HexNumber);
    return Convert.ToUInt64(Value);
  }

  public static implicit operator UInt64(Variant value) => value.ToUInt64();
  public static implicit operator Variant(UInt64 value) => new Variant(VariantType.UInt64, value);

  public virtual decimal ToDecimal(IFormatProvider? provider = null)
  {
    return Convert.ToDecimal(Value);
  }

  public static implicit operator Decimal(Variant value) => value.ToDecimal();
  public static implicit operator Variant(Decimal value) => new Variant(VariantType.Decimal, value);

  public virtual float ToSingle(IFormatProvider? provider = null)
  {
    return Convert.ToSingle(Value);
  }

  public static implicit operator Single(Variant value) => value.ToSingle();
  public static implicit operator Variant(Single value) => new Variant(VariantType.Single, value);

  public virtual double ToDouble(IFormatProvider? provider = null)
  {
    return Convert.ToDouble(Value);
  }

  public static implicit operator Double(Variant value) => value.ToDouble();
  public static implicit operator Variant(Double value) => new Variant(VariantType.Double, value);

  public virtual DateOnly ToDateOnly(IFormatProvider? provider = null)
  {
    if (Value is DateOnly dateOnly)
      return dateOnly;
    if (Value is DateTime dateTime)
      return DateOnly.FromDateTime(dateTime);
    if (Value is string str)
      return DateOnly.Parse(str);
    if (Value == null)
      throw new InvalidOperationException($"Can't convert null value to DateOnly");
    throw new InvalidOperationException($"Can't convert value of type {Value.GetType()} to DateOnly");
  }

  public static implicit operator DateOnly(Variant value) => value.ToDateOnly();
  public static implicit operator Variant(DateOnly value) => new Variant(VariantType.Date, value);

  public virtual DateTime ToDateTime(IFormatProvider? provider = null)
  {
    if (Value is DateOnly dateOnly)
      return dateOnly.ToDateTime(default(TimeOnly));
    return Convert.ToDateTime(Value);
  }

  public static implicit operator DateTime(Variant value) => value.ToDateTime();
  public static implicit operator Variant(DateTime value) => new Variant(VariantType.DateTime, value);

  public virtual string ToString(IFormatProvider? provider = null)
  {
    if (Value is byte[] bytes)
      return Convert.ToBase64String(bytes);
    return Convert.ToString(Value) ?? "";
  }

  public static implicit operator String(Variant value) => value.ToString();
  public static implicit operator Variant(String value) => new Variant(VariantType.Lpwstr, value);

  public virtual char ToChar(IFormatProvider? provider = null)
  {
    return Convert.ToChar(Value);
  }

  public static implicit operator Char(Variant value) => value.ToChar();
  public static implicit operator Variant(Char value) => new Variant(VariantType.Char, value);

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

  public static implicit operator Guid(Variant value) => value.ToGuid();
  public static implicit operator Variant(Guid value) => new Variant(VariantType.Guid, value);

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
  public static implicit operator byte[](Variant value) => value.ToBytes();
  public static implicit operator Variant(byte[] value) => new Variant(VariantType.Blob, value);
}
