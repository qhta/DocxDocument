namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTabAlignment))]
public enum TabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabLeft))]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabCenter))]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabRight))]
  Right = 2,
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabDecimal))]
  Decimal = 3,
  /// <summary>
  /// Bar aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabBar))]
  Bar = 4,
  /// <summary>
  /// List aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabList))]
  List = 6
}
