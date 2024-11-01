using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Serialization;

using VariantType = DocumentModel.VariantType;
using Variant = DocumentModel.Variant;

using DocumentModel;
using DocumentModel.Properties;

namespace DocxDocument.Reader.Test
{
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

      variant = Single.MaxValue.ToString();
      Assert.That((Single)variant, Is.EqualTo(Single.MaxValue), "String set/ Single get error");

      variant = Single.MinValue.ToString();
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

      variant = Double.MaxValue.ToString();
      Assert.That((Double)variant, Is.EqualTo(Double.MaxValue), "String set/ Double get error");

      variant = Double.MinValue.ToString();
      Assert.That((Double)variant, Is.EqualTo(Double.MinValue), "String set/ Double get error");
    }

    [Test]
    public void TestDateTimeVariantType()
    {
      Variant variant;
      var dt = DateTime.Now;
      var date = DateOnly.FromDateTime(dt);
      var dt2 = date.ToDateTime(new TimeOnly());
      variant = dt;
      Assert.That((DateTime)variant, Is.EqualTo(dt), "DateTime set/ DateTime get");
      Assert.That((DateOnly)variant, Is.EqualTo(date), "DateTime set/ DateOnly get");
      variant = date;
      Assert.That((DateOnly)variant, Is.EqualTo(date), "DateOnly set/ DateOnly get");
      Assert.That((DateTime)variant, Is.EqualTo(dt2), "DateOnly  set/ DateTime get");
      dt2 = DateTime.Parse("2003-02-01");
      date = DateOnly.Parse("2003-02-01");
      variant = "2003-02-01";
      Assert.That((DateOnly)variant, Is.EqualTo(date), "String set/ DateOnly get");
      Assert.That((DateTime)variant, Is.EqualTo(dt2), "String  set/ DateTime get");
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
      Assert.That((int)variant, Is.EqualTo(n), "Char set/ int get");
    }


    [Test]
    public void TestErrorVariantType()
    {
      Variant variant;

      variant = new Variant(VariantType.Error, 0xFFFF);
      Assert.That((int)variant, Is.EqualTo(0xFFFF), "Error set/ Int get");
      variant = new Variant(VariantType.Error, "FFFF");
      Assert.That((int)variant, Is.EqualTo(0xFFFF), "Error set/ Int get");
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
      { VariantType.Char, Char.MaxValue }, 
      { VariantType.Date, DateOnly.FromDateTime(DateTime.Now) }, 
      { VariantType.DateTime, DateTime.Now }, 
      { VariantType.Bool, true }, 
      { VariantType.Currency, Decimal.MaxValue }, 
      { VariantType.Null, DBNull.Value }, 
      { VariantType.Empty, null }, 
      { VariantType.Error, UInt16.MaxValue }, 
      { VariantType.ClassId, Guid.NewGuid() }, 
};

    [Test]
    public void TestVariantSerialization()
    {
      foreach (var variantType in typeof(VariantType).GetEnumValues().Cast<VariantType>())
      {
        if (TestVariantValues.TryGetValue(variantType, out var val))
        {
          var variant = new Variant(variantType, val);
          var textWriter = new StringWriter();
          var serializer = new XmlSerializer(typeof(Variant));
          serializer.Serialize(textWriter, variant);
          textWriter.Flush();
          string str = textWriter.ToString();
          TestContext.Out.WriteLine(str);
          TestContext.Out.WriteLine();

          var textReader = new StringReader(str);
          var newVariant = (Variant?)serializer.Deserialize(textReader);
          Assert.IsNotNull(newVariant, $"Deserialized variant is null for VariantType.{variantType}");
          Assert.That(newVariant.Value, Is.EqualTo(variant.Value), $"Deserialized variant value different for VariantType.{variantType}");
        }
      }
    }
  }
}