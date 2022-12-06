using System.Collections.Generic;
using System;
using System.Collections;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Vector variant implementation. Value is a collection of objects of any type.
/// </summary>
public class VTVectorImpl : ModelElement<DocumentFormat.OpenXml.VariantTypes.VTVector>, VTVector
{
  public VTVectorImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTVector();
  }

  public VTVectorImpl(DocumentFormat.OpenXml.VariantTypes.VTVector element)
  {
    OpenXmlElement = element;
  }


  /// <summary>
  /// Vector Base Type
  /// </summary>
  public VectorBaseType? BaseType
  {
    get => (VectorBaseType?)OpenXmlElement?.BaseType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BaseType = (DocumentFormat.OpenXml.VariantTypes.VectorBaseValues?)value;
    }
  }


  private static Dictionary<VectorBaseType, Type> _itemTypes = new Dictionary<VectorBaseType, Type>
  {
    { VectorBaseType.Variant, typeof(Variant) },
    { VectorBaseType.OneByteSignedInteger, typeof(SByte) },
    { VectorBaseType.TwoBytesSignedInteger, typeof(Int16) },
    { VectorBaseType.FourBytesSignedInteger, typeof(Int32) },
    { VectorBaseType.EightBytesSignedInteger, typeof(Int64) },
    { VectorBaseType.OneByteUnsignedInteger, typeof(Byte) },
    { VectorBaseType.TwoBytesUnsignedInteger, typeof(UInt16) },
    { VectorBaseType.FourBytesUnsignedInteger, typeof(UInt32) },
    { VectorBaseType.EightBytesUnsignedInteger, typeof(UInt64) },
    { VectorBaseType.FourBytesReal, typeof(Single) },
    { VectorBaseType.EightBytesReal, typeof(Double) },
    { VectorBaseType.Lpstr, typeof(String) },
    { VectorBaseType.Lpwstr, typeof(String) },
    { VectorBaseType.Bstr, typeof(String) },
    { VectorBaseType.Date, typeof(DateTime) },
    { VectorBaseType.Filetime, typeof(DateTime) },
    { VectorBaseType.Bool, typeof(Boolean) },
    { VectorBaseType.Currency, typeof(Decimal) },
    { VectorBaseType.Error, typeof(HexInt) },
    { VectorBaseType.ClassId, typeof(Guid) },
    { VectorBaseType.ClipboardData, typeof(object) },
  };

  public IEnumerator<DocumentFormat.OpenXml.OpenXmlElement> GetOpenXmlElements()
  {
    if (OpenXmlElement != null)
      return OpenXmlElement.GetEnumerator();
    throw new InvalidOperationException("Can't enumerate Vector variant whith no OpenXmlElement");
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var itemType = (BaseType != null) ? _itemTypes[(VectorBaseType)BaseType] : null;
        _value = new List<object?>();
        foreach (var openXmlElement in OpenXmlElement.Elements())
        {
          var itemVariant = VariantImpl.CreateVariant(openXmlElement);
          var itemValue = (itemType != null) ?
            Convert.ChangeType(itemVariant, itemType) : itemVariant.Value;
          _value.Add(itemValue);
        }
      }
      return _value;
    }
    set
    {
      if (value != null)
      {
        var valueType = value.GetType();
        var valueIEnumerableInterface = valueType.GetInterface("IEnumerable`");
        var vectorItemType = (BaseType != null) ? _itemTypes[(VectorBaseType)BaseType] : typeof(object);
        var vectorListType = typeof(List<>).MakeGenericType(vectorItemType);
        _value = vectorListType.GetConstructor(new Type[0])?.Invoke(new object[0]) as IList;
        if (valueIEnumerableInterface != null)
        {
          var getEnumeratorMethod = valueIEnumerableInterface.GetMethod("GetEnumerator");
          if (getEnumeratorMethod == null)
            throw new InvalidOperationException($"GetEnumerator method for {valueType} not found");
          var enumerator = getEnumeratorMethod.Invoke(value, new object[0]) as IEnumerator;
          if (enumerator == null)
            throw new InvalidOperationException($"Can't get enumerator for {valueType} not found");
          enumerator.Reset();
          while (enumerator.MoveNext())
          {
            _value?.Add(enumerator.Current);
          }
        }
        if (OpenXmlElement != null)
        {
          OpenXmlElement.RemoveAllChildren();
          if (_value!=null)
            foreach (var itemValue in _value)
            {
              var itemVariant = VariantImpl.CreateVariant(itemValue);
              itemVariant.Value = itemValue;
              var openXmlElement = (itemVariant as DocumentModel.Impl.ModelElement)?.OpenXmlElement as DocumentFormat.OpenXml.OpenXmlElement;
              if (openXmlElement != null)
                OpenXmlElement.AppendChild(openXmlElement);
            }
        }
      }
      else
        _value = null;
    }
  }
  private IList? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  public object ToType(Type conversionType, IFormatProvider? provider)
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
    throw new InvalidOperationException($"Can't convert Vector Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Boolean");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Byte");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Decimal");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Double");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int16");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int32");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int64");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to SByte");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Single");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt16");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt32");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt64");
  }


}
