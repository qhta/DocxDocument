

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

namespace DocumentModel.BaseConverters.Test;

public static class Int64OpenXmlConverterTest
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SByteValue),
    typeof(DX.Int16Value),
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.IntegerValue),
    typeof(DX.ByteValue),
    typeof(DX.UInt16Value),
    typeof(DX.UInt32Value),
    typeof(DX.UInt64Value),
    typeof(DX.StringValue)

  ];

  public static bool Run()
  {
    bool testResult = true;

    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestInt64OpenXmlConversion with {type.Name} ");
      if (!TestInt64OpenXmlConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }

    return testResult;
  }

  static readonly Int64[] testValues =
  [
    Int64.MinValue,
    -123456L,
    -1L,
    0L,
    1L,
    123456L,
    Int64.MaxValue
  ];

  public static Dictionary<Type, (Int64 min, Int64 max)> typeRanges = new()
  {
    { typeof(DX.ByteValue), (0, Byte.MaxValue) },
    { typeof(DX.Int16Value), (Int16.MinValue, Int16.MaxValue) },
    { typeof(DX.Int32Value), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.Int64Value), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.IntegerValue), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.SByteValue), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt32.MaxValue) },
    { typeof(DX.UInt64Value), (0, Int64.MaxValue) },
    { typeof(DX.StringValue), (Int64.MinValue, Int64.MaxValue) }
  };

  public static bool TestInt64OpenXmlConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        var openXmlValue = Int64OpenXmlConverter.ConvertToOpenXml(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        var (min, max) = typeRanges[openXmlType];
        if (testValue < min || testValue > max)
        {
          Console.WriteLine("Out-of-range value did not throw an exception. ");
          return false; // Expected exception for out-of-range value
        }
        // Convert back to Int64
        var convertedBackValue = Int64OpenXmlConverter.ConvertFromOpenXml(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to Int64 returned null for OpenXml value {openXmlValue}");
          return false;
        }
        if (!testValue.Equals(convertedBackValue))
        {
          Console.WriteLine($"Mismatch: original {testValue}, converted back {convertedBackValue}");
          return false;
        }
      } catch (Exception e)
      {
        var (min, max) = typeRanges[openXmlType];
        if (testValue < min || testValue > max)
          return true; // Expected exception for out-of-range value
        Console.WriteLine(e.Message+". ");
        return false;
      }

    }
    return true;
  }


}
