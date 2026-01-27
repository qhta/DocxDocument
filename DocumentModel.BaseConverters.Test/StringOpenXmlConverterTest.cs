using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="StringOpenXmlConverter"/> conversions between .NET string values and various Open XML string types.
///   Tests round-trip conversion for different Open XML string representations, including null and empty values.
/// </summary>
public static class StringOpenXmlConverterTest
{
  /// <summary>
  ///   Runs all StringOpenXmlConverter tests and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    Console.Write("TestStringValue ");
    if (!TestStringValue())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestStringType ");
    if (!TestStringType())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestString255Type ");
    if (!TestString255Type())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestString253Type ");
    if (!TestString253Type())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestOpenXmlLeafTextElement ");
    if (!TestOpenXmlLeafTextElement())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestOpenXmlLeafElement ");
    if (!TestOpenXmlLeafElement())
    {
      Console.WriteLine("failed.");
      testResult = false;
    }
    else
      Console.WriteLine("passed.");
    Console.Write("TestNullAndEmpty ");
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
  ///   Tests round-trip conversion of a string value to and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestStringValue()
  {
    string input = "abc";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DX.StringValue));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a string property (e.g., <see cref="DXW.Name"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestStringType()
  {
    string input = "def";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Name));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a 255-character string property (e.g., <see cref="DXW.FrameName"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestString255Type()
  {
    string input = "ghi";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.FrameName));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a 253-character string property (e.g., <see cref="DXW.Aliases"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestString253Type()
  {
    string input = "jkl";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Aliases));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an OpenXmlLeafTextElement (e.g., <see cref="DXW.Text"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOpenXmlLeafTextElement()
  {
    string input = "mno";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Text));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an OpenXmlLeafElement with a 'Val' property (e.g., <see cref="DXW.Color"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOpenXmlLeafElement()
  {
    // Use a type that is a subclass of OpenXmlLeafElement and has a 'Val' property, e.g., DXW.Color
    string input = "pqr";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Color));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests conversion of null and empty string values to and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestNullAndEmpty()
  {
    var openXmlNull = StringOpenXmlConverter.ConvertToOpenXml(null, typeof(DX.StringValue));
    var outputNull = StringOpenXmlConverter.ConvertFromOpenXml(openXmlNull);
    if (outputNull != null) return false;

    var openXmlEmpty = StringOpenXmlConverter.ConvertToOpenXml("", typeof(DX.StringValue));
    var outputEmpty = StringOpenXmlConverter.ConvertFromOpenXml(openXmlEmpty);
    if (outputEmpty != "") return false;

    return true;
  }
}