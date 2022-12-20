using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.VariantTypes;

namespace DocxDocument.Model;

public static class DocxWrite
{

  public static PropertyType? CreateStringProperty<PropertyType>(string? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    if (value == null)
      return null;
    var result = new PropertyType { Text = value };
    return result;
  }

  public static PropertyType? CreateBooleanProperty<PropertyType>(bool? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    var result = new PropertyType { Text = value.ToString().ToLower() };
    return result;
  }

  public static PropertyType? CreateIntProperty<PropertyType>(int? value) where PropertyType : OpenXmlLeafTextElement, new()
  {
    var result = new PropertyType { Text = value.ToString() };
    return result;
  }

  public static EP.DigitalSignature? CreateDigitalSignatureProperty(byte[]? value)
  {
    if (value == null)
      return null;
    var blob = CreateBlob(value);
     if (blob!=null)
       return new EP.DigitalSignature(blob);
    return null;
  }

  public static VTBlob? CreateBlob(byte[]? value)
  {
    if (value == null)
      return null;
    var newData = new byte[value.Length + 4];
    var countBytes = BitConverter.GetBytes(value.Length);
    countBytes.CopyTo(newData, 0);
    value.CopyTo(newData, 4);
    return new VTBlob(Convert.ToBase64String(newData));
  }

  public static VTOBlob? CreateOBlob(byte[]? value)
  {
    if (value == null)
      return null;
    var newData = new byte[value.Length + 4];
    var countBytes = BitConverter.GetBytes(value.Length);
    countBytes.CopyTo(newData, 0);
    value.CopyTo(newData, 4);
    return new VTOBlob(Convert.ToBase64String(newData));
  }

  public static VTStorage? CreateStorage(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTStorage();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  public static VTOStorage? CreateOStorage(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTOStorage();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  public static VTStreamData? CreateStreamData(byte[]? value)
  {
    if (value == null)
      return null;
    var result = new VTStreamData();
    result.Text = Convert.ToBase64String(value);
    return result;
  }

  public static VTOStreamData? CreateOStreamData(GuidDataPair? value)
  {
    if (value == null)
      return null;
    var result = new VTOStreamData();
    result.Text = Convert.ToBase64String(value.Data);
    return result;
  }

  public static VTVStreamData? CreateVStreamData(GuidDataPair? value)
  {
    if (value == null)
      return null;
    var result = new VTVStreamData();
    result.Text = Convert.ToBase64String(value.Data);
    if (value.Guid != null)
      result.Version = ((Guid)value.Guid).ToString("B").ToUpperInvariant();
    return result;
  }

  public static (string lower, string upper) CreateVTArrayBounds(System.Array array)
  {
    var n = array.Rank;
    var lBounds = new List<string>();
    var uBounds = new List<string>();
    for (int i = 0; i < n; i++)
    {
      var lBound = array.GetLowerBound(i);
      var uBound = array.GetUpperBound(i);
      lBounds.Add(lBound.ToString());
      uBounds.Add(uBound.ToString());
    }

    return (string.Join(",", lBounds), string.Join(",", uBounds));
  }

  public static VTArray? CreateVTArray(System.Array value)
  {
    if (value == null || value.Length==0)
      return null;
    var firstItem = value.GetValue(0);
    var type = firstItem.GetType();
    if (!DM.VariantTypeMapping.TypeToArrayBaseType.TryGetValue(type, out var baseType))
      throw new InvalidDataException($"Unknown VTArray base type");

    if (value.Rank>1)
      throw new InvalidDataException($"Multidimension VTArray cannot be created in this implementation");
    //var bounds = CreateVTArrayBounds(value);
    var result = new VTArray
    {
      BaseType = baseType,
      LowerBounds = new Int32Value(value.GetLowerBound(0)),
      UpperBounds = new Int32Value(value.GetUpperBound(0))
    };
    var format = typeof(ArrayBaseValues).GetField(baseType.ToString()).GetCustomAttributes<EnumStringAttribute>()
      .FirstOrDefault()?.Value;
    for (int i = 0; i < value.Length; i++)
    {
      var item = value.GetValue(i);
      var variantElement = CreateVariant(item, format);
      if (variantElement != null)
        result.AddChild(variantElement);
    }
    return result;
  }

  public static VTVector? CreateVTVector(IEnumerable value)
  {
    if (value == null)
      return null;
    var typedValue = value.OfType<object>();
    var firstItem = typedValue.FirstOrDefault();
    if (firstItem == null)
      return null;
    var type = firstItem.GetType();
    if (!DM.VariantTypeMapping.TypeToVectorBaseType.TryGetValue(type, out var baseType))
      throw new InvalidDataException($"Unknown VTArray base type");
    var result = new VTVector
    {
      BaseType = baseType,
      Size = (uint)typedValue.Count(),
    };
    var format = typeof(VectorBaseValues).GetField(baseType.ToString()).GetCustomAttributes<EnumStringAttribute>()
      .FirstOrDefault()?.Value;
    foreach (var item in typedValue)
    {
      var variantElement = CreateVariant(item, format);
      if (variantElement != null)
        result.AddChild(variantElement);
    }
    return result;
  }
  public static OpenXmlElement? CreateVariant(DM.Variant value)
  {
    if (value.Value==null)
      return null;  
    if (value.Type == DM.VariantType.Variant)
      return new VT.Variant { InnerVariant = (VT.Variant?)CreateVariant((DM.Variant)value.Value) };
    if (value.Type == DM.VariantType.Bool)
      return new VTBool(((bool)value.Value).ToString().ToLowerInvariant());
    if (value.Type == DM.VariantType.String)
      return new VTLPSTR(value.Value?.ToString() ?? "");
    if (value.Type == DM.VariantType.Int32)
      return new VTInt32(((Int32)value.Value).ToString());
    if (value.Type == DM.VariantType.Int64)
      return new VTInt64(((Int64)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt32)
      return new VTUnsignedInt32(((UInt32)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt64)
      return new VTUnsignedInt64(((UInt64)value.Value).ToString());
    if (value.Type == DM.VariantType.Int8)
      return new VTByte(((SByte)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt8)
      return new VTUnsignedByte(((byte)value.Value).ToString());
    if (value.Type == DM.VariantType.Int16)
      return new VTShort(((Int16)value.Value).ToString());
    if (value.Type == DM.VariantType.UInt16)
      return new VTShort(((UInt16)value.Value).ToString());
    if (value.Type == DM.VariantType.DateTime)
      return new VTFileTime(((DateTime)value.Value).ToUniversalTime().ToString("s")+"Z");
    if (value.Type == DM.VariantType.Float)
      return new VTFloat(((float)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Double)
      return new VTDouble(((double)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Currency)
      return new VTDecimal(((decimal)value.Value).ToString("F",CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Decimal)
      return new VTDecimal(((decimal)value.Value).ToString(CultureInfo.InvariantCulture));
    if (value.Type == DM.VariantType.Null)
      return new VT.VTNull();
    if (value.Type == DM.VariantType.Empty)
      return new VT.VTEmpty();
    if (value.Type == DM.VariantType.Error)
      return new VTError(((Int32)value.Value).ToString("X8"));
    if (value.Type == DM.VariantType.ClassId)
      return new VT.VTClassId(((Guid)value.Value).ToString("B").ToUpperInvariant());


    if (value.Type == DM.VariantType.Blob)
      return CreateBlob((byte[])value.Value);
    if (value.Type == DM.VariantType.OBlob)
      return CreateOBlob((byte[])value.Value);
    if (value.Type == DM.VariantType.Storage)
      return CreateStorage(value.Value as byte[]);
    if (value.Type == DM.VariantType.OStorage)
      return CreateOStorage(value.Value as byte[]);
    if (value.Type == DM.VariantType.StreamData)
      return CreateStreamData(value.Value as byte[]);
    if (value.Type == DM.VariantType.OStreamData)
      return CreateOStreamData(value.Value as GuidDataPair);
    if (value.Type == DM.VariantType.VStreamData)
      return CreateVStreamData(value.Value as GuidDataPair);

    
    if (value.Type == DM.VariantType.Array)
      return CreateVTArray((System.Array)value.Value);
    if (value.Type == DM.VariantType.Vector)
      return CreateVTVector((IEnumerable)value.Value);

    throw new InvalidDataException($"Default of type {value.Type} cannot be converted to VTVariantType");
  }

  public static OpenXmlElement? CreateVariant(object value, string? format)
  {
    if (format=="error")
      return new VTError(((Int32)value).ToString("X8"));
    if (format == "cy")
      return new VTCurrency(((decimal)value).ToString("F", CultureInfo.InvariantCulture));

    if (value is DM.Variant variant)
      return new VT.Variant { InnerVariant = (VT.Variant?)CreateVariant(variant) };
    if (value is bool boolValue)
      return new VTBool(boolValue.ToString().ToLowerInvariant());
    if (value is string str)
      return new VTLPSTR(str);
    if (value is Int32 int32value)
      return new VTInt32(int32value.ToString());
    if (value is Int64 int64value)
      return new VTInt64(int64value.ToString());
    if (value is UInt32 uint32value)
      return new VTUnsignedInt32(uint32value.ToString());
    if (value is UInt64 uint64value)
      return new VTUnsignedInt64(uint64value.ToString());
    if (value is SByte int8value)
      return new VTByte(int8value.ToString());
    if (value is byte uint8value)
      return new VTUnsignedByte(uint8value.ToString());
    if (value is Int16 int16value)
      return new VTShort(int16value.ToString());
    if (value is UInt16 uint16value)
      return new VTShort(uint16value.ToString());
    if (value is DateTime datetimeValue)
      return new VTFileTime(datetimeValue.ToUniversalTime().ToString("s") + "Z");
    if (value is float floatValue)
      return new VTFloat(floatValue.ToString(CultureInfo.InvariantCulture));
    if (value is double doubleValue)
      return new VTDouble(doubleValue.ToString(CultureInfo.InvariantCulture));
    if (value is decimal decimalValue)
      return new VTDecimal(decimalValue.ToString(CultureInfo.InvariantCulture));
    if (value == null)
      return new VT.VTNull();
    if (value is Guid guidValue)
      return new VT.VTClassId(guidValue.ToString("B").ToUpperInvariant());

    throw new InvalidDataException($"Default of type {value.GetType()} cannot be converted to VTVariantType");
  }

}