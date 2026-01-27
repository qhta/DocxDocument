using System.Diagnostics;

using DocumentModel.OpenXml;

using DMW = DocumentModel.Wordprocessing.Test;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXmlSimpleValueConverter"/> conversions between .NET types and Open XML value types.
///   Tests round-trip conversion for boolean, string, enum, and integer values.
/// </summary>
public static class OpenXmlSimpleValueConverterTest
{
  /// <summary>
  ///   Runs all OpenXmlSimpleValueConverter tests and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    Console.Write("OpenXmlSimpleValueConverterTest TestBoolValueConversion ");
    if (TestBoolValueConversion())
    {
      Console.WriteLine("passed.");
    }
    else
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    Console.Write("OpenXmlSimpleValueConverterTest TestStringValueConversion ");
    if (TestStringValueConversion())
    {
      Console.WriteLine("passed.");
    }
    else
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    Console.Write("OpenXmlSimpleValueConverterTest TestEnumValueConversion ");
    if (TestEnumValueConversion())
    {
      Console.WriteLine("passed.");
    }
    else
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    Console.Write("OpenXmlSimpleValueConverterTest TestIntValueConversion ");
    if (TestIntValueConversion())
    {
      Console.WriteLine("passed.");
    }
    else
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    return testResult;
  }

  /// <summary>
  ///   Tests round-trip conversion of boolean values to and from <see cref="DX.BooleanValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  private static bool TestBoolValueConversion()
  {
    const bool inputTrue = true;
    var openXmlTrue = OpenXmlSimpleValueConverter.ConvertToOpenXml(inputTrue, typeof(DX.BooleanValue));
    if (openXmlTrue is not DX.BooleanValue booleanValueTrue || booleanValueTrue.Value != inputTrue)
      return false;

    var roundTripTrue = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXmlTrue, typeof(bool));
    if (roundTripTrue is not bool trueResult || trueResult != inputTrue)
      return false;

    const bool inputFalse = false;
    var openXmlFalse = OpenXmlSimpleValueConverter.ConvertToOpenXml(inputFalse, typeof(DX.BooleanValue)) as DX.BooleanValue;
    if (openXmlFalse is not DX.BooleanValue booleanValueFalse || booleanValueFalse.Value != inputFalse)
      return false;

    var roundTripFalse = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXmlFalse, typeof(bool));
    return roundTripFalse is bool falseResult && falseResult == inputFalse;
  }

  /// <summary>
  ///   Tests round-trip conversion of string values to and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  private static bool TestStringValueConversion()
  {
    const string input = "SampleText";
    var openXml = OpenXmlSimpleValueConverter.ConvertToOpenXml(input, typeof(DX.StringValue)) as DX.StringValue;
    if (openXml == null || openXml.Value != input)
      return false;

    var roundTrip = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXml, typeof(string));
    return roundTrip is string str && str == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of enum values to and from <see cref="DX.EnumValue{T}"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  private static bool TestEnumValueConversion()
  {
    var input = DMW.UnderlineKind.WavyDouble;
    var openXml = OpenXmlSimpleValueConverter.ConvertToOpenXml(input, typeof(DX.EnumValue<DXW.UnderlineValues>)) as DX.EnumValue<DXW.UnderlineValues>;
    if (openXml == null || openXml.Value != DXW.UnderlineValues.WavyDouble)
      return false;

    var roundTrip = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXml, typeof(DMW.UnderlineKind));
    return roundTrip is DMW.UnderlineKind enumResult && enumResult == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of integer values to and from <see cref="DX.Int32Value"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  private static bool TestIntValueConversion()
  {
    const int input = 12345;
    var openXml = OpenXmlSimpleValueConverter.ConvertToOpenXml(input, typeof(DX.Int32Value)) as DX.Int32Value;
    if (openXml == null || openXml.Value != input)
      return false;

    var roundTrip = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXml, typeof(int));
    return roundTrip is int value && value == input;
  }
}