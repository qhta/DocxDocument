using System;
using System.Collections.Generic;

using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Array variant implementation. Holds same type values. Value is of Array type.
/// </summary>
public class VTArrayImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTArray>, VTArray
{
  public VTArrayImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTArray();
  }

  public VTArrayImpl(DocumentFormat.OpenXml.VariantTypes.VTArray element)
  {
    OpenXmlElement = element;
  }

  /// <summary>
  /// Array Base Type
  /// </summary>
  public ArrayBaseType? BaseType
  {
    get => (OpenXmlElement?.BaseType?.Value != null) ? (ArrayBaseType?)OpenXmlElement.BaseType.Value : _arrayBaseKind;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BaseType = (DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues?)value;
      _arrayBaseKind = value;
    }
  }
  private ArrayBaseType? _arrayBaseKind;

  /// <summary>
  /// <para>Array Lower Bounds Attribute</para>
  /// </summary>
  public int? LowerBounds
  {
    get => (OpenXmlElement?.LowerBounds?.Value != null) ? OpenXmlElement.LowerBounds.Value : _lowerBounds;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LowerBounds = value;
      _lowerBounds = value;
    }
  }
  private int? _lowerBounds = 0;

  /// <summary>
  /// <para>Array Upper Bounds Attribute</para>
  /// </summary>
  public int? UpperBounds
  {
    get => (OpenXmlElement?.UpperBounds?.Value != null) ? OpenXmlElement.UpperBounds.Value : _upperBounds;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UpperBounds = value;
      _upperBounds = value;
    }
  }
  private int? _upperBounds;

  private static Dictionary<ArrayBaseType, Type> _itemTypes = new Dictionary<ArrayBaseType, Type>
  {
    { ArrayBaseType.Variant, typeof(Variant) },
    { ArrayBaseType.OneByteSignedInteger, typeof(SByte) },
    { ArrayBaseType.TwoBytesSignedInteger, typeof(Int16) },
    { ArrayBaseType.FourBytesSignedInteger, typeof(Int32) },
    { ArrayBaseType.Integer, typeof(Int64) },
    { ArrayBaseType.OneByteUnsignedInteger, typeof(Byte) },
    { ArrayBaseType.TwoBytesUnsignedInteger, typeof(UInt16) },
    { ArrayBaseType.FourBytesUnsignedInteger, typeof(UInt32) },
    { ArrayBaseType.UnsignedInteger, typeof(UInt64) },
    { ArrayBaseType.FourBytesReal, typeof(Single) },
    { ArrayBaseType.EightBytesReal, typeof(Double) },
    { ArrayBaseType.Decimal, typeof(Decimal) },
    { ArrayBaseType.Bstr, typeof(String) },
    { ArrayBaseType.Date, typeof(DateTime) },
    { ArrayBaseType.Bool, typeof(Boolean) },
    { ArrayBaseType.Currency, typeof(Decimal) },
    { ArrayBaseType.Error, typeof(HexInt) },
  };

  public IEnumerator<DocumentFormat.OpenXml.OpenXmlElement> GetOpenXmlElements()
  {
    if (OpenXmlElement != null)
      return OpenXmlElement.GetEnumerator();
    throw new InvalidOperationException("Can't enumerate Array variant whith no OpenXmlElement");
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        if (BaseType != null && _upperBounds != null && _lowerBounds != null)
        {
          var itemType = _itemTypes[(ArrayBaseType)BaseType];
          _value = Array.CreateInstance(itemType, (int)_upperBounds - (int)_lowerBounds+1);
          int index = 0;
          foreach (var openXmlElement in OpenXmlElement.Elements())
          {
            var itemVariant = VariantImpl.CreateVariant(openXmlElement);
            var itemValue = Convert.ChangeType(itemVariant, itemType);
            _value.SetValue(itemValue, index++);
          }
        }
      }
      return _value;
    }
    set
    {
      _value = (Array?)value;
      if (OpenXmlElement != null)
      {
        if (BaseType != null && _upperBounds != null && _lowerBounds != null)
        {
          OpenXmlElement.RemoveAllChildren();
          if (_value != null)
            for (int i = (int)_lowerBounds; i <= (int)_upperBounds; i++)
            {
              var itemValue = _value.GetValue(i - (int)_lowerBounds);
              var itemVariant = VariantImpl.CreateVariant((ArrayBaseType)BaseType);
              itemVariant.Value = itemValue;
              var openXmlElement = (itemVariant as DocumentModel.Impl.ModelElement)?.OpenXmlElement as DocumentFormat.OpenXml.OpenXmlElement;
              if (openXmlElement != null)
                OpenXmlElement.AppendChild(openXmlElement);
            }
        }
      }
    }
  }
  private Array? _value;

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
    throw new InvalidOperationException($"Can't convert Array Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Boolean");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Byte");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Decimal");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Double");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int16");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int32");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int64");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to SByte");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Single");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt16");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt32");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt64");
  }

}
