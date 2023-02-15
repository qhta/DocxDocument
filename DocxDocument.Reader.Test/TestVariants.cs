using System.ComponentModel;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentModel;

using Qhta.TypeUtils;
using Qhta.Xml.Serialization;

using Variant = DocumentModel.Variant;
using VariantType = DocumentModel.VariantType;

using Newtonsoft.Json;
using Qhta.Conversion;
using System.Xml.Serialization;
using Qhta.SystemUtils;

namespace DocxDocument.Reader.Test;
public enum Numbers: UInt64
{
  One = 1,
  MaxUInt32 = UInt32.MaxValue,
  MaxUInt64 =UInt64.MaxValue,
}

[TypeConverter(typeof(RGBTypeConverter))]
public struct RGB: IConvertible
{
  [XmlIgnore] public Byte R { get; set; }
  [XmlIgnore] public Byte G { get; set; }
  [XmlIgnore] public Byte B { get; set; }

  public static implicit operator RGB(UInt32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator UInt32(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 8) | value.B;

  public override string ToString()
  {
    return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
  }

  public TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public string ToString(IFormatProvider? provider)
  {
    return ToUInt32(provider).ToString("X6");
  }

  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return this;
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new NotImplementedException();
  }
}

public class RGBTypeConverter : TypeConverter
{
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is RGB val)
      return val.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (UInt32.TryParse(str, NumberStyles.HexNumber, null, out var val))
        return (RGB)val;
    }
    return base.ConvertFrom(context, culture, value);
  }
}

public class TestVariants : TestBase
{

  [Test]
  public void TestBooleanVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((bool)variant, Is.EqualTo(true), "Boolean value set/get error");

    variant = false;
    Assert.That((bool)variant, Is.EqualTo(false), "Boolean value set/get error");

    variant = (byte)1;
    Assert.That((bool)variant, Is.EqualTo(true), "Byte set/ boolean get error");

    variant = (byte)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Byte set/ boolean get error");

    variant = (sbyte)(-1);
    Assert.That((bool)variant, Is.EqualTo(true), "SByte set/ boolean get error");

    variant = (sbyte)0;
    Assert.That((bool)variant, Is.EqualTo(false), "SByte set/ boolean get error");

    variant = Int16.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Int16 set/ boolean get error");

    variant = (Int16)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Int16 set/ boolean get error");

    variant = UInt16.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "UInt16 set/ boolean get error");

    variant = (UInt16)0;
    Assert.That((bool)variant, Is.EqualTo(false), "UInt16 set/ boolean get error");

    variant = Int32.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Int32 set/ boolean get error");

    variant = (Int32)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Int32 set/ boolean get error");

    variant = UInt32.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "UInt32 set/ boolean get error");

    variant = (UInt32)0;
    Assert.That((bool)variant, Is.EqualTo(false), "UInt32 set/ boolean get error");

    variant = Int64.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Int64 set/ boolean get error");

    variant = (Int64)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Int64 set/ boolean get error");

    variant = UInt64.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "UInt64 set/ boolean get error");

    variant = (UInt64)0;
    Assert.That((bool)variant, Is.EqualTo(false), "UInt64 set/ boolean get error");

    variant = Decimal.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Decimal set/ boolean get error");

    variant = (Decimal)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Decimal set/ boolean get error");

    variant = Single.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Single set/ boolean get error");

    variant = (Single)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Single set/ boolean get error");

    variant = Double.MaxValue;
    Assert.That((bool)variant, Is.EqualTo(true), "Double set/ boolean get error");

    variant = (Double)0;
    Assert.That((bool)variant, Is.EqualTo(false), "Double set/ boolean get error");

    variant = "true";
    Assert.That((bool)variant, Is.EqualTo(true), "String set/ boolean get error");

    variant = "false";
    Assert.That((bool)variant, Is.EqualTo(false), "String set/ boolean get error");

    variant = "1";
    Assert.That((bool)variant, Is.EqualTo(true), "String set/ boolean get error");

    variant = "0";
    Assert.That((bool)variant, Is.EqualTo(false), "String set/ boolean get error");
  }

  [Test]
  public void TestByteVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((byte)variant, Is.EqualTo(1), "Boolean set/ byte get error");

    variant = false;
    Assert.That((byte)variant, Is.EqualTo(0), "Boolean set/ byte get error");

    variant = (byte)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Byte set/ get error");

    variant = (byte)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Byte set/ get error");

    variant = (sbyte)(127);
    Assert.That((byte)variant, Is.EqualTo(127), "SByte set/ byte get error");

    variant = (sbyte)0;
    Assert.That((byte)variant, Is.EqualTo(0), "SByte set/ byte get error");

    variant = (Int16)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Int16 set/ byte get error");

    variant = (Int16)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Int16 set/ byte get error");

    variant = (UInt16)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "UInt16 set/ byte get error");

    variant = (UInt16)0;
    Assert.That((byte)variant, Is.EqualTo(0), "UInt16 set/ byte get error");

    variant = (Int32)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Int32 set/ byte get error");

    variant = (Int32)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Int32 set/ byte get error");

    variant = (UInt32)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "UInt32 set/ byte get error");

    variant = (UInt32)0;
    Assert.That((byte)variant, Is.EqualTo(0), "UInt32 set/ byte get error");

    variant = (Int64)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Int64 set/ byte get error");

    variant = (Int64)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Int64 set/ byte get error");

    variant = (UInt64)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "UInt64 set/ byte get error");

    variant = (UInt64)0;
    Assert.That((byte)variant, Is.EqualTo(0), "UInt64 set/ byte get error");

    variant = (Decimal)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Decimal set/ byte get error");

    variant = (Decimal)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Decimal set/ byte get error");

    variant = (Single)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Single set/ byte get error");

    variant = (Single)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Single set/ byte get error");

    variant = (Double)(255);
    Assert.That((byte)variant, Is.EqualTo(255), "Double set/ byte get error");

    variant = (Double)0;
    Assert.That((byte)variant, Is.EqualTo(0), "Double set/ byte get error");

    variant = "255";
    Assert.That((byte)variant, Is.EqualTo(255), "String set/ byte get error");

    variant = "0";
    Assert.That((byte)variant, Is.EqualTo(0), "String set/ byte get error");
  }

  [Test]
  public void TestSByteVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((sbyte)variant, Is.EqualTo(1), "Boolean set/ sbyte get error");

    variant = false;
    Assert.That((sbyte)variant, Is.EqualTo(0), "Boolean set/ sbyte get error");

    variant = (byte)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Byte set/ sbyte get error");

    variant = (byte)0;
    Assert.That((sbyte)variant, Is.EqualTo(0), "Byte set/ sbyte get error");

    variant = (sbyte)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "SByte set/get error");

    variant = (sbyte)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "SByte set/get error");

    variant = (Int16)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Int16 set/ sbyte get error");

    variant = (Int16)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Int16 set/ sbyte get error");

    variant = (UInt16)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "UInt16 set/ sbyte get error");

    variant = (UInt16)(0);
    Assert.That((sbyte)variant, Is.EqualTo(0), "UInt16 set/ sbyte get error");

    variant = (Int32)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Int32 set/ sbyte get error");

    variant = (Int32)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Int32 set/ sbyte get error");

    variant = (UInt32)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "UInt32 set/ sbyte get error");

    variant = (UInt32)(0);
    Assert.That((sbyte)variant, Is.EqualTo(0), "UInt32 set/ sbyte get error");

    variant = (Int64)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Int64 set/ sbyte get error");

    variant = (Int64)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Int64 set/ sbyte get error");

    variant = (UInt64)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "UInt64 set/ sbyte get error");

    variant = (UInt64)(0);
    Assert.That((sbyte)variant, Is.EqualTo(0), "UInt64 set/ sbyte get error");

    variant = (Decimal)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Decimal set/ sbyte get error");

    variant = (Decimal)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Decimal set/ sbyte get error");

    variant = (Single)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Single set/ sbyte get error");

    variant = (Single)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Single set/ sbyte get error");

    variant = (Double)(127);
    Assert.That((sbyte)variant, Is.EqualTo(127), "Double set/ sbyte get error");

    variant = (Double)(-128);
    Assert.That((sbyte)variant, Is.EqualTo(-128), "Double set/ sbyte get error");

    variant = "127";
    Assert.That((sbyte)variant, Is.EqualTo(127), "String set/ sbyte get error");

    variant = "-128";
    Assert.That((sbyte)variant, Is.EqualTo(-128), "String set/ sbyte get error");
  }

  [Test]
  public void TestInt16VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Int16)variant, Is.EqualTo(1), "Boolean set/ Int16 get error");

    variant = false;
    Assert.That((Int16)variant, Is.EqualTo(0), "Boolean set/ Int16 get error");

    variant = (byte)(127);
    Assert.That((Int16)variant, Is.EqualTo(127), "Byte set/ Int16 get error");

    variant = (byte)0;
    Assert.That((Int16)variant, Is.EqualTo(0), "Byte set/ Int16 get error");

    variant = (sbyte)(127);
    Assert.That((Int16)variant, Is.EqualTo(127), "SByte set/ Int16 get error");

    variant = (sbyte)(-128);
    Assert.That((Int16)variant, Is.EqualTo(-128), "SByte set/ Int16 get error");

    variant = (Int16)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Int16 set/ Int16 get error");

    variant = (Int16)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Int16 set/ Int16 get error");

    variant = (UInt16)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "UInt16 set/ Int16 get error");

    variant = (UInt16)(0);
    Assert.That((Int16)variant, Is.EqualTo(0), "UInt16 set/ Int16 get error");

    variant = (Int32)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Int32 set/ Int16 get error");

    variant = (Int32)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Int32 set/ Int16 get error");

    variant = (UInt32)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "UInt32 set/ Int16 get error");

    variant = (UInt32)(0);
    Assert.That((Int16)variant, Is.EqualTo(0), "UInt32 set/ Int16 get error");

    variant = (Int64)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Int64 set/ Int16 get error");

    variant = (Int64)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Int64 set/ Int16 get error");

    variant = (UInt64)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "UInt64 set/ Int16 get error");

    variant = (UInt64)(0);
    Assert.That((Int16)variant, Is.EqualTo(0), "UInt64 set/ Int16 get error");

    variant = (Decimal)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Decimal set/ Int16 get error");

    variant = (Decimal)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Decimal set/ Int16 get error");

    variant = (Single)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Single set/ Int16 get error");

    variant = (Single)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Single set/ Int16 get error");

    variant = (Double)(32767);
    Assert.That((Int16)variant, Is.EqualTo(32767), "Double set/ Int16 get error");

    variant = (Double)(-32768);
    Assert.That((Int16)variant, Is.EqualTo(-32768), "Double set/ Int16 get error");

    variant = "32767";
    Assert.That((Int16)variant, Is.EqualTo(32767), "String set/ Int16 get error");

    variant = "-32768";
    Assert.That((Int16)variant, Is.EqualTo(-32768), "String set/ Int16 get error");
  }

  [Test]
  public void TestUInt16VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((UInt16)variant, Is.EqualTo(1), "Boolean set/ UInt16 get error");

    variant = false;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Boolean set/ UInt16 get error");

    variant = (byte)(255);
    Assert.That((UInt16)variant, Is.EqualTo(255), "Byte set/ UInt16 get error");

    variant = (byte)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Byte set/ UInt16 get error");

    variant = (sbyte)(127);
    Assert.That((UInt16)variant, Is.EqualTo(127), "SByte set/ UInt16 get error");

    variant = (sbyte)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "SByte set/ UInt16 get error");

    variant = (Int16)(32767);
    Assert.That((UInt16)variant, Is.EqualTo(32767), "Int16 set/ UInt16 get error");

    variant = (Int16)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Int16 set/ UInt16 get error");

    variant = (UInt16)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "UInt16 set/ UInt16 get error");

    variant = (UInt16)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "UInt16 set/ UInt16 get error");

    variant = (Int32)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "Int32 set/ UInt16 get error");

    variant = (Int32)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Int32 set/ UInt16 get error");

    variant = (UInt32)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "UInt32 set/ UInt16 get error");

    variant = (UInt32)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "UInt32 set/ UInt16 get error");

    variant = (Int64)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "Int64 set/ UInt16 get error");

    variant = (Int64)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Int64 set/ UInt16 get error");

    variant = (UInt64)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "UInt64 set/ UInt16 get error");

    variant = (UInt64)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "UInt64 set/ UInt16 get error");

    variant = (Decimal)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "Decimal set/ UInt16 get error");

    variant = (Decimal)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Decimal set/ UInt16 get error");

    variant = (Single)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "Single set/ UInt16 get error");

    variant = (Single)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Single set/ UInt16 get error");

    variant = (Double)(65535);
    Assert.That((UInt16)variant, Is.EqualTo(65535), "Double set/ UInt16 get error");

    variant = (Double)0;
    Assert.That((UInt16)variant, Is.EqualTo(0), "Double set/ UInt16 get error");

    variant = "65535";
    Assert.That((UInt16)variant, Is.EqualTo(65535), "String set/ UInt16 get error");

    variant = "0";
    Assert.That((UInt16)variant, Is.EqualTo(0), "String set/ UInt16 get error");
  }


  [Test]
  public void TestInt32VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Int32)variant, Is.EqualTo(1), "Boolean set/ Int32 get error");

    variant = false;
    Assert.That((Int32)variant, Is.EqualTo(0), "Boolean set/ Int32 get error");

    variant = (byte)(127);
    Assert.That((Int32)variant, Is.EqualTo(127), "Byte set/ Int32 get error");

    variant = (byte)0;
    Assert.That((Int32)variant, Is.EqualTo(0), "Byte set/ Int32 get error");

    variant = (sbyte)(127);
    Assert.That((Int32)variant, Is.EqualTo(127), "SByte set/ Int32 get error");

    variant = (sbyte)(-128);
    Assert.That((Int32)variant, Is.EqualTo(-128), "SByte set/ Int32 get error");

    variant = (Int16)(32767);
    Assert.That((Int32)variant, Is.EqualTo(32767), "Int16 set/ Int32 get error");

    variant = (Int16)(-32768);
    Assert.That((Int32)variant, Is.EqualTo(-32768), "Int16 set/ Int32 get error");

    variant = (UInt16)(65535);
    Assert.That((Int32)variant, Is.EqualTo(65535), "UInt16 set/ Int32 get error");

    variant = (UInt16)(0);
    Assert.That((Int32)variant, Is.EqualTo(0), "UInt16 set/ Int32 get error");

    variant = (Int32)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "Int32 set/ Int32 get error");

    variant = (Int32)(-2147483648);
    Assert.That((Int32)variant, Is.EqualTo(-2147483648), "Int32 set/ Int32 get error");

    variant = (UInt32)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "UInt32 set/ Int32 get error");

    variant = (UInt32)(0);
    Assert.That((Int32)variant, Is.EqualTo(0), "UInt32 set/ Int32 get error");

    variant = (Int64)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "Int64 set/ Int32 get error");

    variant = (Int64)(-2147483648);
    Assert.That((Int32)variant, Is.EqualTo(-2147483648), "Int64 set/ Int32 get error");

    variant = (UInt64)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "UInt64 set/ Int32 get error");

    variant = (UInt64)(0);
    Assert.That((Int32)variant, Is.EqualTo(0), "UInt64 set/ Int32 get error");

    variant = (Decimal)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "Decimal set/ Int32 get error");

    variant = (Decimal)(-2147483648);
    Assert.That((Int32)variant, Is.EqualTo(-2147483648), "Decimal set/ Int32 get error");

    variant = (Single)(1000000000);
    Assert.That((Int32)variant, Is.EqualTo(1000000000), "Single set/ Int32 get error");

    variant = (Single)(-1000000000);
    Assert.That((Int32)variant, Is.EqualTo(-1000000000), "Single set/ Int32 get error");

    variant = (Double)(2147483647);
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "Double set/ Int32 get error");

    variant = (Double)(-2147483648);
    Assert.That((Int32)variant, Is.EqualTo(-2147483648), "Double set/ Int32 get error");

    variant = "2147483647";
    Assert.That((Int32)variant, Is.EqualTo(2147483647), "String set/ Int32 get error");

    variant = "-2147483648";
    Assert.That((Int32)variant, Is.EqualTo(-2147483648), "String set/ Int32 get error");
  }

  [Test]
  public void TestUInt32VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Decimal)variant, Is.EqualTo(1), "Boolean set/ UInt32 get error");

    variant = false;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Boolean set/ UInt32 get error");

    variant = (byte)(255);
    Assert.That((Decimal)variant, Is.EqualTo(255), "Byte set/ UInt32 get error");

    variant = (byte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Byte set/ UInt32 get error");

    variant = (sbyte)(127);
    Assert.That((Decimal)variant, Is.EqualTo(127), "SByte set/ UInt32 get error");

    variant = (sbyte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "SByte set/ UInt32 get error");

    variant = (Int16)(32767);
    Assert.That((Decimal)variant, Is.EqualTo(32767), "Int16 set/ UInt32 get error");

    variant = (Int16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int16 set/ UInt32 get error");

    variant = (UInt16)(65535);
    Assert.That((Decimal)variant, Is.EqualTo(65535), "UInt16 set/ UInt32 get error");

    variant = (UInt16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt16 set/ UInt32 get error");

    variant = (Int32)(2147483647);
    Assert.That((Decimal)variant, Is.EqualTo(2147483647), "Int32 set/ UInt32 get error");

    variant = (Int32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int32 set/ UInt32 get error");

    variant = (UInt32)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "UInt32 set/ UInt32 get error");

    variant = (UInt32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt32 set/ UInt32 get error");

    variant = (Int64)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "Int64 set/ UInt32 get error");

    variant = (Int64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int64 set/ UInt32 get error");

    variant = (UInt64)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "UInt64 set/ UInt32 get error");

    variant = (UInt64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt64 set/ UInt32 get error");

    variant = (Decimal)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "Decimal set/ UInt32 get error");

    variant = (Decimal)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Decimal set/ UInt32 get error");

    variant = (Single)(1000000000);
    Assert.That((Decimal)variant, Is.EqualTo(1000000000), "Single set/ UInt32 get error");

    variant = (Single)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Single set/ UInt32 get error");

    variant = (Double)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "Double set/ UInt32 get error");

    variant = (Double)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Double set/ UInt32 get error");

    variant = "4294967295";
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "String set/ UInt32 get error");

    variant = "0";
    Assert.That((Decimal)variant, Is.EqualTo(0), "String set/ UInt32 get error");
  }




  [Test]
  public void TestInt64VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Int64)variant, Is.EqualTo(1), "Boolean set/ Int64 get error");

    variant = false;
    Assert.That((Int64)variant, Is.EqualTo(0), "Boolean set/ Int64 get error");

    variant = (byte)(127);
    Assert.That((Int64)variant, Is.EqualTo(127), "Byte set/ Int64 get error");

    variant = (byte)0;
    Assert.That((Int64)variant, Is.EqualTo(0), "Byte set/ Int64 get error");

    variant = (sbyte)(127);
    Assert.That((Int64)variant, Is.EqualTo(127), "SByte set/ Int64 get error");

    variant = (sbyte)(-128);
    Assert.That((Int64)variant, Is.EqualTo(-128), "SByte set/ Int64 get error");

    variant = (Int16)(32767);
    Assert.That((Int64)variant, Is.EqualTo(32767), "Int16 set/ Int64 get error");

    variant = (Int16)(-32768);
    Assert.That((Int64)variant, Is.EqualTo(-32768), "Int16 set/ Int64 get error");

    variant = (UInt16)(65535);
    Assert.That((Int64)variant, Is.EqualTo(65535), "UInt16 set/ Int64 get error");

    variant = (UInt16)(0);
    Assert.That((Int64)variant, Is.EqualTo(0), "UInt16 set/ Int64 get error");

    variant = (Int32)(2147483647);
    Assert.That((Int64)variant, Is.EqualTo(2147483647), "Int32 set/ Int64 get error");

    variant = (Int32)(-2147483648);
    Assert.That((Int64)variant, Is.EqualTo(-2147483648), "Int32 set/ Int64 get error");

    variant = (UInt32)(4294967295);
    Assert.That((Int64)variant, Is.EqualTo(4294967295), "UInt32 set/ Int64 get error");

    variant = (UInt32)(0);
    Assert.That((Int64)variant, Is.EqualTo(0), "UInt32 set/ Int64 get error");

    variant = (Int64)(Int64.MaxValue);
    Assert.That((Int64)variant, Is.EqualTo(Int64.MaxValue), "Int64 set/ Int64 get error");

    variant = (Int64)(Int64.MinValue);
    Assert.That((Int64)variant, Is.EqualTo(Int64.MinValue), "Int64 set/ Int64 get error");

    variant = (UInt64)(Int64.MaxValue);
    Assert.That((Int64)variant, Is.EqualTo(Int64.MaxValue), "UInt64 set/ Int64 get error");

    variant = (UInt64)(0);
    Assert.That((Int64)variant, Is.EqualTo(0), "UInt64 set/ Int64 get error");

    variant = (Decimal)(Int64.MaxValue);
    Assert.That((Int64)variant, Is.EqualTo(Int64.MaxValue), "Decimal set/ Int64 get error");

    variant = (Decimal)(-2147483648);
    Assert.That((Int64)variant, Is.EqualTo(-2147483648), "Decimal set/ Int64 get error");

    variant = (Single)(1_000_000_000);
    Assert.That((Int64)variant, Is.EqualTo(1_000_000_000), "Single set/ Int64 get error");

    variant = (Single)(-1_000_000_000);
    Assert.That((Int64)variant, Is.EqualTo(-1_000_000_000), "Single set/ Int64 get error");

    variant = (Double)(5764607522497363968);
    Assert.That((Int64)variant, Is.EqualTo(5764607522497363968), "Double set/ Int64 get error");

    variant = (Double)(-5764607522497363968);
    Assert.That((Int64)variant, Is.EqualTo(-5764607522497363968), "Double set/ Int64 get error");

    variant = "9223372036854775807";
    Assert.That((Int64)variant, Is.EqualTo(9223372036854775807), "String set/ Int64 get error");

    variant = "-9223372036854775808";
    Assert.That((Int64)variant, Is.EqualTo(-9223372036854775808), "String set/ Int64 get error");
  }

  [Test]
  public void TestUInt64VariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Decimal)variant, Is.EqualTo(1), "Boolean set/ UInt64 get error");

    variant = false;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Boolean set/ UInt64 get error");

    variant = (byte)(255);
    Assert.That((Decimal)variant, Is.EqualTo(255), "Byte set/ UInt64 get error");

    variant = (byte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Byte set/ UInt64 get error");

    variant = (sbyte)(127);
    Assert.That((Decimal)variant, Is.EqualTo(127), "SByte set/ UInt64 get error");

    variant = (sbyte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "SByte set/ UInt64 get error");

    variant = (Int16)(32767);
    Assert.That((Decimal)variant, Is.EqualTo(32767), "Int16 set/ UInt64 get error");

    variant = (Int16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int16 set/ UInt64 get error");

    variant = (UInt16)(65535);
    Assert.That((Decimal)variant, Is.EqualTo(65535), "UInt16 set/ UInt64 get error");

    variant = (UInt16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt16 set/ UInt64 get error");

    variant = (Int32)(2147483647);
    Assert.That((Decimal)variant, Is.EqualTo(2147483647), "Int32 set/ UInt64 get error");

    variant = (Int32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int32 set/ UInt64 get error");

    variant = (UInt32)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "UInt32 set/ UInt64 get error");

    variant = (UInt32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt32 set/ UInt64 get error");

    variant = (Int64)(9223372036854775807);
    Assert.That((Decimal)variant, Is.EqualTo(9223372036854775807), "Int64 set/ UInt64 get error");

    variant = (Int64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int64 set/ UInt64 get error");

    variant = (UInt64)(UInt64.MaxValue);
    Assert.That((Decimal)variant, Is.EqualTo(18446744073709551615), "UInt64 set/ UInt64 get error");

    variant = (UInt64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt64 set/ UInt64 get error");

    variant = (Decimal)(18446744073709551615);
    Assert.That((Decimal)variant, Is.EqualTo(18446744073709551615), "Decimal set/ UInt64 get error");

    variant = (Decimal)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Decimal set/ UInt64 get error");

    variant = (Single)(1_000_000_000);
    Assert.That((Decimal)variant, Is.EqualTo(1_000_000_000), "Single set/ UInt64 get error");

    variant = (Single)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Single set/ UInt64 get error");

    variant = (Double)(5_000_000_000_000_000_000);
    Assert.That((Decimal)variant, Is.EqualTo(5_000_000_000_000_000_000), "Double set/ UInt64 get error");

    variant = (Double)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Double set/ UInt64 get error");

    variant = "18446744073709551615";
    Assert.That((Decimal)variant, Is.EqualTo(18446744073709551615), "String set/ UInt64 get error");

    variant = "0";
    Assert.That((Decimal)variant, Is.EqualTo(0), "String set/ UInt64 get error");
  }

  [Test]
  public void TestDecimalVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Decimal)variant, Is.EqualTo(1), "Boolean set/ Decimal get error");

    variant = false;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Boolean set/ Decimal get error");

    variant = (byte)(255);
    Assert.That((Decimal)variant, Is.EqualTo(255), "Byte set/ Decimal get error");

    variant = (byte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Byte set/ Decimal get error");

    variant = (sbyte)(127);
    Assert.That((Decimal)variant, Is.EqualTo(127), "SByte set/ Decimal get error");

    variant = (sbyte)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "SByte set/ Decimal get error");

    variant = (Int16)(32767);
    Assert.That((Decimal)variant, Is.EqualTo(32767), "Int16 set/ Decimal get error");

    variant = (Int16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int16 set/ Decimal get error");

    variant = (UInt16)(65535);
    Assert.That((Decimal)variant, Is.EqualTo(65535), "UInt16 set/ Decimal get error");

    variant = (UInt16)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt16 set/ Decimal get error");

    variant = (Int32)(2147483647);
    Assert.That((Decimal)variant, Is.EqualTo(2147483647), "Int32 set/ Decimal get error");

    variant = (Int32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int32 set/ Decimal get error");

    variant = (UInt32)(4294967295);
    Assert.That((Decimal)variant, Is.EqualTo(4294967295), "UInt32 set/ Decimal get error");

    variant = (UInt32)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt32 set/ Decimal get error");

    variant = (Int64)(9223372036854775807);
    Assert.That((Decimal)variant, Is.EqualTo(9223372036854775807), "Int64 set/ Decimal get error");

    variant = (Int64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Int64 set/ Decimal get error");

    variant = (UInt64)(UInt64.MaxValue);
    Assert.That((Decimal)variant, Is.EqualTo(18446744073709551615), "UInt64 set/ Decimal get error");

    variant = (UInt64)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "UInt64 set/ Decimal get error");

    variant = (Decimal)(Decimal.MaxValue);
    Assert.That((Decimal)variant, Is.EqualTo(79228162514264337593543950335m), "Decimal set/ Decimal get error");

    variant = (Decimal)(Decimal.MinValue);
    Assert.That((Decimal)variant, Is.EqualTo(-79228162514264337593543950335m), "Decimal set/ Decimal get error");

    variant = (Single)(1_000_000_000);
    Assert.That((Decimal)variant, Is.EqualTo(1_000_000_000), "Single set/ Decimal get error");

    variant = (Single)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Single set/ Decimal get error");

    variant = (Double)(5_000_000_000_000_000_000);
    Assert.That((Decimal)variant, Is.EqualTo(5_000_000_000_000_000_000), "Double set/ Decimal get error");

    variant = (Double)0;
    Assert.That((Decimal)variant, Is.EqualTo(0), "Double set/ Decimal get error");

    variant = "79228162514264337593543950335";
    Assert.That((Decimal)variant, Is.EqualTo(79228162514264337593543950335m), "String set/ Decimal get error");

    variant = "0";
    Assert.That((Decimal)variant, Is.EqualTo(0), "String set/ Decimal get error");
  }

  [Test]
  public void TestSingleVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Single)variant, Is.EqualTo(1), "Boolean set/ Single get error");

    variant = false;
    Assert.That((Single)variant, Is.EqualTo(0), "Boolean set/ Single get error");

    variant = (byte)(255);
    Assert.That((Single)variant, Is.EqualTo(255), "Byte set/ Single get error");

    variant = (byte)0;
    Assert.That((Single)variant, Is.EqualTo(0), "Byte set/ Single get error");

    variant = (sbyte)(127);
    Assert.That((Single)variant, Is.EqualTo(127), "SByte set/ Single get error");

    variant = (sbyte)0;
    Assert.That((Single)variant, Is.EqualTo(0), "SByte set/ Single get error");

    variant = (Int16)(32767);
    Assert.That((Single)variant, Is.EqualTo(32767), "Int16 set/ Single get error");

    variant = (Int16)0;
    Assert.That((Single)variant, Is.EqualTo(0), "Int16 set/ Single get error");

    variant = (UInt16)(65535);
    Assert.That((Single)variant, Is.EqualTo(65535), "UInt16 set/ Single get error");

    variant = (UInt16)0;
    Assert.That((Single)variant, Is.EqualTo(0), "UInt16 set/ Single get error");

    variant = (Int32)(2147483647);
    Assert.That((Single)variant, Is.EqualTo(2147483647), "Int32 set/ Single get error");

    variant = (Int32)0;
    Assert.That((Single)variant, Is.EqualTo(0), "Int32 set/ Single get error");

    variant = (UInt32)(4294967295);
    Assert.That((Single)variant, Is.EqualTo(4294967295), "UInt32 set/ Single get error");

    variant = (UInt32)0;
    Assert.That((Single)variant, Is.EqualTo(0), "UInt32 set/ Single get error");

    variant = (Int64)(9223372036854775807);
    Assert.That((Single)variant, Is.EqualTo(9223372036854775807), "Int64 set/ Single get error");

    variant = (Int64)0;
    Assert.That((Single)variant, Is.EqualTo(0), "Int64 set/ Single get error");

    variant = (UInt64)(UInt64.MaxValue);
    Assert.That((Single)variant, Is.EqualTo(18446744073709551615), "UInt64 set/ Single get error");

    variant = (UInt64)0;
    Assert.That((Single)variant, Is.EqualTo(0), "UInt64 set/ Single get error");

    variant = (Decimal)(Decimal.MaxValue);
    Assert.That((Single)variant, Is.EqualTo(79228162514264337593543950335m), "Decimal set/ Single get error");

    variant = (Decimal)(Decimal.MinValue);
    Assert.That((Single)variant, Is.EqualTo(-79228162514264337593543950335m), "Decimal set/ Single get error");

    variant = (Single)(Single.MaxValue);
    Assert.That((Single)variant, Is.EqualTo(Single.MaxValue), "Single set/ Single get error");

    variant = (Single)(Single.MinValue);
    Assert.That((Single)variant, Is.EqualTo(Single.MinValue), "Single set/ Single get error");

    variant = (Double)(Single.MaxValue);
    Assert.That((Single)variant, Is.EqualTo(Single.MaxValue), "Double set/ Single get error");

    variant = (Double)(Single.MinValue);
    Assert.That((Single)variant, Is.EqualTo(Single.MinValue), "Double set/ Single get error");

    variant = Single.MaxValue.ToString(CultureInfo.InvariantCulture);
    Assert.That((Single)variant, Is.EqualTo(Single.MaxValue), "String set/ Single get error");

    variant = Single.MinValue.ToString(CultureInfo.InvariantCulture);
    Assert.That((Single)variant, Is.EqualTo(Single.MinValue), "String set/ Single get error");
  }

  [Test]
  public void TestDoubleVariantType()
  {
    Variant variant;
    variant = true;
    Assert.That((Double)variant, Is.EqualTo(1), "Boolean set/ Double get error");

    variant = false;
    Assert.That((Double)variant, Is.EqualTo(0), "Boolean set/ Double get error");

    variant = (byte)(255);
    Assert.That((Double)variant, Is.EqualTo(255), "Byte set/ Double get error");

    variant = (byte)0;
    Assert.That((Double)variant, Is.EqualTo(0), "Byte set/ Double get error");

    variant = (sbyte)(127);
    Assert.That((Double)variant, Is.EqualTo(127), "SByte set/ Double get error");

    variant = (sbyte)0;
    Assert.That((Double)variant, Is.EqualTo(0), "SByte set/ Double get error");

    variant = (Int16)(32767);
    Assert.That((Double)variant, Is.EqualTo(32767), "Int16 set/ Double get error");

    variant = (Int16)0;
    Assert.That((Double)variant, Is.EqualTo(0), "Int16 set/ Double get error");

    variant = (UInt16)(65535);
    Assert.That((Double)variant, Is.EqualTo(65535), "UInt16 set/ Double get error");

    variant = (UInt16)0;
    Assert.That((Double)variant, Is.EqualTo(0), "UInt16 set/ Double get error");

    variant = (Int32)(2147483647);
    Assert.That((Double)variant, Is.EqualTo(2147483647), "Int32 set/ Double get error");

    variant = (Int32)0;
    Assert.That((Double)variant, Is.EqualTo(0), "Int32 set/ Double get error");

    variant = (UInt32)(4294967295);
    Assert.That((Double)variant, Is.EqualTo(4294967295), "UInt32 set/ Double get error");

    variant = (UInt32)0;
    Assert.That((Double)variant, Is.EqualTo(0), "UInt32 set/ Double get error");

    variant = (Int64)(9223372036854775807);
    Assert.That((Double)variant, Is.EqualTo(9223372036854775807), "Int64 set/ Double get error");

    variant = (Int64)0;
    Assert.That((Double)variant, Is.EqualTo(0), "Int64 set/ Double get error");

    variant = (UInt64)(UInt64.MaxValue);
    Assert.That((Double)variant, Is.EqualTo(18446744073709551615), "UInt64 set/ Double get error");

    variant = (UInt64)0;
    Assert.That((Double)variant, Is.EqualTo(0), "UInt64 set/ Double get error");

    variant = (Decimal)(Decimal.MaxValue);
    Assert.That((Double)variant, Is.EqualTo(79228162514264337593543950335m), "Decimal set/ Double get error");

    variant = (Decimal)(Decimal.MinValue);
    Assert.That((Double)variant, Is.EqualTo(-79228162514264337593543950335m), "Decimal set/ Double get error");

    variant = (Single)(Single.MaxValue);
    Assert.That((Double)variant, Is.EqualTo(Single.MaxValue), "Single set/ Double get error");

    variant = (Single)(Single.MinValue);
    Assert.That((Double)variant, Is.EqualTo(Single.MinValue), "Single set/ Double get error");

    variant = (Double)(Double.MaxValue);
    Assert.That((Double)variant, Is.EqualTo(Double.MaxValue), "Double set/ Double get error");

    variant = (Double)(Double.MinValue);
    Assert.That((Double)variant, Is.EqualTo(Double.MinValue), "Double set/ Double get error");

    variant = Double.MaxValue.ToString(CultureInfo.InvariantCulture);
    Assert.That((Double)variant, Is.EqualTo(Double.MaxValue), "String set/ Double get error");

    variant = Double.MinValue.ToString(CultureInfo.InvariantCulture);
    Assert.That((Double)variant, Is.EqualTo(Double.MinValue), "String set/ Double get error");
  }

  [Test]
  public void TestDateTimeVariantType()
  {
    Variant variant;
    var dt = DateTime.Now.Truncate();
    var date = DateOnly.FromDateTime(dt);
    var dt2 = date.ToDateTime(new TimeOnly());
    variant = dt;
    Assert.That((DateTime)variant, Is.EqualTo(dt), "DateTime set/ DateTime get");
    Assert.That((DateOnly)variant, Is.EqualTo(date), "DateTime set/ DateOnly get");
    variant = date;
    Assert.That((DateOnly)variant, Is.EqualTo(date), "DateOnly set/ DateOnly get");
    Assert.That((DateTime)variant, Is.EqualTo(dt2), "DateOnly set/ DateTime get");
    dt2 = DateTime.Parse("2003-02-01");
    date = DateOnly.Parse("2003-02-01");
    variant = "2003-02-01";
    Assert.That((DateOnly)variant, Is.EqualTo(date), "String set/ DateOnly get");
    Assert.That((DateTime)variant, Is.EqualTo(dt2), "String set/ DateTime get");
  }

  [Test]
  public void TestBlobVariantType()
  {
    Variant variant;
    var blob = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var str = Convert.ToBase64String(blob);
    variant = blob;
    Assert.That((byte[])variant, Is.EqualTo(blob), "Blob set/ Blob get");
    variant = str;
    Assert.That((byte[])variant, Is.EqualTo(blob), "String set/ Blob get");
  }

  [Test]
  public void TestGuidVariantType()
  {
    Variant variant;
    var guid = Guid.NewGuid();
    var blob = guid.ToByteArray();
    var str = guid.ToString();
    variant = guid;
    Assert.That((Guid)variant, Is.EqualTo(guid), "Guid set/ Guid get");
    Assert.That((byte[])variant, Is.EqualTo(blob), "Guid set/ Blob get");
    variant = blob;
    Assert.That((Guid)variant, Is.EqualTo(guid), "Blob set/ Guid get");
    variant = str;
    Assert.That((Guid)variant, Is.EqualTo(guid), "String set/ Guid get");
  }

  [Test]
  public void TestCharVariantType()
  {
    Variant variant;
    var ch = '\n';
    var str = new string(ch, 1);
    var n = 10;
    variant = ch;
    Assert.That((Char)variant, Is.EqualTo(ch), "Char set/ Char get");
    variant = str;
    Assert.That((Char)variant, Is.EqualTo(ch), "String set/ Char get");
    variant = n;
    Assert.That((Char)variant, Is.EqualTo(ch), "Int set/ Char get");
    variant = ch;
    Assert.That((int)variant, Is.EqualTo(n), "Char set/ Int get");
  }

  [Test]
  public void TestErrorVariantType()
  {
    Variant variant;

    variant = new Variant(VariantType.HexInt, 0xFFFF);
    Assert.That((int)variant, Is.EqualTo(0xFFFF), "Error set/ Int get");
    variant = new Variant(VariantType.HexInt, "FFFF");
    Assert.That((int)variant, Is.EqualTo(0xFFFF), "Error set/ Int get");
  }

  [Test]
  public void TestEnumVariantType()
  {
    Variant variant;

    variant = new Variant(VariantType.Enum, Numbers.One);
    Assert.That((int)variant, Is.EqualTo(1), "Enum set/ Int get");
    variant = new Variant(VariantType.Enum, Numbers.MaxUInt32);
    Assert.That((UInt32)variant, Is.EqualTo(UInt32.MaxValue), "Enum set/ UInt32 get");
    variant = new Variant(VariantType.Enum, Numbers.MaxUInt64);
    Assert.That((UInt64)variant, Is.EqualTo(UInt64.MaxValue), "Enum set/ UInt64 get");

    variant = new Variant(VariantType.Enum, typeof(Numbers), 1);
    Assert.That(variant.ToEnum<Numbers>(), Is.EqualTo(Numbers.One), "Int set/ Enum get");
    variant = new Variant(VariantType.Enum, typeof(Numbers), UInt32.MaxValue);
    Assert.That(variant.ToEnum<Numbers>(), Is.EqualTo(Numbers.MaxUInt32), "UInt32 set/ Enum get");
    variant = new Variant(VariantType.Enum, typeof(Numbers), UInt64.MaxValue);
    Assert.That(variant.ToEnum<Numbers>(), Is.EqualTo(Numbers.MaxUInt64), "UInt64 set/ Enum get");

    variant = new Variant(VariantType.Enum, typeof(Numbers), "One");
    Assert.That(variant.ToEnum<Numbers>(), Is.EqualTo(Numbers.One), "String set/ Enum get");
    variant = new Variant(VariantType.Enum, typeof(Numbers), Numbers.One);
    Assert.That(variant.ToString(), Is.EqualTo("One"), "Enum set/ String get");
  }

  [Test]
  public void TestObjectVariantType()
  {
    Variant variant;

    variant = new Variant(VariantType.Object, new RGB{ R=16,G=32, B=48 });
    Assert.That((UInt32)variant, Is.EqualTo(0x102030), "Object set/ UInt32 get");
  }

  [Test]
  public void TestInternalVariantType()
  {
    Variant variant;
    var str = "internal";
    Variant v = str;
    variant = new Variant(v);
    Assert.That(variant.Value, Is.EqualTo(v), "Variant set/ Variant get");
  }

  [Test]
  public void TestVectorVariantType()
  {
    VectorVariant variant;
    var str = "internal";
    Variant v = str;
    variant = new VectorVariant(VariantType.Variant);
    variant.Add(1);
    variant.Add(str);
    variant.Add(v);
    Assert.That(variant.BaseType, Is.EqualTo(VariantType.Variant), "VectorVariant BaseType");
    Assert.That(variant.Count, Is.EqualTo(3), "VectorVariant Count");
    Assert.That(variant[0], Is.EqualTo(1), "VectorVariant element 0");
    Assert.That(variant[1], Is.EqualTo(str), "VectorVariant element 1");
    Assert.That(variant[2], Is.EqualTo(v), "VectorVariant element 2");
    int i = 0;
    foreach (var item in variant)
    {
      switch (i)
      {
        case 0:
          Assert.That(item, Is.EqualTo(1), "VectorVariant element enum 0");
          break;
        case 1:
          Assert.That(item, Is.EqualTo(str), "VectorVariant element enum 1");
          break;
        case 2:
          Assert.That(item, Is.EqualTo(v), "VectorVariant element enum 2");
          break;
      }
      i++;
    }
  }

  [Test]
  public void TestArrayVariantType()
  {
    ArrayVariant arrayVariant;
    arrayVariant = new ArrayVariant(VariantType.Integer, 1, 3);
    arrayVariant[1] = 5;
    arrayVariant[2] = 7;
    arrayVariant[3] = 9;
    Assert.That(arrayVariant.BaseType, Is.EqualTo(VariantType.Integer), "ArrayVariant BaseType");
    Assert.That(arrayVariant.ItemType, Is.EqualTo(typeof(Decimal)), "ArrayVariant ItemType");
    Assert.That(arrayVariant.Size, Is.EqualTo(3), "ArrayVariant Size");
    Assert.That(arrayVariant[1], Is.EqualTo(5), "ArrayVariant element 1");
    Assert.That(arrayVariant[2], Is.EqualTo(7), "ArrayVariant element 2");
    Assert.That(arrayVariant[3], Is.EqualTo(9), "ArrayVariant element 3");
    int i = 0;
    foreach (var item in arrayVariant)
    {
      switch (i)
      {
        case 0:
          Assert.That(item, Is.EqualTo(5), "ArrayVariant element enum 0");
          break;
        case 1:
          Assert.That(item, Is.EqualTo(7), "ArrayVariant element enum 1");
          break;
        case 2:
          Assert.That(item, Is.EqualTo(9), "ArrayVariant element enum 2");
          break;
      }
      i++;
    }

    arrayVariant.Resize(0, 3);
    Assert.That(arrayVariant[0], Is.EqualTo(5), "ArrayVariant resized element 0");
    Assert.That(arrayVariant[1], Is.EqualTo(7), "ArrayVariant resized element 1");
    Assert.That(arrayVariant[2], Is.EqualTo(9), "ArrayVariant resized element 2");
    Assert.That(arrayVariant[3], Is.EqualTo(0), "ArrayVariant resized element 3");

    arrayVariant.Resize(0, 3, VariantType.Byte);
    Assert.That(arrayVariant.ItemType, Is.EqualTo(typeof(Byte)), "ArrayVariant retyped ItemType");
    Assert.That(arrayVariant[0], Is.EqualTo(5), "ArrayVariant retyped element 0");
    Assert.That(arrayVariant[1], Is.EqualTo(7), "ArrayVariant retyped element 1");
    Assert.That(arrayVariant[2], Is.EqualTo(9), "ArrayVariant retyped element 2");
    Assert.That(arrayVariant[3], Is.EqualTo(0), "ArrayVariant retyped element 3");
  }

  private static Dictionary<VariantType, object?> TestVariantValues = new()
    {
      { VariantType.Empty, null },
      { VariantType.SByte, SByte.MaxValue },
      { VariantType.Int16, Int16.MaxValue },
      { VariantType.Int32, Int32.MaxValue },
      { VariantType.Int64, Int64.MaxValue },
      { VariantType.Integer, Int32.MaxValue },
      { VariantType.Byte, Byte.MaxValue },
      { VariantType.UInt16, UInt16.MaxValue },
      { VariantType.UInt32, UInt32.MaxValue },
      { VariantType.UInt64, UInt64.MaxValue },
      { VariantType.UnsignedInteger, Decimal.MaxValue },
      { VariantType.Single, Single.MaxValue },
      { VariantType.Double, Double.MaxValue },
      { VariantType.Decimal, Decimal.MaxValue },
      { VariantType.Char, Char.MaxValue - 2 },
      { VariantType.Date, DateOnly.FromDateTime(DateTime.Now) },
      { VariantType.DateTime, DateTime.Now },
      { VariantType.Boolean, true },
      { VariantType.Currency, Decimal.MaxValue },
      { VariantType.Null, DBNull.Value },
      { VariantType.HexInt, UInt16.MaxValue },
      { VariantType.Guid, Guid.NewGuid() },
      { VariantType.Blob, new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }},
      { VariantType.Enum, Numbers.MaxUInt64 },
      { VariantType.Object, new RGB{ R=0x10,G=0x20, B=0x30 } },

      // VariantType.Variant can't be tested here as deserialization results in internal vector value
    };


  [Test]
  public void TestVariantXmlSerialization()
  {
    foreach (var variantType in typeof(VariantType).GetEnumValues().Cast<VariantType>())
    {
      TestVariantXmlSerialization(variantType);
    }
  }

  public void TestVariantXmlSerialization(VariantType variantType)
  {
    if (TestVariantValues.TryGetValue(variantType, out var val))
    {
      var valStr = "null";
      if (val != null)
        valStr = $" {val} ({val.GetType().Name})";
      WriteLine($"Testing variant type {variantType} = {valStr}");
      var variant = new Variant(variantType, val);
      var textWriter = new StringWriter();
      var serializer = new QXmlSerializer(typeof(Variant), new Type[]{typeof(Numbers), typeof(RGB)});
      serializer.Serialize(textWriter, variant);
      textWriter.Flush();
      string str = textWriter.ToString();
      WriteLine(str);
      WriteLine();

      var textReader = new StringReader(str);
      var newVariant = (Variant?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newVariant, $"Deserialized variant is null for VariantType.{variantType}");
      Assert.That(newVariant?.VariantType, Is.EqualTo(variant.VariantType),
        $"Deserialized variant VariantType different for VariantType.{variantType}");
      var xl = newVariant?.Value;
      Assert.That(newVariant?.Value, Is.EqualTo(variant.Value), $"Deserialized variant value different for VariantType.{variantType}");
      Assert.That(newVariant, Is.EqualTo(variant), $"Deserialized variant different for VariantType.{variantType}");
    }
  }

  [Test]
  public void TestVectorXmlSerialization()
  {
    TestVectorXmlSerialization(null);
  }

  public void TestVectorXmlSerialization(VariantType? itemType)
  {
    var oldVectorVariant = new VectorVariant();
    foreach (var variantType in typeof(VariantType).GetEnumValues().Cast<VariantType>())
    {
      if (TestVariantValues.TryGetValue(variantType, out var val))
      {
        if (itemType == null || variantType == itemType)
        {
          var variant = new Variant(variantType, val);
          if (variantType == VariantType.Empty)
            oldVectorVariant.Add(null);
          else
            oldVectorVariant.Add(variant.Value);
        }
      }
    }
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(VectorVariant), new Type[]{typeof(Numbers), typeof(RGB)});
    serializer.Serialize(textWriter, oldVectorVariant);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    var textReader = new StringReader(str);
    var newVariant = (Variant?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newVariant, $"Deserialized variant is null");
    if (newVariant != null)
    {
      Assert.That(newVariant.GetType(), Is.EqualTo(typeof(VectorVariant)), $"Deserialized variant type different");
      if (newVariant is VectorVariant newVectorVariant)
      {
        Assert.That(newVariant.VariantType, Is.EqualTo(oldVectorVariant.VariantType), $"Deserialized variant VariantType different");
        Assert.That(newVectorVariant.Count, Is.EqualTo(oldVectorVariant.Count), $"Deserialized variant count different");
        for (int i = 0; i < newVectorVariant.Count; i++)
          Assert.That(newVectorVariant[i], Is.EqualTo(oldVectorVariant[i]), $"Deserialized variant value different");

        Assert.That(newVariant.Value, Is.EqualTo(oldVectorVariant.Value), $"Deserialized variant value different");
        Assert.That(newVectorVariant.BaseType, Is.EqualTo(oldVectorVariant.BaseType), $"Deserialized variant baseType different");
      }
    }
  }

  [Test]
  public void TestArrayVariantXmlSerialization()
  {
    foreach (var variantType in typeof(VariantType).GetEnumValues().Cast<VariantType>())
    {
      if (variantType == VariantType.Variant && TestVariantValues.TryGetValue(variantType, out var val))
      {
        var arrayVariant = new ArrayVariant();
        arrayVariant.Resize(10, variantType);
        for (int i = 0; i < 10; i++)
        {
          Variant itemVariant;
          var itemType = val?.GetType();
          if (itemType?.IsNumeral() == true)
            itemVariant = new Variant(variantType, i);
          else if (itemType == typeof(DateOnly))
            itemVariant = DateOnly.FromDayNumber(DateOnly.FromDateTime(DateTime.Now).DayNumber + i);
          else if (itemType == typeof(DateTime))
            itemVariant = DateTime.Now.AddDays(i);
          else if (itemType == typeof(Guid))
            itemVariant = Guid.NewGuid();
          else
            itemVariant = new Variant(variantType, val);
          arrayVariant[i] = itemVariant.Value;
        }
        var textWriter = new StringWriter();
        var serializer = new QXmlSerializer(typeof(Variant));
        serializer.Serialize(textWriter, arrayVariant);
        textWriter.Flush();
        string str = textWriter.ToString();
        WriteLine(str);
        WriteLine();

        var textReader = new StringReader(str);
        var newVariant = (Variant?)serializer.Deserialize(textReader);
        Assert.IsNotNull(newVariant, $"Deserialized variant is null");
        if (newVariant != null)
        {
          Assert.That(newVariant.GetType(), Is.EqualTo(typeof(ArrayVariant)), $"Deserialized variant type different");
          if (newVariant is ArrayVariant newArrayVariant)
          {
            Assert.That(newVariant.VariantType, Is.EqualTo(arrayVariant.VariantType), $"Deserialized variant VariantType different");
            Assert.That(newArrayVariant.Size, Is.EqualTo(arrayVariant.Size), $"Deserialized variant count different");
            for (int i = 0; i < newArrayVariant.Size; i++)
              Assert.That(newArrayVariant[i], Is.EqualTo(arrayVariant[i]), $"Deserialized variant value different");

            Assert.That(newVariant.Value, Is.EqualTo(arrayVariant.Value), $"Deserialized variant value different");
            Assert.That(newArrayVariant.BaseType, Is.EqualTo(arrayVariant.BaseType), $"Deserialized variant baseType different");
          }
        }
      }
    }
  }

}


