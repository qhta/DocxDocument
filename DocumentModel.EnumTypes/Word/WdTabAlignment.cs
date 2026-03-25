namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  Right = 2,
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  Decimal = 3,
  /// <summary>
  /// Bar aligned.
  /// </summary>
  Bar = 4,
  /// <summary>
  /// List aligned.
  /// </summary>
  List = 6
}
