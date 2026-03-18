namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="OpenXml.BooleanConverter"/> conversions between .NET boolean values and various Open XML boolean types.
///   Tests round-trip conversion for supported Open XML boolean types, including special cases for empty types.
/// </summary>
public static class OnOffToggleConverterTest
{
  /// <summary>
  ///   List of Open XML types supported for tree-state boolean value conversion tests.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.TrueFalseBlankValue),
  ];

  /// <summary>
  ///   Runs all BooleanConverter tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var type in SupportedTypes)
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
  ///   Tests round-trip conversion of boolean values to and from the specified Open XML boolean type.
  ///   Handles special cases for empty types where false is converted to null.
  /// </summary>
  /// <param name="openXmlType">The Open XML type to test boolean conversion for.</param>
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