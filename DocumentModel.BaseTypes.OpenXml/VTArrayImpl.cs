using DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals;

namespace DocumentModel;

using ArrayBaseType = ArrayBaseValues;

/// <summary>
/// Array variant implementation. Holds same type values. Value is of Array type.
/// </summary>
public class VTArrayImpl : ModelElementImpl
{
  public VTArrayImpl()
  {
    OpenXmlElement = new VTArray();
  }

  public VTArrayImpl(VTArray element)
  {
    OpenXmlElement = element;
  }

  public VTArray? OpenXmlElement
  {
    get => (VTArray?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }


  /// <summary>
  /// Array Base Type
  /// </summary>
  public VariantType? BaseType
  {
    get => GetBaseType();
    set => SetBaseType(value);
  }

  /// <summary>
  /// <para>Array Lower Bounds Attribute</para>
  /// </summary>
  public int? LowerBounds
  {
    get => GetLowerBounds();
    set => SetLowerBounds(value);
  }

  /// <summary>
  /// <para>Array Upper Bounds Attribute</para>
  /// </summary>
  public int? UpperBounds
  {
    get => GetUpperBounds();
    set => SetUpperBounds(value);
  }

  public ArrayVariant? Value
  {
    get => GetValue();
    set => SetValue(value);
  }

  private static BiDiDictionary<ArrayBaseType, VariantType> ArrayBaseTypeConversion = new()
    {
      { ArrayBaseType.Variant, VariantType.Variant },
      { ArrayBaseType.OneByteSignedInteger, VariantType.SByte },
      { ArrayBaseType.TwoBytesSignedInteger, VariantType.Int16 },
      { ArrayBaseType.FourBytesSignedInteger, VariantType.Int32 },
      { ArrayBaseType.Integer, VariantType.Integer },
      { ArrayBaseType.OneByteUnsignedInteger, VariantType.Byte },
      { ArrayBaseType.TwoBytesUnsignedInteger, VariantType.UInt16 },
      { ArrayBaseType.FourBytesUnsignedInteger, VariantType.UInt32 },
      { ArrayBaseType.UnsignedInteger, VariantType.UnsignedInteger },
      { ArrayBaseType.FourBytesReal, VariantType.Single },
      { ArrayBaseType.EightBytesReal, VariantType.Double },
      { ArrayBaseType.Decimal, VariantType.Decimal },
      { ArrayBaseType.Bstr, VariantType.Bstr },
      { ArrayBaseType.Date, VariantType.Date },
      { ArrayBaseType.Bool, VariantType.Bool },
      { ArrayBaseType.Currency, VariantType.Currency },
      { ArrayBaseType.Error, VariantType.Error },
    };

  public IEnumerator<DocumentFormat.OpenXml.OpenXmlElement> GetOpenXmlElements()
  {
    if (OpenXmlElement != null)
      return OpenXmlElement.GetEnumerator();
    throw new InvalidOperationException("Can't enumerate Array variant whith no OpenXmlElement");
  }

  public VariantType? GetBaseType()
  {
    if (OpenXmlElement?.BaseType?.Value != null)
      return ArrayBaseTypeConversion.GetValue2(OpenXmlElement.BaseType.Value);
    return null;
  }

  public void SetBaseType(VariantType? value)
  {
    if (OpenXmlElement != null)
    {
      if (value != null)
        OpenXmlElement.BaseType = ArrayBaseTypeConversion.GetValue1((VariantType)value);
      else
        OpenXmlElement.BaseType = null;
    }
  }

  public int? GetLowerBounds()
  {
    return (OpenXmlElement?.LowerBounds?.Value != null) ? OpenXmlElement.LowerBounds.Value : null;
  }

  public void SetLowerBounds(int? value)
  {
    if (OpenXmlElement != null)
    {
      if (value != null)
        OpenXmlElement.LowerBounds = value;
      else
        OpenXmlElement.LowerBounds = null;
    };
  }

  public int? GetUpperBounds()
  {
    return (OpenXmlElement?.UpperBounds?.Value != null) ? OpenXmlElement.UpperBounds.Value : null;
  }

  public void SetUpperBounds(int? value)
  {
    if (OpenXmlElement != null)
    {
      if (value != null)
        OpenXmlElement.UpperBounds = value;
      else
        OpenXmlElement.UpperBounds = null;
    };
  }

  public ArrayVariant? GetValue()
  {
    if (OpenXmlElement != null)
    {
      var itemType = (BaseType != null) ? ArrayVariant.ItemTypes[(VariantType)BaseType] : null;
      var _value = new ArrayVariant(BaseType ?? VariantType.Variant, LowerBounds ?? 0, UpperBounds ?? OpenXmlElement.Elements().Count()+1);
      int i = _value.LowerBounds;
      foreach (var openXmlElement in OpenXmlElement.Elements())
      {
        var itemVariant = VariantImpl.VTToVariant(openXmlElement);
        var itemValue = (itemType != null) ? Convert.ChangeType(itemVariant, itemType) : itemVariant.Value;
        _value[i] = itemValue;
      }
      return _value;
    }
    return null;
  }

  public void SetValue(ArrayVariant? value)
  {
    if (OpenXmlElement != null)
    {
      OpenXmlElement.RemoveAllChildren();
      if (value != null)
        foreach (var itemValue in value)
        {
          var itemVariant = VariantImpl.ObjectToVT(itemValue);
          OpenXmlElement.AppendChild(itemVariant);
        }
    }
  }

  //public override string ToString()
  //{
  //  var ss = new List<string?>();
  //  var value = Value;
  //  if (value is IEnumerable enumerable)
  //    foreach (var item in enumerable)
  //      ss.Add(item.ToString());
  //  return "(" + String.Join(", ", ss) + ")";
  //}
}
