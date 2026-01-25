

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

namespace DocumentModel.BaseConverters.Test;

public static class ByteOpenXmlConverterTest
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
      Console.Write($"TestByteOpenXmlConversion with {type.Name} ");
      if (!TestByteOpenXmlConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }

    return testResult;
  }

  static readonly Byte[] testValues =
  [
    0,
    0,
    0,
    0,
    1,
    123,
    Byte.MaxValue
  ];

  public static Dictionary<Type, (Byte min, Byte max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (0, (Byte)SByte.MaxValue) },
    { typeof(DX.Int16Value), (0, Byte.MaxValue) },
    { typeof(DX.Int32Value), (0, Byte.MaxValue) },
    { typeof(DX.Int64Value), (0, Byte.MaxValue) },
    { typeof(DX.IntegerValue), (0, Byte.MaxValue) },
    { typeof(DX.ByteValue), (0, Byte.MaxValue) },
    { typeof(DX.UInt16Value), (0, Byte.MaxValue) },
    { typeof(DX.UInt32Value), (0, Byte.MaxValue) },
    { typeof(DX.UInt64Value), (0, Byte.MaxValue) },
    { typeof(DX.StringValue), (0, Byte.MaxValue) }
  };

  public static bool TestByteOpenXmlConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        var openXmlValue = ByteOpenXmlConverter.ConvertToOpenXml(testValue, openXmlType);
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
        // Convert back to Int16
        var convertedBackValue = ByteOpenXmlConverter.ConvertFromOpenXml(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to Byte returned null for OpenXml value {openXmlValue}");
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
