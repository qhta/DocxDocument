
namespace DocumentModel.OpenXml;
using VTVariant = DocumentFormat.OpenXml.VariantTypes.Variant;

/// <summary>
/// Provides conversion methods for Variant types in Open XML.
/// </summary>
public static class VariantConverter
{
  /// <summary>
  /// Retrieves the value from an OpenXml element representing a variant type.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to convert.</param>
  /// <returns>The value contained in the element, converted to the appropriate .NET type.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the element type is not supported.</exception>
  public static object? GetValue(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXVT.VTBool vBool)
      return XmlConvert.ToBoolean(vBool.Text);

    if (openXmlElement is DXVT.VTLPSTR vLPString)
      return vLPString.Text;

    if (openXmlElement is DXVT.VTLPWSTR vLPWString)
      return vLPWString.Text;

    if (openXmlElement is DXVT.VTBString vBString)
      return vBString.Text;

    if (openXmlElement is DXVT.VTByte vSByte)
      return XmlConvert.ToSByte(vSByte.Text);

    if (openXmlElement is DXVT.VTUnsignedByte vByte)
      return XmlConvert.ToByte(vByte.Text);

    if (openXmlElement is DXVT.VTShort vShort)
      return XmlConvert.ToInt16(vShort.Text);

    if (openXmlElement is DXVT.VTUnsignedShort vUShort)
      return XmlConvert.ToUInt16(vUShort.Text);

    if (openXmlElement is DXVT.VTInt32 vInt32)
      return XmlConvert.ToInt32(vInt32.Text);

    if (openXmlElement is DXVT.VTUnsignedInt32 vUInt32)
      return XmlConvert.ToUInt32(vUInt32.Text);

    if (openXmlElement is DXVT.VTInt64 vInt64)
      return XmlConvert.ToInt64(vInt64.Text);

    if (openXmlElement is DXVT.VTUnsignedInt64 vUInt64)
      return XmlConvert.ToUInt64(vUInt64.Text);

    if (openXmlElement is DXVT.VTInteger vInteger)
      return XmlConvert.ToDecimal(vInteger.Text);

    if (openXmlElement is DXVT.VTUnsignedInteger vUInteger)
      return XmlConvert.ToDecimal(vUInteger.Text);

    if (openXmlElement is DXVT.VTFloat vFloat)
      return XmlConvert.ToSingle(vFloat.Text);

    if (openXmlElement is DXVT.VTDouble vDouble)
      return XmlConvert.ToSingle(vDouble.Text);

    if (openXmlElement is DXVT.VTDecimal vDecimal)
      return XmlConvert.ToDecimal(vDecimal.Text);

    if (openXmlElement is DXVT.VTCurrency vCurrency)
      return XmlConvert.ToDecimal(vCurrency.Text);

    if (openXmlElement is DXVT.VTDate vDate)
      return DateOnly.FromDateTime(XmlConvert.ToDateTime(vDate.Text, XmlDateTimeSerializationMode.Unspecified));

    if (openXmlElement is DXVT.VTFileTime vFileTime)
      return XmlConvert.ToDateTime(vFileTime.Text, XmlDateTimeSerializationMode.Unspecified);

    if (openXmlElement is DXVT.VTNull vtNull)
      return DBNull.Value;

    if (openXmlElement is DXVT.VTEmpty vtEmpty)
      return null;

    if (openXmlElement is DXVT.VTClassId classId)
      return XmlConvert.ToGuid(classId.Text);

    if (openXmlElement is DXVT.VTError vError)
      return new HexInt(vError.Text);

    if (openXmlElement is DXVT.VTBlob vBlob)
      return new Variant(VariantType.Blob, Convert.FromBase64String(vBlob.Text));

    if (openXmlElement is DXVT.VTOBlob vOBlob)
      return new Variant(VariantType.OBlob, Convert.FromBase64String(vOBlob.Text));

    if (openXmlElement is DXVT.VTStorage vStorage)
      return new Variant(VariantType.Storage, Convert.FromBase64String(vStorage.Text));

    if (openXmlElement is DXVT.VTOStorage vOStorage)
      return new Variant(VariantType.OStorage, Convert.FromBase64String(vOStorage.Text));

    if (openXmlElement is DXVT.VTStreamData vStreamData)
      return new Variant(VariantType.Stream, Convert.FromBase64String(vStreamData.Text));

    if (openXmlElement is DXVT.VTOStreamData vOStreamData)
      return new Variant(VariantType.OStream, Convert.FromBase64String(vOStreamData.Text));

    if (openXmlElement is DXVT.VTVStreamData vVStreamData)
      return new Variant(VariantType.VStream, new VStreamData
      (
        new Guid(vVStreamData.Version?.Value ?? ""),
        Convert.FromBase64String(vVStreamData.Text))
      );

    if (openXmlElement is DXVT.VTClipboardData vtClipboardData)
      return new Variant(VariantType.ClipboardData, new VClipboardData
      (
        vtClipboardData.Format?.Value ?? 0,
        Convert.FromBase64String(vtClipboardData.Text))
      );
    if (openXmlElement is DXVT.VTVector vtVector)
      return vtVector.CreateModelElement()
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is DXVT.VTArray vtArray)
      return vtArray.GetValue()
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTVariant vtVariant)
      if (vtVariant.FirstChild != null)
        return GetVariant(vtVariant.FirstChild);
    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");
  }

  /// <summary>
  /// Converts an OpenXml element to a Variant object.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to convert.</param>
  /// <returns>A Variant object representing the element values and type.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the element type is not supported.</exception>
  public static Variant GetVariant(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXVT.VTBool vBool)
      return new Variant(VariantType.Boolean, Boolean.Parse(vBool.Text));

    if (openXmlElement is DXVT.VTLPSTR vLPString)
      return new Variant(VariantType.Lpstr, vLPString.Text);

    if (openXmlElement is DXVT.VTLPWSTR vLPWString)
      return new Variant(VariantType.Lpwstr, vLPWString.Text);

    if (openXmlElement is DXVT.VTBString vBString)
      return new Variant(VariantType.Bstr, vBString.Text);

    if (openXmlElement is DXVT.VTByte vSByte)
      return new Variant(VariantType.SByte, SByte.Parse(vSByte.Text));

    if (openXmlElement is DXVT.VTUnsignedByte vByte)
      return new Variant(VariantType.Byte, Byte.Parse(vByte.Text));

    if (openXmlElement is DXVT.VTShort vShort)
      return new Variant(VariantType.Int16, short.Parse(vShort.Text));

    if (openXmlElement is DXVT.VTUnsignedShort vUShort)
      return new Variant(VariantType.UInt16, ushort.Parse(vUShort.Text));

    if (openXmlElement is DXVT.VTInt32 vInt32)
      return new Variant(VariantType.Int32, int.Parse(vInt32.Text));

    if (openXmlElement is DXVT.VTUnsignedInt32 vUInt32)
      return new Variant(VariantType.UInt32, uint.Parse(vUInt32.Text));

    if (openXmlElement is DXVT.VTInt64 vInt64)
      return new Variant(VariantType.Int64, long.Parse(vInt64.Text));

    if (openXmlElement is DXVT.VTUnsignedInt64 vUInt64)
      return new Variant(VariantType.UInt64, ulong.Parse(vUInt64.Text));

    if (openXmlElement is DXVT.VTInteger vInteger)
      return new Variant(VariantType.Integer, decimal.Parse(vInteger.Text));

    if (openXmlElement is DXVT.VTUnsignedInteger vUInteger)
      return new Variant(VariantType.Integer, decimal.Parse(vUInteger.Text));

    if (openXmlElement is DXVT.VTFloat vFloat)
      return new Variant(VariantType.Single, float.Parse(vFloat.Text));

    if (openXmlElement is DXVT.VTDouble vDouble)
      return new Variant(VariantType.Double, double.Parse(vDouble.Text));

    if (openXmlElement is DXVT.VTDecimal vDecimal)
      return new Variant(VariantType.Decimal, decimal.Parse(vDecimal.Text));

    if (openXmlElement is DXVT.VTCurrency vCurrency)
      return new Variant(VariantType.Currency, decimal.Parse(vCurrency.Text));

    if (openXmlElement is DXVT.VTDate vDate)
      return new Variant(VariantType.Date, DateOnly.FromDateTime(DateTime.Parse(vDate.Text)));

    if (openXmlElement is DXVT.VTFileTime vFileTime)
      return new Variant(VariantType.DateTime, DateTime.Parse(vFileTime.Text));

    if (openXmlElement is DXVT.VTNull vtNull)
      return new Variant(VariantType.Null, DBNull.Value);

    if (openXmlElement is DXVT.VTEmpty vtEmpty)
      return new Variant(VariantType.Empty, null);

    if (openXmlElement is DXVT.VTClassId vtClassId)
      return new Variant(VariantType.Guid, XmlConvert.ToGuid(vtClassId.Text));

    if (openXmlElement is DXVT.VTError vError)
      return new Variant(VariantType.HexInt, new HexInt(vError.Text));

    if (openXmlElement is DXVT.VTBlob vBlob)
      return new Variant(VariantType.Blob, Convert.FromBase64String(vBlob.Text));

    if (openXmlElement is DXVT.VTOBlob vOBlob)
      return new Variant(VariantType.OBlob, Convert.FromBase64String(vOBlob.Text));

    if (openXmlElement is DXVT.VTStorage vStorage)
      return new Variant(VariantType.Storage, Convert.FromBase64String(vStorage.Text));

    if (openXmlElement is DXVT.VTOStorage vOStorage)
      return new Variant(VariantType.OStorage, Convert.FromBase64String(vOStorage.Text));

    if (openXmlElement is DXVT.VTStreamData vStreamData)
      return new Variant(VariantType.Stream, Convert.FromBase64String(vStreamData.Text));

    if (openXmlElement is DXVT.VTOStreamData vOStreamData)
      return new Variant(VariantType.OStream, Convert.FromBase64String(vOStreamData.Text));

    if (openXmlElement is DXVT.VTVStreamData vVStreamData)
      return new Variant(VariantType.VStream, new VStreamData(
        vVStreamData.Version?.Value != null ? Guid.Parse(vVStreamData.Version.Value) : Guid.Empty,
        Convert.FromBase64String(vVStreamData.Text))
      );

    if (openXmlElement is DXVT.VTClipboardData vtClipboardData)
      return new Variant(VariantType.ClipboardData, new VClipboardData(
        vtClipboardData.Format?.Value ?? 0,
        Convert.FromBase64String(vtClipboardData.Text))
      );
    if (openXmlElement is DXVT.VTVector vtVector)
      return vtVector.CreateModelElement()
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is DXVT.VTArray vtArray)
      return vtArray.GetValue()
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTVariant vtVariant)
      if (vtVariant.FirstChild != null)
        return new Variant(VariantType.Variant, GetVariant(vtVariant.FirstChild));
    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");
  }

  /// <summary>
  /// Creates an OpenXml element from an object value.
  /// </summary>
  /// <param name="value">The value to convert. Can be a Variant or a raw object.</param>
  /// <returns>An OpenXmlElement representing the value.</returns>
  public static DX.OpenXmlElement CreateOpenXmlElement(object? value)
  {
    if (value is Variant variant)
      return CreateOpenXmlElement(variant);
    variant = new Variant(value);
    return CreateOpenXmlElement(variant);
  }

  /// <summary>
  /// Creates an OpenXml element from a Variant object.
  /// </summary>
  /// <param name="variant">The Variant object to convert.</param>
  /// <returns>An OpenXmlElement corresponding to the variant type and value.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the variant type is not supported.</exception>
  public static DX.OpenXmlElement CreateOpenXmlElement(Variant variant)
  {
    switch (variant.VariantType)
    {
      case VariantType.Boolean:
        return new DXVT.VTBool { Text = variant.ToBoolean() ? "true" : "false" };
      case VariantType.Lpstr:
        return new DXVT.VTLPSTR { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.Lpwstr:
        return new DXVT.VTLPWSTR { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.Bstr:
        return new DXVT.VTBString { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.SByte:
        return new DXVT.VTByte { Text = XmlConvert.ToString(variant.ToSByte()) };
      case VariantType.Byte:
        return new DXVT.VTUnsignedByte { Text = XmlConvert.ToString(variant.ToByte()) };
      case VariantType.Int16:
        return new DXVT.VTShort { Text = XmlConvert.ToString(variant.ToInt16()) };
      case VariantType.UInt16:
        return new DXVT.VTUnsignedShort { Text = XmlConvert.ToString(variant.ToUInt16()) };
      case VariantType.Int32:
        return new DXVT.VTInt32 { Text = XmlConvert.ToString(variant.ToInt32()) };
      case VariantType.UInt32:
        return new DXVT.VTUnsignedInt32 { Text = XmlConvert.ToString(variant.ToUInt32()) };
      case VariantType.Int64:
        return new DXVT.VTInt64 { Text = XmlConvert.ToString(variant.ToInt64()) };
      case VariantType.UInt64:
        return new DXVT.VTUnsignedInt64 { Text = XmlConvert.ToString(variant.ToUInt64()) };
      case VariantType.Integer:
        return new DXVT.VTInt64 { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.UnsignedInteger:
        return new DXVT.VTUnsignedInt64 { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Single:
        return new DXVT.VTFloat { Text = XmlConvert.ToString(variant.ToSingle()) };
      case VariantType.Double:
        return new DXVT.VTDouble { Text = XmlConvert.ToString(variant.ToDouble()) };
      case VariantType.Decimal:
        return new DXVT.VTDecimal { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Currency:
        return new DXVT.VTCurrency { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Date:
        return new DXVT.VTDate { Text = XmlConvert.ToString(variant.ToDateTime(), "yyyy-MM-dd") };
      case VariantType.DateTime:
        return new DXVT.VTFileTime { Text = XmlConvert.ToString(variant.ToDateTime(), XmlDateTimeSerializationMode.Unspecified) };
      case VariantType.Null:
        return new DXVT.VTNull();
      case VariantType.Empty:
        return new DXVT.VTEmpty();
      case VariantType.Guid:
        return new DXVT.VTClassId { Text = XmlConvert.ToString(variant.ToGuid()) };
      case VariantType.HexInt:
        return new DXVT.VTError { Text = variant.Value is HexInt HexLong ? HexLong.ToString() : string.Empty };
      case VariantType.Blob:
        return new DXVT.VTBlob { Text = variant.Value is byte[] blob ? Convert.ToBase64String(blob) : String.Empty };
      case VariantType.OBlob:
        return new DXVT.VTOBlob { Text = variant.Value is byte[] oBlob ? Convert.ToBase64String(oBlob) : String.Empty };
      case VariantType.Storage:
        return new DXVT.VTStorage { Text = variant.Value is byte[] storage ? Convert.ToBase64String(storage) : String.Empty };
      case VariantType.OStorage:
        return new DXVT.VTOStorage { Text = variant.Value is byte[] oStorage ? Convert.ToBase64String(oStorage) : String.Empty };
      case VariantType.Stream:
        return new DXVT.VTStreamData { Text = variant.Value is byte[] streamData ? Convert.ToBase64String(streamData) : String.Empty };
      case VariantType.OStream:
        return new DXVT.VTOStreamData { Text = variant.Value is byte[] oStreamData ? Convert.ToBase64String(oStreamData) : String.Empty };
      case VariantType.VStream:
        var vStreamDataVariant = new DXVT.VTVStreamData();
        if (variant.Value is VStreamData vStreamData)
        {
          vStreamDataVariant.Text = Convert.ToBase64String(vStreamData.Data);
          vStreamDataVariant.Version = vStreamData.Version != null ? XmlConvert.ToString((Guid)vStreamData.Version) : null;
        }
        ;
        return vStreamDataVariant;
      case VariantType.ClipboardData:
        var vClipboardDataVariant = new DXVT.VTClipboardData();
        if (variant.Value is VClipboardData vClipboardData)
        {
          vClipboardDataVariant.Text = Convert.ToBase64String(vClipboardData.Data);
          vClipboardDataVariant.Format = vClipboardData.Format;
          vClipboardDataVariant.Size = vClipboardData.Size;
        }
        ;
        return vClipboardDataVariant;
      case VariantType.Variant:
        var variantVariant = new VTVariant();
        if (variant.Value is Variant variantValue) variantVariant.AppendChild(CreateOpenXmlElement(variantValue));
        ;
        return variantVariant;
      case VariantType.Vector:
        if (variant is VectorVariant varVector)
        {
          var vtVector = varVector.CreateOpenXmlElement();
          return vtVector;
        }
        throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT vector");
      case VariantType.Array:
        if (variant is ArrayVariant varArray)
        {
          var vtArray = varArray.CreateOpenXmlElement();
          return vtArray;
        }
        throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT array");
    }
    throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT array");
  }
}