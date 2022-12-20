using DocumentFormat.OpenXml.VariantTypes;

namespace DocxDocument.Model;



public struct Variant
{
  public VariantType Type { get; set; }

  public Object? Value { get; set; }

  public VariantType ItemType => Type & VariantType.Variant;

  public bool IsArray => (Type & VariantType.Array) != 0;

  public bool IsVector => (Type & VariantType.Vector) != 0;

  public Variant()
  {
    Type = VariantType.Empty;
    Value = null;
  }

  public Variant(VariantType type, object? value)
  {
    Type = type;
    Value = value;
  }

  public static VariantType GetVariantType(object? obj)
  {
    if (obj == null)
      return VariantType.Null;
    if (obj is Array array)
    {
      var itemType = (array).GetValue(0).GetType();
      return GetVariantType(itemType) | VariantType.Array;
    }

    if (obj is ICollection)
    {
      var itemType = obj.GetType().GetGenericArguments()[0];
      return GetVariantType(itemType) | VariantType.Vector;
    }

    if (VariantTypeMapping.TypeToVariantType.TryGetValue(obj.GetType(), out var result))
      return result;
    throw new ArgumentException($"Can't convert object {obj} to variant");
  }

  public static VariantType GetVariantType(Type type)
  {
    return VariantTypeMapping.TypeToVariantType[type];
  }

  public override string ToString()
  {
    return Value?.ToString() ?? Type.ToString();
  }
}

public static class VariantTypeMapping
{
  public static readonly Dictionary<VariantType, Type> VariantTypeToType = new Dictionary<VariantType, Type>
  {
    {  VariantType.Empty, typeof(void) },
    {  VariantType.Null, typeof(void) },
    {  VariantType.Bool, typeof(Boolean) },
    {  VariantType.Int8, typeof(SByte) },
    {  VariantType.Int16, typeof(Int16) },
    {  VariantType.Int32, typeof(Int32) },
    {  VariantType.Int64, typeof(Int64) },
    {  VariantType.UInt8, typeof(Byte) },
    {  VariantType.UInt16, typeof(UInt16) },
    {  VariantType.UInt32, typeof(UInt32) },
    {  VariantType.UInt64, typeof(UInt64) },
    {  VariantType.Float, typeof(Single) },
    {  VariantType.Double, typeof(Double) },
    {  VariantType.Decimal, typeof(Decimal) },
    {  VariantType.Currency, typeof(Decimal) },
    {  VariantType.DateTime, typeof(DateTime) },
    {  VariantType.String, typeof(String) },
    {  VariantType.Blob, typeof(byte[]) },
    {  VariantType.OBlob, typeof(byte[]) },
    {  VariantType.Storage, typeof(byte[]) },
    {  VariantType.OStorage, typeof(byte[]) },
    {  VariantType.StreamData, typeof(byte[]) },
    {  VariantType.OStreamData, typeof(byte[]) },
    {  VariantType.VStreamData, typeof(GuidDataPair) },
    {  VariantType.ClassId, typeof(Guid) },
    {  VariantType.Error, typeof(Int32) },
    {  VariantType.ClipboardData, typeof(ClipboardData) },
    {  VariantType.Variant, typeof(Variant) },
    {  VariantType.Array, typeof(Array) },
    {  VariantType.Vector, typeof(ICollection) },
  };

  public static readonly Dictionary<Type, VariantType> TypeToVariantType = new Dictionary<Type, VariantType>
  {
    { typeof(void), VariantType.Empty },

    { typeof(Boolean), VariantType.Bool },
    { typeof(SByte), VariantType.Int8 },
    { typeof(Int16), VariantType.Int16 },
    { typeof(Int32), VariantType.Int32 },
    { typeof(Int64), VariantType.Int64 },
    { typeof(Byte), VariantType.UInt8 },
    { typeof(UInt16), VariantType.UInt16 },
    { typeof(UInt32), VariantType.UInt32 },
    { typeof(UInt64), VariantType.UInt64 },
    { typeof(Single), VariantType.Float },
    { typeof(Double), VariantType.Double },
    { typeof(Decimal), VariantType.Decimal },

    { typeof(DateTime), VariantType.DateTime },

    { typeof(String), VariantType.String },
    { typeof(byte[]), VariantType.Blob },





    { typeof(GuidDataPair), VariantType.VStreamData },
    { typeof(Guid), VariantType.ClassId },
    { typeof(Int32), VariantType.Error },
    { typeof(ClipboardData), VariantType.ClipboardData },
    { typeof(Variant), VariantType.Variant },
    { typeof(Array), VariantType.Array },
    { typeof(ICollection), VariantType.Vector },
  };

  public static readonly Dictionary<ArrayBaseValues, Type> ArrayBaseTypeToType = new Dictionary<ArrayBaseValues, Type>
  {
    {  ArrayBaseValues.Variant, typeof(Variant) },
    {  ArrayBaseValues.OneByteSignedInteger, typeof(SByte) },
    {  ArrayBaseValues.TwoBytesSignedInteger, typeof(Int16) },
    {  ArrayBaseValues.FourBytesSignedInteger, typeof(Int32) },
    {  ArrayBaseValues.Integer, typeof(Int32) },
    {  ArrayBaseValues.OneByteUnsignedInteger, typeof(Byte) },
    {  ArrayBaseValues.TwoBytesUnsignedInteger, typeof(UInt16) },
    {  ArrayBaseValues.FourBytesUnsignedInteger, typeof(UInt32) },
    {  ArrayBaseValues.UnsignedInteger, typeof(UInt32) },
    {  ArrayBaseValues.FourBytesReal, typeof(Single) },
    {  ArrayBaseValues.EightBytesReal, typeof(Double) },
    {  ArrayBaseValues.Decimal, typeof(Decimal) },
    {  ArrayBaseValues.Bstr, typeof(String) },
    {  ArrayBaseValues.Date, typeof(DateTime) },
    {  ArrayBaseValues.Bool, typeof(Boolean) },
    {  ArrayBaseValues.Currency, typeof(Decimal) },
    {  ArrayBaseValues.Error, typeof(void) },
  };

  public static readonly Dictionary<Type, ArrayBaseValues> TypeToArrayBaseType = new Dictionary<Type, ArrayBaseValues>
  {
    { typeof(SByte), ArrayBaseValues.OneByteSignedInteger },
    { typeof(Int16), ArrayBaseValues.TwoBytesSignedInteger },
    { typeof(Int32), ArrayBaseValues.FourBytesSignedInteger },
    { typeof(Int32), ArrayBaseValues.Integer },
    { typeof(Byte), ArrayBaseValues.OneByteUnsignedInteger },
    { typeof(UInt16), ArrayBaseValues.TwoBytesUnsignedInteger },
    { typeof(UInt32), ArrayBaseValues.FourBytesUnsignedInteger },
    { typeof(UInt32), ArrayBaseValues.UnsignedInteger },
    { typeof(Single), ArrayBaseValues.FourBytesReal },
    { typeof(Double), ArrayBaseValues.EightBytesReal },
    { typeof(Decimal), ArrayBaseValues.Decimal },
    { typeof(String), ArrayBaseValues.Bstr },
    { typeof(DateTime), ArrayBaseValues.Date },
    { typeof(Boolean), ArrayBaseValues.Bool },
    { typeof(Decimal), ArrayBaseValues.Currency },
    { typeof(void), ArrayBaseValues.Error },
  };

  public static readonly Dictionary<VectorBaseValues, Type> VectorBaseTypeToType = new Dictionary<VectorBaseValues, Type>
  {
    { VectorBaseValues.Variant, typeof(Variant) },
    { VectorBaseValues.OneByteSignedInteger, typeof(SByte) },
    { VectorBaseValues.TwoBytesSignedInteger, typeof(Int16) },
    { VectorBaseValues.FourBytesSignedInteger, typeof(Int32) },
    { VectorBaseValues.EightBytesSignedInteger, typeof(Int64) },
    { VectorBaseValues.OneByteUnsignedInteger, typeof(Byte) },
    { VectorBaseValues.TwoBytesUnsignedInteger, typeof(UInt16) },
    { VectorBaseValues.FourBytesUnsignedInteger, typeof(UInt32) },
    { VectorBaseValues.EightBytesUnsignedInteger, typeof(UInt64) },
    { VectorBaseValues.FourBytesReal, typeof(Single) },
    { VectorBaseValues.EightBytesReal, typeof(Double) },
    { VectorBaseValues.Lpstr, typeof(String) },
    { VectorBaseValues.Lpwstr, typeof(String) },
    { VectorBaseValues.Bstr, typeof(String) },
    { VectorBaseValues.Date, typeof(DateTime) },
    { VectorBaseValues.Filetime, typeof(DateTime) },
    { VectorBaseValues.Bool, typeof(Boolean) },
    { VectorBaseValues.Currency, typeof(Decimal) },
    { VectorBaseValues.Error, typeof(void) },
    { VectorBaseValues.ClassId, typeof(Guid) },
    { VectorBaseValues.ClipboardData, typeof(ClipboardData) },
  };

  public static readonly Dictionary<Type, VectorBaseValues> TypeToVectorBaseType = new Dictionary<Type, VectorBaseValues>
  {
    { typeof(Variant), VectorBaseValues.Variant },
    { typeof(SByte), VectorBaseValues.OneByteSignedInteger },
    { typeof(Int16), VectorBaseValues.TwoBytesSignedInteger },
    { typeof(Int32), VectorBaseValues.FourBytesSignedInteger },
    { typeof(Int64), VectorBaseValues.EightBytesSignedInteger },
    { typeof(Byte), VectorBaseValues.OneByteUnsignedInteger },
    { typeof(UInt16), VectorBaseValues.TwoBytesUnsignedInteger },
    { typeof(UInt32), VectorBaseValues.FourBytesUnsignedInteger },
    { typeof(UInt64), VectorBaseValues.EightBytesUnsignedInteger },
    { typeof(Single), VectorBaseValues.FourBytesReal },
    { typeof(Double), VectorBaseValues.EightBytesReal },
    { typeof(String), VectorBaseValues.Lpstr },
    { typeof(String), VectorBaseValues.Lpwstr },
    { typeof(String), VectorBaseValues.Bstr },
    { typeof(DateTime), VectorBaseValues.Date },
    { typeof(DateTime), VectorBaseValues.Filetime },
    { typeof(Boolean), VectorBaseValues.Bool },
    { typeof(Decimal), VectorBaseValues.Currency },
    { typeof(void), VectorBaseValues.Error },
    { typeof(Guid), VectorBaseValues.ClassId },
    { typeof(ClipboardData), VectorBaseValues.ClipboardData },
  };


}