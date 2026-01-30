using System.Diagnostics;

using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.BooleanOpenXmlConverter"/> conversions between .NET boolean values and various Open XML boolean types.
///   Tests round-trip conversion for supported Open XML boolean types, including special cases for empty types.
/// </summary>
public static class BooleanConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for boolean value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.OnOffValue),
    typeof(DXW.OnOffOnlyValues),
    typeof(DXW.Active), //DXW.OnOffType
    typeof(DXO10W.ConflictMode), //DXO10W.OnOffType
    typeof(DXO13W.DefaultCollapsed), //DXO13W.OnOffType
    typeof(DXM.Alignment), //DXM.OnOffType
    typeof(DXW.AutoRedefine), //DXW.OnOffOnlyType
    typeof(DXO10W.OnOffValues),
    typeof(DX.BooleanValue),
    typeof(DXM.BooleanValues),
    typeof(DX.TrueFalseValue),
    typeof(DXVS.Visible),
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
      Console.Write($"TestBooleanConversion with {type.Name} ");
      if (!TestBoolConversion(type))
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
  public static bool TestBoolConversion(Type openXmlType)
  {
    bool trueInput = true;
    var trueOpenXml = OpenXml.BooleanConverter.ConvertTo(trueInput, openXmlType);
    var trueOutput = OpenXml.BooleanConverter.ConvertFrom(trueOpenXml!);
    if (trueOutput != true)
      return false;

    bool falseInput = false;
    var falseOpenXml = OpenXml.BooleanConverter.ConvertTo(falseInput, openXmlType);
    var falseOutput = OpenXml.BooleanConverter.ConvertFrom(falseOpenXml!);
    if (falseOutput != false)
      return false;

    return true;
  }
}