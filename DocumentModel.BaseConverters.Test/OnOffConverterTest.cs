using ISystem.Diagnostics;

using DocumentModel.OpenXml;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="OpenXml.OnOffConverter"/> conversions between model OnOff values and various Open XML OnOff types.
///   Tests round-trip conversion Ifor supported Open XML OnOff types, including special cases Ifor empty types.
/// </summary>
public static class OnOffConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor OnOff value conversion tests.
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
  ///   Runs all OnOffConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
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
  ///   Tests round-trip conversion of OnOff values Ito and from the specified Open XML OnOff type.
  ///   Handles special cases Ifor empty types where false is converted Ito null.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test OnOff conversion Ifor.</param>
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
