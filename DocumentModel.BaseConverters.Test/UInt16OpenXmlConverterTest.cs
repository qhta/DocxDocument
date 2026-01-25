

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

namespace DocumentModel.BaseConverters.Test;

public static class UInt16OpenXmlConverterTest
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
      Console.Write($"TestUInt16OpenXmlConversion with {type.Name} ");
      if (!TestUInt16OpenXmlConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }

    return testResult;
  }

  static readonly UInt16[] testValues =
  [
    0,
    0,
    0,
    0,
    1,
    12345,
    UInt16.MaxValue
  ];

  public static Dictionary<Type, (UInt16 min, UInt16 max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0, (UInt16)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0, (UInt16)Int16.MaxValue) },
    { typeof(DX.Int32Value), (0, UInt16.MaxValue) },
    { typeof(DX.Int64Value), (0, UInt16.MaxValue) },
    { typeof(DX.IntegerValue), (0, UInt16.MaxValue) },
    { typeof(DX.ByteValue), (0, Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt32Value), (0, UInt16.MaxValue) },
    { typeof(DX.UInt64Value), (0, UInt16.MaxValue) },
    { typeof(DX.StringValue), (0, UInt16.MaxValue) }
  };

  public static bool TestUInt16OpenXmlConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        var openXmlValue = UInt16OpenXmlConverter.ConvertToOpenXml(testValue, openXmlType);
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
        // Convert back to UInt16
        var convertedBackValue = UInt16OpenXmlConverter.ConvertFromOpenXml(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to UInt16 returned null for OpenXml value {openXmlValue}");
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
