namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates which version of French to use when using the French language spelling checker dictionaries.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfrenchspeller?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFrenchSpeller))]
public enum FrenchSpeller
{
  /// <summary>
  /// Use both Post Reform and Pre-Reform French dictionaries when checking French language spelling.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFrenchSpeller.wdFrenchBoth))]
  Both = 0,
  /// <summary>
  /// Use only the Pre-Reform French dictionary when checking French language spelling.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFrenchSpeller.wdFrenchPreReform))]
  PreReform = 1,
  /// <summary>
  /// Use only the Post Reform French dictionary when checking French language spelling.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFrenchSpeller.wdFrenchPostReform))]
  PostReform = 2
}
