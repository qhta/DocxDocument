using System;

using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Empty.
/// </summary>
public class VTEmptyImpl: VariantImpl, VTEmpty
{
  public new DocumentFormat.OpenXml.VariantTypes.VTEmpty? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTEmpty?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTEmptyImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTEmpty();
  }

  public VTEmptyImpl(DocumentFormat.OpenXml.VariantTypes.VTEmpty element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get => null;
    set { }
  }

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Empty;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return "<null>";
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt64");
  }
}
