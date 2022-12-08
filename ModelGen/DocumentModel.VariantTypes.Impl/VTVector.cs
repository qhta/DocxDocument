using System.Collections.Generic;
using System;
using System.Collections;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Vector variant implementation. Value is a collection of objects of any type.
/// </summary>
public class VTVectorImpl : VariantImpl, VTVector
{
  public new DocumentFormat.OpenXml.VariantTypes.VTVector? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTVector?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTVectorImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTVector();
  }

  public VTVectorImpl(DocumentFormat.OpenXml.VariantTypes.VTVector element)
  {
    OpenXmlElement = element;
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
    { VectorBaseType.Bstr, typeof(String) },
    { VectorBaseType.Lpstr, typeof(String) },
    { VectorBaseType.Lpwstr, typeof(String) },
    { VectorBaseType.Date, typeof(DateTime) },
    { VectorBaseType.Filetime, typeof(DateTime) },
    { VectorBaseType.Bool, typeof(Boolean) },
    { VectorBaseType.Currency, typeof(Decimal) },
    { VectorBaseType.Error, typeof(HexInt) },
    { VectorBaseType.ClassId, typeof(Guid) },
    { VectorBaseType.ClipboardData, typeof(byte[]) },
    { VectorBaseType.Variant, typeof(object) },
  };

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

  public IEnumerator<DocumentFormat.OpenXml.OpenXmlElement> GetOpenXmlElements()
  {
    if (OpenXmlElement != null)
      return OpenXmlElement.GetEnumerator();
    throw new InvalidOperationException("Can't enumerate Vector variant whith no OpenXmlElement");
  }

  public override object? Value
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
              var openXmlElement = (itemVariant as DocumentModel.Impl.ModelElementImpl)?._OpenXmlElement;
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Vector variant to UInt64");
  }


}
