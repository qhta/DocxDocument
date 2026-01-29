using System.Diagnostics;

using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.BooleanOpenXmlConverter"/> conversions between .NET boolean values and various Open XML boolean types.
///   Tests round-trip conversion for supported Open XML boolean types, including special cases for empty types.
/// </summary>
public static class TSBooleanConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for tree-state boolean value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.TrueFalseBlankValue),
  ];

  /// <summary>
  ///   Runs all BooleanOpenXmlConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestTSBooleanConversion with {type.Name} ");
      if (!TestTSBooleanOpenXmlConversion(type))
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
  ///   Tests round-trip conversion of boolean values to and from the specified Open XML boolean type.
  ///   Handles special cases for empty types where false is converted to null.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test boolean conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestTSBooleanOpenXmlConversion(Type openXmlType)
  {
    var trueInput = TSBoolean.True;
    var trueOpenXml = OpenXml.TSBooleanConverter.ConvertToOpenXml(trueInput, openXmlType);
    var trueOutput = OpenXml.TSBooleanConverter.ConvertFromOpenXml(trueOpenXml!);
    if (trueOutput != TSBoolean.True)
      return false;

    var falseInput = TSBoolean.False;
    var falseOpenXml = OpenXml.TSBooleanConverter.ConvertToOpenXml(falseInput, openXmlType);
    var falseOutput = OpenXml.TSBooleanConverter.ConvertFromOpenXml(falseOpenXml!);
    if ( falseOutput != TSBoolean.False)
      return false;

    var blankInput = TSBoolean.False;
    var blankOpenXml = OpenXml.TSBooleanConverter.ConvertToOpenXml(blankInput, openXmlType);
    var blankOutput = OpenXml.TSBooleanConverter.ConvertFromOpenXml(blankOpenXml!);
    if (blankOutput != TSBoolean.False)
      return false;

    return true;
  }
}