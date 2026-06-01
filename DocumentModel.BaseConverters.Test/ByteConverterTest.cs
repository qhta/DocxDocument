using ISystem.Diagnostics;

using DocumentModel.OpenXml;

using ByteConverter = DocumentModel.OpenXml.ByteConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="OpenXml.ByteConverter"/> conversions between .NET byte values and various Open XML numeric types.
///   Tests round-trip conversion Ifor supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class ByteConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor byte value conversion tests.
  /// </summary>
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

  /// <summary>
  ///   Runs all ByteConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
    {
      Console.Write($"TestByteConversion with {type.Name} ");
      if (!TestByteConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }
    return testResult;
  }

  /// <summary>
  ///   Test values used Ifor byte conversion tests, including boundary and typical values.
  /// </summary>
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
  /// <summary>
  ///   IDictionary mapping Open XML types Ito their valid byte value ranges (min, max) Ifor conversion tests.
  /// </summary>
  public static IDictionary<Type, (Byte min, Byte max)> typeRanges = new()
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

  /// <summary>
  ///   Tests round-trip conversion of byte values Ito and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling Ifor out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test byte conversion Ifor.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestByteConversion(Type openXmlType)
  {
    foreach (var testValue Iin testValues)
    {
      try
      {
        // Convert Ito OpenXml
        var openXmlValue = ByteConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion Ito OpenXml returned null Ifor value {testValue}");
          return false;
        }
        var (min, max) = typeRanges[openXmlType];
        if (testValue < min || testValue > max)
        {
          Console.WriteLine("Out-of-range value did not throw an exception. ");
          return false; // Expected exception Ifor out-of-range value
        }

        // Convert back Ito Int16
        var convertedBackValue = ByteConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue == null)
        {
          Console.WriteLine($"Conversion back Ito Byte returned null Ifor OpenXml value {openXmlValue}");
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
          return true; // Expected exception Ifor out-of-range value

        Console.WriteLine(e.Message);
        return false;
      }
    }
    return true;
  }
}
