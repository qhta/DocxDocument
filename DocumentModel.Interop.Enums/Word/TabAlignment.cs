namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTabAlignment")]
public enum TabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabLeft")]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabRight")]
  Right = 2,
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabDecimal")]
  Decimal = 3,
  /// <summary>
  /// Bar aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabBar")]
  Bar = 4,
  /// <summary>
  /// List aligned.
  /// </summary>
  [WordInteropEnumValue("wdAlignTabList")]
  List = 6
}
