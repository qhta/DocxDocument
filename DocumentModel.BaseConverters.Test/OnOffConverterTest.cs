using System.Diagnostics;

using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.OnOffConverter"/> conversions between model OnOff values and various Open XML OnOff types.
///   Tests round-trip conversion for supported Open XML OnOff types, including special cases for empty types.
/// </summary>
public static class OnOffConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for OnOff value conversion tests.
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
    typeof(DX.OnOffValue),
    typeof(DXM.BooleanValues),
    typeof(DX.TrueFalseValue),
    typeof(DXVS.Visible),
  ];

  /// <summary>
  ///   Runs all OnOffConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestOnOffConversion with {type.Name} ");
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
  ///   Tests round-trip conversion of OnOff values to and from the specified Open XML OnOff type.
  ///   Handles special cases for empty types where false is converted to null.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test OnOff conversion for.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestBoolConversion(Type openXmlType)
  {
    OnOff trueInput = OnOff.On;
    var trueOpenXml = OpenXml.OnOffConverter.ConvertTo(trueInput, openXmlType);
    var trueOutput = OpenXml.OnOffConverter.ConvertFrom(trueOpenXml!);
    if (trueOutput != OnOff.On)
      return false;

    OnOff falseInput = OnOff.Off;
    var falseOpenXml = OpenXml.OnOffConverter.ConvertTo(falseInput, openXmlType);
    var falseOutput = OpenXml.OnOffConverter.ConvertFrom(falseOpenXml!);
    if (falseOutput != OnOff.Off)
      return false;

    return true;
  }
}