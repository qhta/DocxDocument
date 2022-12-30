namespace DocumentModel;

using VectorBaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues;

public class VTVectorImpl : ModelElementImpl
{
  public VTVectorImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTVector();
  }

  public VTVectorImpl(DocumentFormat.OpenXml.VariantTypes.VTVector element)
  {
    OpenXmlElement = element;
  }

  public DocumentFormat.OpenXml.VariantTypes.VTVector? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTVector?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VariantType? BaseType
  {
    get => GetBaseType();
    set => SetBaseType(value);
  }

  public VectorVariant? Value
  {
    get => GetValue();
    set => SetValue(value);
  }

  private static BiDiDictionary<VectorBaseType, VariantType> VectorBaseTypeConversion = new()
  {
    { VectorBaseType.OneByteSignedInteger, VariantType.Byte },
    { VectorBaseType.TwoBytesSignedInteger, VariantType.Int16 },
    { VectorBaseType.FourBytesSignedInteger, VariantType.Int32 },
    { VectorBaseType.EightBytesSignedInteger, VariantType.Int64 },
    { VectorBaseType.OneByteUnsignedInteger, VariantType.Byte },
    { VectorBaseType.TwoBytesUnsignedInteger, VariantType.UInt16 },
    { VectorBaseType.FourBytesUnsignedInteger, VariantType.UInt32 },
    { VectorBaseType.EightBytesUnsignedInteger, VariantType.UInt64 },
    { VectorBaseType.FourBytesReal, VariantType.Single },
    { VectorBaseType.EightBytesReal, VariantType.Double },
    { VectorBaseType.Bstr, VariantType.Bstr },
    { VectorBaseType.Lpstr, VariantType.Lpstr },
    { VectorBaseType.Lpwstr, VariantType.Lpwstr },
    { VectorBaseType.Date, VariantType.Date },
    { VectorBaseType.Filetime, VariantType.DateTime },
    { VectorBaseType.Bool, VariantType.Bool },
    { VectorBaseType.Currency, VariantType.Currency },
    { VectorBaseType.Error, VariantType.Error },
    { VectorBaseType.ClassId, VariantType.ClassId },
    { VectorBaseType.ClipboardData, VariantType.ClipboardData },
    { VectorBaseType.Variant, VariantType.Variant },
  };

  public VariantType? GetBaseType()
  {
    if (OpenXmlElement?.BaseType?.Value != null)
      return VectorBaseTypeConversion.GetValue2(OpenXmlElement.BaseType.Value);
    return null;
  }

  public void SetBaseType(VariantType? value)
  {
    if (OpenXmlElement != null)
    {
      if (value != null)
        OpenXmlElement.BaseType = VectorBaseTypeConversion.GetValue1((VariantType)value);
      else
        OpenXmlElement.BaseType = null;
    }
  }

  public VectorVariant? GetValue()
  {
    if (OpenXmlElement != null)
    {
      var itemType = (BaseType != null) ? VectorVariant.ItemTypes[(VariantType)BaseType] : null;
      var _value = new VectorVariant();
      foreach (var openXmlElement in OpenXmlElement.Elements())
      {
        var itemVariant = VariantImpl.VTToVariant(openXmlElement);
        var itemValue = (itemType != null) ? Convert.ChangeType(itemVariant, itemType) : itemVariant.Value;
        _value.Add(itemValue);
      }
      return _value;
    }
    return null;
  }

  public void SetValue(VectorVariant? value)
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
