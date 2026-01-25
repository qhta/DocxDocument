

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

namespace DocumentModel.BaseConverters.Test;

public static class SByteOpenXmlConverterTest
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
      Console.Write($"TestSByteOpenXmlConversion with {type.Name} ");
      if (!TestSByteOpenXmlConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }

    return testResult;
  }

  static readonly SByte[] testValues =
  [
    SByte.MinValue,
    -123,
    -1,
    0,
    1,
    123,
    SByte.MaxValue
  ];

  public static Dictionary<Type, (SByte min, SByte max)> typeRanges = new()
  {
    { typeof(DX.SByteValue), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.Int16Value), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.Int32Value), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.Int64Value), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.IntegerValue), (SByte.MinValue, SByte.MaxValue) },
    { typeof(DX.ByteValue), (0, SByte.MaxValue) },
    { typeof(DX.UInt16Value), (0, SByte.MaxValue) },
    { typeof(DX.UInt32Value), (0, SByte.MaxValue) },
    { typeof(DX.UInt64Value), (0, SByte.MaxValue) },
    { typeof(DX.StringValue), (SByte.MinValue, SByte.MaxValue) }
  };

  public static bool TestSByteOpenXmlConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        if (openXmlType == typeof(DX.Int16Value))
          Debug.Assert(true);

        // Convert to OpenXml
        var openXmlValue = SByteOpenXmlConverter.ConvertToOpenXml(testValue, openXmlType);
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
        // Convert back to SByte
        var convertedBackValue = SByteOpenXmlConverter.ConvertFromOpenXml(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back to SByte returned null for OpenXml value {openXmlValue}");
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
