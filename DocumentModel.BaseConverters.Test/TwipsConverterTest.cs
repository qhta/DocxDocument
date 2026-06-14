using System.Diagnostics;

using DocumentModel.OpenXml;

using TwipsConverter = DocumentModel.OpenXml.TwipsConverter;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.TwipsConverter"/> conversions between .NET Twips values and various Open XML numeric types.
///   Tests round-trip conversion for supported Open XML numeric types, including range validation and exception handling.
/// </summary>
public static class TwipsConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported for Twips value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.IntegerValue),
    typeof(DX.StringValue)
  ];

  /// <summary>
  ///   Runs all TwipsConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestTwipsConversion with {type.Name} ");
      if (!TestTwipsConversion(type))
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
  ///   Test values used for Twips conversion tests, including boundary and typical values.
  /// </summary>
  static readonly Twips[] testValues =
  [
    Int64.MinValue,
    Int32.MinValue,
    -123456L,
    -1L,
    0L,
    1L,
    123456L,
    Int32.MaxValue,
    Int64.MaxValue
  ];
  /// <summary>
  ///   IDictionary mapping Open XML types to their valid Twips value ranges (min, max) for conversion tests.
  /// </summary>
  public static Dictionary<Type, (Twips min, Twips max)> typeRanges = new()
  {
    { typeof(DX.Int32Value), (Int32.MinValue, Int32.MaxValue) },
    { typeof(DX.Int64Value), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.IntegerValue), (Int64.MinValue, Int64.MaxValue) },
    { typeof(DX.StringValue), (Int64.MinValue, Int64.MaxValue) }
  };

  /// <summary>
  ///   Tests round-trip conversion of Twips values to and from the specified Open XML numeric type.
  ///   Validates correct conversion, range enforcement, and exception handling for out-of-range values.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test Twips conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestTwipsConversion(Type openXmlType)
  {
    foreach (var testValue in testValues)
    {
      try
      {
        // Convert to OpenXml
        var openXmlValue = TwipsConverter.ConvertTo(testValue, openXmlType);
        if (openXmlValue == null)
        {
          Console.WriteLine($"Conversion to OpenXml returned null for value {testValue}");
          return false;
        }
        if (openXmlValue.ToString()!=testValue.ToString())
        {
          Console.WriteLine($"Expected {testValue.ToString()} but got {openXmlValue.ToString()}");
          return false;
        }
        var (min, max) = typeRanges[openXmlType];
        if ((double)testValue < (double)min || (double)testValue > (double)max)
        {
          Console.WriteLine("Out-of-range value did not throw an exception. ");
          return false; // Expected exception for out-of-range value
        }

        // Convert back to Twips
        var convertedBackValue = TwipsConverter.ConvertFrom(openXmlValue);
        if (convertedBackValue is null)
        {
          Console.WriteLine($"Conversion back to Twips returned null for OpenXml value {openXmlValue}");
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
        if ((double)testValue < (double)min || (double)testValue > (double)max)
          return true; // Expected exception for out-of-range value

        Console.WriteLine(e.Message);
        return false;
      }
    }
    return true;
  }
}
