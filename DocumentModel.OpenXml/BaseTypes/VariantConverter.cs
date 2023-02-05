namespace DocumentModel.OpenXml;

using VTVariant = DocumentFormat.OpenXml.VariantTypes.Variant;

public static class VariantConverter
{
  public static object? GetValue(OpenXmlElement openXmlElement)
  {
    if (openXmlElement is VTBool vBool)
      return XmlConvert.ToBoolean(vBool.Text);

    if (openXmlElement is VTLPSTR vLPString)
      return vLPString.Text;

    if (openXmlElement is VTLPWSTR vLPWString)
      return vLPWString.Text;

    if (openXmlElement is VTBString vBString)
      return vBString.Text;

    if (openXmlElement is VTByte vSByte)
      return XmlConvert.ToSByte(vSByte.Text);

    if (openXmlElement is VTUnsignedByte vByte)
      return XmlConvert.ToByte(vByte.Text);

    if (openXmlElement is VTShort vShort)
      return XmlConvert.ToInt16(vShort.Text);

    if (openXmlElement is VTUnsignedShort vUShort)
      return XmlConvert.ToUInt16(vUShort.Text);

    if (openXmlElement is VTInt32 vInt32)
      return XmlConvert.ToInt32(vInt32.Text);

    if (openXmlElement is VTUnsignedInt32 vUInt32)
      return XmlConvert.ToUInt32(vUInt32.Text);

    if (openXmlElement is VTInt64 vInt64)
      return XmlConvert.ToInt64(vInt64.Text);

    if (openXmlElement is VTUnsignedInt64 vUInt64)
      return XmlConvert.ToUInt64(vUInt64.Text);

    if (openXmlElement is VTInteger vInteger)
      return XmlConvert.ToDecimal(vInteger.Text);

    if (openXmlElement is VTUnsignedInteger vUInteger)
      return XmlConvert.ToDecimal(vUInteger.Text);

    if (openXmlElement is VTFloat vFloat)
      return XmlConvert.ToSingle(vFloat.Text);

    if (openXmlElement is VTDouble vDouble)
      return XmlConvert.ToSingle(vDouble.Text);

    if (openXmlElement is VTDecimal vDecimal)
      return XmlConvert.ToDecimal(vDecimal.Text);

    if (openXmlElement is VTCurrency vCurrency)
      return XmlConvert.ToDecimal(vCurrency.Text);

    if (openXmlElement is VTDate vDate)
      return DateOnly.FromDateTime(XmlConvert.ToDateTime(vDate.Text, XmlDateTimeSerializationMode.Unspecified));

    if (openXmlElement is VTFileTime vFileTime)
      return XmlConvert.ToDateTime(vFileTime.Text, XmlDateTimeSerializationMode.Unspecified);

    if (openXmlElement is VTNull vtNull)
      return DBNull.Value;

    if (openXmlElement is VTEmpty vtEmpty)
      return null;

    if (openXmlElement is VTClassId vclassId)
      return XmlConvert.ToGuid(vclassId.Text);

    if (openXmlElement is VTError vError)
      return new HexInt(vError.Text);

    if (openXmlElement is VTBlob vBlob)
      return new Variant(VariantType.Blob, Convert.FromBase64String(vBlob.Text));

    if (openXmlElement is VTOBlob vOBlob)
      return new Variant(VariantType.OBlob, Convert.FromBase64String(vOBlob.Text));

    if (openXmlElement is VTStorage vStorage)
      return new Variant(VariantType.Storage, Convert.FromBase64String(vStorage.Text));

    if (openXmlElement is VTOStorage vOStorage)
      return new Variant(VariantType.OStorage, Convert.FromBase64String(vOStorage.Text));

    if (openXmlElement is VTStreamData vStreamData)
      return new Variant(VariantType.Stream, Convert.FromBase64String(vStreamData.Text));

    if (openXmlElement is VTOStreamData vOStreamData)
      return new Variant(VariantType.OStream, Convert.FromBase64String(vOStreamData.Text));

    if (openXmlElement is VTVStreamData vVStreamData)
      return new Variant(VariantType.VStream, new VStreamData
      {
        Data = Convert.FromBase64String(vVStreamData.Text),
        Version = vVStreamData.Version?.Value != null ? Guid.Parse(vVStreamData.Version.Value) : null
      });

    if (openXmlElement is VTClipboardData vtClipboardData)
      return new Variant(VariantType.ClipboardData, new VClipboardData
      {
        Data = Convert.FromBase64String(vtClipboardData.Text),
        Format = vtClipboardData.Format?.Value,
        Size = vtClipboardData.Size?.Value
      });

    if (openXmlElement is VTVector vtVector)
      return VTVectorConverter.CreateModelElement(vtVector)
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTArray vtArray)
      return VTArrayConverter.GetValue(vtArray)
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTVariant vtVariant)
      if (vtVariant.FirstChild != null)
        return GetVariant(vtVariant.FirstChild);
    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");
  }

  public static Variant GetVariant(OpenXmlElement openXmlElement)
  {
    if (openXmlElement is VTBool vBool)
      return new Variant(VariantType.Boolean, XmlConvert.ToBoolean(vBool.Text));

    if (openXmlElement is VTLPSTR vLPString)
      return new Variant(VariantType.Lpstr, vLPString.Text);

    if (openXmlElement is VTLPWSTR vLPWString)
      return new Variant(VariantType.Lpwstr, vLPWString.Text);

    if (openXmlElement is VTBString vBString)
      return new Variant(VariantType.Bstr, vBString.Text);

    if (openXmlElement is VTByte vSByte)
      return new Variant(VariantType.SByte, XmlConvert.ToSByte(vSByte.Text));

    if (openXmlElement is VTUnsignedByte vByte)
      return new Variant(VariantType.Byte, XmlConvert.ToByte(vByte.Text));

    if (openXmlElement is VTShort vShort)
      return new Variant(VariantType.Int16, XmlConvert.ToInt16(vShort.Text));

    if (openXmlElement is VTUnsignedShort vUShort)
      return new Variant(VariantType.UInt16, XmlConvert.ToUInt16(vUShort.Text));

    if (openXmlElement is VTInt32 vInt32)
      return new Variant(VariantType.Int32, XmlConvert.ToInt32(vInt32.Text));

    if (openXmlElement is VTUnsignedInt32 vUInt32)
      return new Variant(VariantType.UInt32, XmlConvert.ToUInt32(vUInt32.Text));

    if (openXmlElement is VTInt64 vInt64)
      return new Variant(VariantType.Int64, XmlConvert.ToInt64(vInt64.Text));

    if (openXmlElement is VTUnsignedInt64 vUInt64)
      return new Variant(VariantType.UInt64, XmlConvert.ToUInt64(vUInt64.Text));

    if (openXmlElement is VTInteger vInteger)
      return new Variant(VariantType.Integer, XmlConvert.ToDecimal(vInteger.Text));

    if (openXmlElement is VTUnsignedInteger vUInteger)
      return new Variant(VariantType.Integer, XmlConvert.ToDecimal(vUInteger.Text));

    if (openXmlElement is VTFloat vFloat)
      return new Variant(VariantType.Single, XmlConvert.ToSingle(vFloat.Text));

    if (openXmlElement is VTDouble vDouble)
      return new Variant(VariantType.Double, XmlConvert.ToSingle(vDouble.Text));

    if (openXmlElement is VTDecimal vDecimal)
      return new Variant(VariantType.Decimal, XmlConvert.ToDecimal(vDecimal.Text));

    if (openXmlElement is VTCurrency vCurrency)
      return new Variant(VariantType.Currency, XmlConvert.ToDecimal(vCurrency.Text));

    if (openXmlElement is VTDate vDate)
      return new Variant(VariantType.Date, DateOnly.FromDateTime(XmlConvert.ToDateTime(vDate.Text, XmlDateTimeSerializationMode.Unspecified)));

    if (openXmlElement is VTFileTime vFileTime)
      return new Variant(VariantType.DateTime, XmlConvert.ToDateTime(vFileTime.Text, XmlDateTimeSerializationMode.Unspecified));

    if (openXmlElement is VTNull vtNull)
      return new Variant(VariantType.Null, DBNull.Value);

    if (openXmlElement is VTEmpty vtEmpty)
      return new Variant(VariantType.Empty, null);

    if (openXmlElement is VTClassId vclassId)
      return new Variant(VariantType.Guid, XmlConvert.ToGuid(vclassId.Text));

    if (openXmlElement is VTError vError)
      return new Variant(VariantType.HexInt, new HexInt(vError.Text));

    if (openXmlElement is VTBlob vBlob)
      return new Variant(VariantType.Blob, Convert.FromBase64String(vBlob.Text));

    if (openXmlElement is VTOBlob vOBlob)
      return new Variant(VariantType.OBlob, Convert.FromBase64String(vOBlob.Text));

    if (openXmlElement is VTStorage vStorage)
      return new Variant(VariantType.Storage, Convert.FromBase64String(vStorage.Text));

    if (openXmlElement is VTOStorage vOStorage)
      return new Variant(VariantType.OStorage, Convert.FromBase64String(vOStorage.Text));

    if (openXmlElement is VTStreamData vStreamData)
      return new Variant(VariantType.Stream, Convert.FromBase64String(vStreamData.Text));

    if (openXmlElement is VTOStreamData vOStreamData)
      return new Variant(VariantType.OStream, Convert.FromBase64String(vOStreamData.Text));

    if (openXmlElement is VTVStreamData vVStreamData)
      return new Variant(VariantType.VStream, new VStreamData
      {
        Data = Convert.FromBase64String(vVStreamData.Text),
        Version = vVStreamData.Version?.Value != null ? Guid.Parse(vVStreamData.Version.Value) : null
      });

    if (openXmlElement is VTClipboardData vtClipboardData)
      return new Variant(VariantType.ClipboardData, new VClipboardData
      {
        Data = Convert.FromBase64String(vtClipboardData.Text),
        Format = vtClipboardData.Format?.Value,
        Size = vtClipboardData.Size?.Value
      });

    if (openXmlElement is VTVector vtVector)
      return VTVectorConverter.CreateModelElement(vtVector)
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTArray vtArray)
      return VTArrayConverter.GetValue(vtArray)
             ?? throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    if (openXmlElement is VTVariant vtVariant)
      if (vtVariant.FirstChild != null)
        return new Variant(VariantType.Variant, GetVariant(vtVariant.FirstChild));
    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");

    throw new InvalidOperationException($"Can't create variant for {openXmlElement.GetType()} type");
  }

  public static OpenXmlElement CreateOpenXmlElement(object? value)
  {
    if (value is Variant variant)
      return CreateOpenXmlElement(variant);
    variant = new Variant(value);
    return CreateOpenXmlElement(variant);
  }

  public static OpenXmlElement CreateOpenXmlElement(Variant variant)
  {
    switch (variant.VariantType)
    {
      case VariantType.Boolean:
        return new VTBool { Text = XmlConvert.ToString(variant.ToBoolean()) };
      case VariantType.Lpstr:
        return new VTLPSTR { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.Lpwstr:
        return new VTLPWSTR { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.Bstr:
        return new VTBString { Text = (string?)variant.Value ?? String.Empty };
      case VariantType.SByte:
        return new VTByte { Text = XmlConvert.ToString(variant.ToSByte()) };
      case VariantType.Byte:
        return new VTUnsignedByte { Text = XmlConvert.ToString(variant.ToByte()) };
      case VariantType.Int16:
        return new VTShort { Text = XmlConvert.ToString(variant.ToInt16()) };
      case VariantType.UInt16:
        return new VTUnsignedShort { Text = XmlConvert.ToString(variant.ToUInt16()) };
      case VariantType.Int32:
        return new VTInt32 { Text = XmlConvert.ToString(variant.ToInt32()) };
      case VariantType.UInt32:
        return new VTUnsignedInt32 { Text = XmlConvert.ToString(variant.ToUInt32()) };
      case VariantType.Int64:
        return new VTInt64 { Text = XmlConvert.ToString(variant.ToInt64()) };
      case VariantType.UInt64:
        return new VTUnsignedInt64 { Text = XmlConvert.ToString(variant.ToUInt64()) };
      case VariantType.Integer:
        return new VTInt64 { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.UnsignedInteger:
        return new VTUnsignedInt64 { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Single:
        return new VTFloat { Text = XmlConvert.ToString(variant.ToSingle()) };
      case VariantType.Double:
        return new VTDouble { Text = XmlConvert.ToString(variant.ToDouble()) };
      case VariantType.Decimal:
        return new VTDecimal { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Currency:
        return new VTCurrency { Text = XmlConvert.ToString(variant.ToDecimal()) };
      case VariantType.Date:
        return new VTDate { Text = XmlConvert.ToString(variant.ToDateTime(), "yyyy-MM-dd") };
      case VariantType.DateTime:
        return new VTFileTime { Text = XmlConvert.ToString(variant.ToDateTime(), XmlDateTimeSerializationMode.Unspecified) };
      case VariantType.Null:
        return new VTNull();
      case VariantType.Empty:
        return new VTEmpty();
      case VariantType.Guid:
        return new VTClassId { Text = XmlConvert.ToString(variant.ToGuid()) };
      case VariantType.HexInt:
        return new VTError { Text = variant.Value is HexInt HexLong ? HexLong.ToString() : string.Empty };
      case VariantType.Blob:
        return new VTBlob { Text = variant.Value is byte[] blob ? Convert.ToBase64String(blob) : String.Empty };
      case VariantType.OBlob:
        return new VTOBlob { Text = variant.Value is byte[] oBlob ? Convert.ToBase64String(oBlob) : String.Empty };
      case VariantType.Storage:
        return new VTStorage { Text = variant.Value is byte[] storage ? Convert.ToBase64String(storage) : String.Empty };
      case VariantType.OStorage:
        return new VTOStorage { Text = variant.Value is byte[] oStorage ? Convert.ToBase64String(oStorage) : String.Empty };
      case VariantType.Stream:
        return new VTStreamData { Text = variant.Value is byte[] streamData ? Convert.ToBase64String(streamData) : String.Empty };
      case VariantType.OStream:
        return new VTOStreamData { Text = variant.Value is byte[] oStreamData ? Convert.ToBase64String(oStreamData) : String.Empty };
      case VariantType.VStream:
        var vStreamDataVariant = new VTVStreamData();
        if (variant.Value is VStreamData vStreamData)
        {
          vStreamDataVariant.Text = Convert.ToBase64String(vStreamData.Data);
          vStreamDataVariant.Version = vStreamData.Version != null ? XmlConvert.ToString((Guid)vStreamData.Version) : null;
        }
        ;
        return vStreamDataVariant;
      case VariantType.ClipboardData:
        var vClipboardDataVariant = new VTClipboardData();
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
        if (variant.Value is Variant variantValue) variantVariant.AddChild(CreateOpenXmlElement(variantValue));
        ;
        return variantVariant;
      case VariantType.Vector:
        if (variant is VectorVariant varVector)
        {
          var vtVector = VTVectorConverter.CreateOpenXmlElement(varVector);
          if (vtVector != null)
            return vtVector;
        }
        throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT vector");
      case VariantType.Array:
        if (variant is ArrayVariant varArray)
        {
          var vtArray = VTArrayConverter.CreateOpenXmlElement(varArray);
          if (vtArray != null)
            return vtArray;
        }
        throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT array");
    }
    throw new InvalidOperationException($"Can't convert value of type {variant.GetType()} to VT array");
  }
}