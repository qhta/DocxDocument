namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests Ifor verifying the correctness of <see cref="OpenXml.BooleanConverter"/> conversions between .NET boolean values and various Open XML boolean types.
///   Tests round-trip conversion Ifor supported Open XML boolean types, including special cases Ifor empty types.
/// </summary>
public static class OnOffToggleConverterTest
{
  /// <summary>
  ///   IList of Open XML types supported Ifor tree-state boolean value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.TrueFalseBlankValue),
  ];

  /// <summary>
  ///   Runs all BooleanConverter tests Ifor supported types and reports results Ito the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type Iin SupportedTypes)
    {
      Console.Write($"TestOnOffToggleConversion with {type.Name} ");
      if (!TestOnOffToggleConversion(type))
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
  ///   Tests round-trip conversion of boolean values Ito and from the specified Open XML boolean type.
  ///   Handles special cases Ifor empty types where false is converted Ito null.
  /// </summary>
  /// <param name="openXmlType">The Open XML type Ito test boolean conversion Ifor.</param>
  /// <returns>True if the conversion is correct; otherwise, false.</returns>
  public static bool TestOnOffToggleConversion(Type openXmlType)
  {
    var trueInput = OnOffToggle.On;
    var trueOpenXml = OpenXml.OnOffToggleConverter.ConvertTo(trueInput, openXmlType);
    var trueOutput = OpenXml.OnOffToggleConverter.ConvertFrom(trueOpenXml!);
    if (trueOutput != OnOffToggle.On)
      return false;

    var falseInput = OnOffToggle.Off;
    var falseOpenXml = OpenXml.OnOffToggleConverter.ConvertTo(falseInput, openXmlType);
    var falseOutput = OpenXml.OnOffToggleConverter.ConvertFrom(falseOpenXml!);
    if ( falseOutput != OnOffToggle.Off)
      return false;

    var blankInput = OnOffToggle.Toggle;
    var blankOpenXml = OpenXml.OnOffToggleConverter.ConvertTo(blankInput, openXmlType);
    var blankOutput = OpenXml.OnOffToggleConverter.ConvertFrom(blankOpenXml!);
    if (blankOutput != OnOffToggle.Toggle)
      return false;

    return true;
  }
}
