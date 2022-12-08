using System;
using DocumentModel.Impl;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Variant implementation. Value is of any type.

/// </summary>
public class VariantImpl : ModelElementImpl, Variant
{

  public DocumentFormat.OpenXml.VariantTypes.Variant? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.Variant?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public static Variant CreateVariant(DocumentFormat.OpenXml.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.Variant variant)
      return new VariantImpl(variant);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTBool vBool)
      return new VTBoolImpl(vBool);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTLPSTR vLPString)
      return new VTStringImpl(vLPString);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTLPWSTR vLPWString)
      return new VTStringImpl(vLPWString);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTBString vBString)
      return new VTStringImpl(vBString);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTByte vSByte)
      return new VTSignedByteImpl(vSByte);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte vByte)
      return new VTByteImpl(vByte);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTShort vShort)
      return new VTShortImpl(vShort);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort vUShort)
      return new VTUnsignedShortImpl(vUShort);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTInt32 vInt32)
      return new VTInt32Impl(vInt32);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 vUInt32)
      return new VTUnsignedInt32Impl(vUInt32);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTInt64 vInt64)
      return new VTInt64Impl(vInt64);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64 vUInt64)
      return new VTUnsignedInt64Impl(vUInt64);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTInteger vInteger)
      return new VTInt64Impl(vInteger);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger vUInteger)
      return new VTUnsignedInt64Impl(vUInteger);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTFloat vFloat)
      return new VTFloatImpl(vFloat);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTDouble vDouble)
      return new VTDoubleImpl(vDouble);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTDecimal vDecimal)
      return new VTDecimalImpl(vDecimal);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTCurrency vCurrency)
      return new VTCurrencyImpl(vCurrency);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTDate vDate)
      return new VTDateImpl(vDate);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTFileTime vFileTime)
      return new VTDateTimeImpl(vFileTime);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTNull vtNull)
      return new VTNullImpl(vtNull);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTEmpty vtEmpty)
      return new VTEmptyImpl(vtEmpty);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTClassId vclassId)
      return new VTClassIdImpl(vclassId);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTError vError)
      return new VTErrorImpl(vError);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTBlob vBlob)
      return new VTBlobImpl(vBlob);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTOBlob vOBlob)
      return new VTBlobImpl(vOBlob);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTStorage vStorage)
      return new VTStorageImpl(vStorage);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTOStorage vOStorage)
      return new VTStorageImpl(vOStorage);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTStreamData vStreamData)
      return new VTStreamImpl(vStreamData);
    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTOStreamData vOStreamData)
      return new VTStreamImpl(vOStreamData);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTVStreamData vVStreamData)
      return new VTVStreamImpl(vVStreamData);

    if (openXmlElement is DocumentFormat.OpenXml.VariantTypes.VTClipboardData vtClipboardData)
      return new VTClipboardDataImpl(vtClipboardData);
    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");
  }

  public static Variant CreateVariant(object value)
  {
    if (value is Boolean vBool)
      return new VTBoolImpl { Value = vBool };
    if (value is string vString)
      return new VTStringImpl { Value = vString };

    if (value is Byte vByte)
      return new VTByteImpl { Value = vByte };
    if (value is SByte vSByte)
      return new VTSignedByteImpl { Value = vSByte };

    if (value is short vShort)
      return new VTShortImpl{ Value = vShort};
    if (value is ushort vUShort)
      return new VTUnsignedShortImpl{ Value = vUShort};

    if (value is Int32 vInt32)
      return new VTInt32Impl{ Value = vInt32 };
    if (value is UInt32 vUInt32)
      return new VTUnsignedInt32Impl { Value = vUInt32 };

    if (value is Int64 vInt64)
      return new VTInt64Impl{ Value = vInt64 };
    if (value is UInt64 vUInt64)
      return new VTUnsignedInt64Impl{ Value = vUInt64 };

    if (value is float vFloat)
      return new VTFloatImpl{ Value = vFloat };
    if (value is Double vDouble)
      return new VTDoubleImpl{ Value = vDouble };

    if (value is Decimal vDecimal)
      return new VTDecimalImpl{ Value = vDecimal };

    if (value is DateOnly vDate)
      return new VTDateImpl{ Value = vDate };
    if (value is DateTime vFileTime)
      return new VTDateTimeImpl{ Value = vFileTime };

    if (value is DBNull)
      return new VTNullImpl();
    if (value is null)
      return new VTEmptyImpl();

    if (value is Guid vclassId)
      return new VTClassIdImpl{ Value = vclassId };
    //if (value is Error vError)
    //  return new VTErrorImpl{ Value = vError };

    if (value is byte[] vBlob)
      return new VTBlobImpl{ Value = vBlob };

    //if (value is Storage vStorage)
    //  return new VTStorageImpl{ Value = vStorage };
    //if (value is OStorage vOStorage)
    //  return new VTStorageImpl{ Value = vOStorage };

    //if (value is IStream vStreamData)
    //  return new VTStreamImpl{ Value = vStreamData };
    //if (value is OStreamData vOStreamData)
    //  return new VTStreamImpl{ Value = vOStreamData };

    //if (value is VStreamData vVStreamData)
    //  return new VTVStreamImpl{ Value = vVStreamData };

    //if (value is ClipboardData vtClipboardData)
    //  return new VTClipboardDataImpl{ Value = vtClipboardData };
    if (value is object variant)
      return new VariantImpl{ Value = variant };

    throw new InvalidOperationException($"Can't create variant for {value.GetType()} type");

  }

  public static Variant CreateVariant(ArrayBaseType kind)
  {
    switch (kind)
    {
      case ArrayBaseType.Variant:
        return new VariantImpl();
      case ArrayBaseType.Bool:
        return new VTBoolImpl();
      case ArrayBaseType.Bstr:
        return new VTStringImpl();
      case ArrayBaseType.OneByteSignedInteger:
        return new VTSignedByteImpl();
      case ArrayBaseType.OneByteUnsignedInteger:
        return new VTByteImpl();
      case ArrayBaseType.TwoBytesSignedInteger:
        return new VTShortImpl();
      case ArrayBaseType.TwoBytesUnsignedInteger:
        return new VTUnsignedShortImpl();
      case ArrayBaseType.FourBytesSignedInteger:
        return new VTInt32Impl();
      case ArrayBaseType.FourBytesUnsignedInteger:
        return new VTUnsignedInt32Impl();
      case ArrayBaseType.Integer:
        return new VTInt64Impl();
      case ArrayBaseType.UnsignedInteger:
        return new VTUnsignedInt64Impl();
      case ArrayBaseType.FourBytesReal:
        return new VTFloatImpl();
      case ArrayBaseType.EightBytesReal:
        return new VTDoubleImpl();
      case ArrayBaseType.Decimal:
        return new VTDecimalImpl();
      case ArrayBaseType.Currency:
        return new VTCurrencyImpl();
      case ArrayBaseType.Date:
        return new VTDateTimeImpl();
      case ArrayBaseType.Error:
        return new VTErrorImpl();
    }
    throw new InvalidOperationException($"Can't create variant for {kind} type");
  }

  public static Variant CreateVariant(VectorBaseType kind)
  {
    switch (kind)
    {
      case VectorBaseType.Variant:
        return new VariantImpl();
      case VectorBaseType.Bool:
        return new VTBoolImpl();
      case VectorBaseType.Bstr:
        return new VTStringImpl();
      case VectorBaseType.OneByteSignedInteger:
        return new VTSignedByteImpl();
      case VectorBaseType.OneByteUnsignedInteger:
        return new VTByteImpl();
      case VectorBaseType.TwoBytesSignedInteger:
        return new VTShortImpl();
      case VectorBaseType.TwoBytesUnsignedInteger:
        return new VTUnsignedShortImpl();
      case VectorBaseType.FourBytesSignedInteger:
        return new VTInt32Impl();
      case VectorBaseType.FourBytesUnsignedInteger:
        return new VTUnsignedInt32Impl();
      case VectorBaseType.EightBytesSignedInteger:
        return new VTInt64Impl();
      case VectorBaseType.EightBytesUnsignedInteger:
        return new VTUnsignedInt64Impl();
      case VectorBaseType.FourBytesReal:
        return new VTFloatImpl();
      case VectorBaseType.EightBytesReal:
        return new VTDoubleImpl();
      case VectorBaseType.Currency:
        return new VTCurrencyImpl();
      case VectorBaseType.Date:
        return new VTDateImpl();
      case VectorBaseType.Filetime:
        return new VTDateTimeImpl();
      case VectorBaseType.Error:
        return new VTErrorImpl();
    }
    throw new InvalidOperationException($"Can't create variant for {kind} type");
  }
  public VariantImpl() { }

  public VariantImpl(DocumentFormat.OpenXml.VariantTypes.Variant element)
  {
    _OpenXmlElement = element;
  }

  public virtual object? Value
  {
    get; set;
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
    else if (conversionType == typeof(Char)) return ToChar(provider);
    else if (conversionType == typeof(DateTime)) return ToDateTime(provider);
    else if (conversionType == typeof(Decimal)) return ToDecimal(provider);
    else if (conversionType == typeof(Double)) return ToDouble(provider);
    else if (conversionType == typeof(Int16)) return ToInt16(provider);
    else if (conversionType == typeof(Int32)) return ToInt32(provider);
    else if (conversionType == typeof(Int64)) return ToInt64(provider);
    else if (conversionType == typeof(SByte)) return ToSByte(provider);
    else if (conversionType == typeof(Single)) return ToSingle(provider);
    else if (conversionType == typeof(String)) return ToString(provider);
    else if (conversionType == typeof(UInt16)) return ToUInt16(provider);
    else if (conversionType == typeof(UInt32)) return ToUInt32(provider);
    else if (conversionType == typeof(UInt64)) return ToUInt64(provider);
    throw new InvalidOperationException($"Can't convert Variant to {conversionType} type");
  }

  public virtual bool ToBoolean(IFormatProvider? provider)
  {
    return Convert.ToBoolean(Value);
  }

  public virtual byte ToByte(IFormatProvider? provider)
  {
    return Convert.ToByte(Value);
  }

  public virtual char ToChar(IFormatProvider? provider)
  {
    return Convert.ToChar(Value);
  }

  public virtual DateTime ToDateTime(IFormatProvider? provider)
  {
    return Convert.ToDateTime(Value);
  }

  public virtual decimal ToDecimal(IFormatProvider? provider)
  {
    return Convert.ToDecimal(Value);
  }

  public virtual double ToDouble(IFormatProvider? provider)
  {
    return Convert.ToDouble(Value);
  }

  public virtual short ToInt16(IFormatProvider? provider)
  {
    return Convert.ToInt16(Value);
  }

  public virtual int ToInt32(IFormatProvider? provider)
  {
    return Convert.ToInt32(Value);
  }

  public virtual long ToInt64(IFormatProvider? provider)
  {
    return Convert.ToInt64(Value);
  }

  public virtual sbyte ToSByte(IFormatProvider? provider)
  {
    return Convert.ToSByte(Value);
  }

  public virtual float ToSingle(IFormatProvider? provider)
  {
    return Convert.ToSingle(Value);
  }

  public virtual string ToString(IFormatProvider? provider)
  {
    return Convert.ToString(Value) ?? "";
  }

  public virtual ushort ToUInt16(IFormatProvider? provider)
  {
    return Convert.ToUInt16(Value);
  }

  public virtual uint ToUInt32(IFormatProvider? provider)
  {
    return Convert.ToUInt32(Value);
  }

  public virtual ulong ToUInt64(IFormatProvider? provider)
  {
    return Convert.ToUInt64(Value);
  }

}
