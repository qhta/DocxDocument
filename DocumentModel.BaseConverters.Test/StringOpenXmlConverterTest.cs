
using DocumentModel.OpenXml;

using DX =DocumentFormat.OpenXml;
using DXW = DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.BaseConverters.Test;

public static class StringOpenXmlConverterTest
{
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

  public static bool TestStringValue()
  {
    string input = "abc";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DX.StringValue));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  public static bool TestStringType()
  {
    string input = "def";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Name));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  public static bool TestString255Type()
  {
    string input = "ghi";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.FrameName));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  public static bool TestString253Type()
  {
    string input = "jkl";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Aliases));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  public static bool TestOpenXmlLeafTextElement()
  {
    string input = "mno";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Text));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

  public static bool TestOpenXmlLeafElement()
  {
    // Use a type that is a subclass of OpenXmlLeafElement and has a 'Val' property, e.g., DXW.Color
    string input = "pqr";
    var openXml = StringOpenXmlConverter.ConvertToOpenXml(input, typeof(DXW.Color));
    var output = StringOpenXmlConverter.ConvertFromOpenXml(openXml);
    return output == input;
  }

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