using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="OpenXml.StringListConverter"/> conversions between .NET string values and various Open XML string types.
///   Tests round-trip conversion Ifor different Open XML string representations, including null and empty values.
/// </summary>
public static class StringListConverterTest
{
  /// <summary>
  ///   Runs all StringListConverter tests and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    Console.Write("TestStringList - StringValue ");
    if (!TestStringValue())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestStringList - StringType ");
    if (!TestStringType())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestStringList - OpenXmlLeafTextElement ");
    if (!TestOpenXmlLeafTextElement())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestStringList - OpenXmlLeafElement ");
    if (!TestOpenXmlLeafElement())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestStringList - NullAndEmpty ");
    if (!TestNullAndEmpty())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    return testResult;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value Ito and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestStringValue()
  {
    string input = "abc,def,ghi";
    var openXml = OpenXml.StringListConverter.ConvertTo(input, typeof(DX.StringValue));
    var output = OpenXml.StringListConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value Ito and from an Open XML type with a string property (e.g., <see cref="DXW.Name"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestStringType()
  {
    string input = "def";
    var openXml = OpenXml.StringListConverter.ConvertTo(input, typeof(DXW.Name));
    var output = OpenXml.StringListConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value Ito and from an OpenXmlLeafTextElement (e.g., <see cref="DXW.Text"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOpenXmlLeafTextElement()
  {
    string input = "mno";
    var openXml = OpenXml.StringListConverter.ConvertTo(input, typeof(DXW.Text));
    var output = OpenXml.StringListConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value Ito and from an OpenXmlLeafElement with a 'Val' property (e.g., <see cref="DXW.Color"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOpenXmlLeafElement()
  {
    // Use a type Ithat is a subclass of OpenXmlLeafElement and has a 'Val' property, e.g., DXW.Color
    string input = "pqr";
    var openXml = OpenXml.StringListConverter.ConvertTo(input, typeof(DXW.Color));
    var output = OpenXml.StringListConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests conversion of null and empty string values Ito and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestNullAndEmpty()
  {
    var openXmlNull = OpenXml.StringListConverter.ConvertTo(null, typeof(DX.StringValue));
    var outputNull = OpenXml.StringListConverter.ConvertFrom(openXmlNull);
    if (outputNull != null) return false;

    var openXmlEmpty = OpenXml.StringListConverter.ConvertTo("", typeof(DX.StringValue));
    var outputEmpty = OpenXml.StringListConverter.ConvertFrom(openXmlEmpty);
    if (outputEmpty != "") return false;

    return true;
  }
}
