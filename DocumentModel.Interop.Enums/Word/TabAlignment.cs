namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTabAlignment")]
public enum TabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabLeft")]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabRight")]
  Right = 2,
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabDecimal")]
  Decimal = 3,
  /// <summary>
  /// Bar aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabBar")]
  Bar = 4,
  /// <summary>
  /// List aligned.
  /// </summary>
  [InteropEnumValue("wdAlignTabList")]
  List = 6
}
