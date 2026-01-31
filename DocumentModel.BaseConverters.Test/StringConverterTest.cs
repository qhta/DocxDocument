using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.StringConverter"/> conversions between .NET string values and various Open XML string types.
///   Tests round-trip conversion for different Open XML string representations, including null and empty values.
/// </summary>
public static class StringConverterTest
{
  /// <summary>
  ///   Runs all StringConverter tests and reports results to the console.
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
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DX.StringValue));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a string property (e.g., <see cref="DXW.Name"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestStringType()
  {
    string input = "def";
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DXW.Name));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a 255-character string property (e.g., <see cref="DXW.FrameName"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestString255Type()
  {
    string input = "ghi";
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DXW.FrameName));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an Open XML type with a 253-character string property (e.g., <see cref="DXW.Aliases"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestString253Type()
  {
    string input = "jkl";
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DXW.Aliases));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests round-trip conversion of a string value to and from an OpenXmlLeafTextElement (e.g., <see cref="DXW.Text"/>).
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOpenXmlLeafTextElement()
  {
    string input = "mno";
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DXW.Text));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
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
    var openXml = OpenXml.StringConverter.ConvertTo(input, typeof(DXW.Color));
    var output = OpenXml.StringConverter.ConvertFrom(openXml);
    return output == input;
  }

  /// <summary>
  ///   Tests conversion of null and empty string values to and from <see cref="DX.StringValue"/>.
  /// </summary>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestNullAndEmpty()
  {
    var openXmlNull = OpenXml.StringConverter.ConvertTo(null, typeof(DX.StringValue));
    var outputNull = OpenXml.StringConverter.ConvertFrom(openXmlNull);
    if (outputNull != null) return false;

    var openXmlEmpty = OpenXml.StringConverter.ConvertTo("", typeof(DX.StringValue));
    var outputEmpty = OpenXml.StringConverter.ConvertFrom(openXmlEmpty);
    if (outputEmpty != "") return false;

    return true;
  }
}