namespace DocumentModel.VariantTypes;

using ArrayBaseType = DocumentFormat.OpenXml.VariantTypes.ArrayBaseValues;

/// <summary>
/// Array variant implementation. Holds same type values. Value is of Array type.
/// </summary>
public class VTArrayImpl
{
  public DocumentFormat.OpenXml.VariantTypes.VTArray? OpenXmlElement { get; set; }

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
  public new ArrayBaseType? BaseType
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

  private static Dictionary<ArrayBaseType, Type> _itemTypes = 
    new Dictionary<ArrayBaseType, Type>
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

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        if (BaseType != null && _upperBounds != null && _lowerBounds != null)
        {
          var itemType = _itemTypes[(ArrayBaseType)BaseType];
          _value = Array.CreateInstance(itemType, (int)_upperBounds - (int)_lowerBounds + 1);
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
              var openXmlElement = (itemVariant as DocumentModel.VariantTypes.VariantImpl)?.OpenXmlElement;
              if (openXmlElement != null)
                OpenXmlElement.AppendChild(openXmlElement);
            }
        }
      }
    }
  }
  private Array? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Array variant to UInt64");
  }

  public override string ToString()
  {
    var ss = new List<string?>();
    var value = Value;
    if (value is IEnumerable enumerable)
      foreach (var item in enumerable)
        ss.Add(item.ToString());
    return "(" + String.Join(", ", ss) + ")";
  }
}
