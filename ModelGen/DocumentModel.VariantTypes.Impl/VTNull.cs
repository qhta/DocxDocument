using System.IO;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Null variant implementation. Value is DbNull object.
/// </summary>
public class VTNullImpl: VariantImpl, VTNull
{
  public new DocumentFormat.OpenXml.VariantTypes.VTNull? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTNull?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTNullImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTNull();
  }

  public VTNullImpl(DocumentFormat.OpenXml.VariantTypes.VTNull element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get => DBNull.Value;
    set { }
  }

  public override TypeCode GetTypeCode()
  {
    return TypeCode.DBNull;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return "<null>";
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Null variant to UInt64");
  }

}
