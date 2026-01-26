

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

using DXW = DocumentFormat.OpenXml.Wordprocessing;

using DMW = DocumentModel.Wordprocessing.Test;

namespace DocumentModel.BaseConverters.Test;

public static class OpenXmlSimpleValueConverterTest
{


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

  private static bool TestStringValueConversion()
  {
    const string input = "SampleText";
    var openXml = OpenXmlSimpleValueConverter.ConvertToOpenXml(input, typeof(DX.StringValue)) as DX.StringValue;
    if (openXml == null || openXml.Value != input)
      return false;

    var roundTrip = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXml, typeof(string));
    return roundTrip is string str && str == input;
  }

  private static bool TestEnumValueConversion()
  {
    var input = DMW.UnderlineKind.WavyDouble;
    var openXml = OpenXmlSimpleValueConverter.ConvertToOpenXml(input, typeof(DX.EnumValue<DXW.UnderlineValues>)) as DX.EnumValue<DXW.UnderlineValues>;
    if (openXml == null || openXml.Value != DXW.UnderlineValues.WavyDouble)
      return false;

    var roundTrip = OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXml, typeof(DMW.UnderlineKind));
    return roundTrip is DMW.UnderlineKind enumResult && enumResult == input;
  }

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