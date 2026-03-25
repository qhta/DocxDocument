namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathhorizaligntype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathHorizAlignType
{
  /// <summary>
  /// Centered.
  /// </summary>
  Center = 0,
  /// <summary>
  /// Left alignment.
  /// </summary>
  Left = 1,
  /// <summary>
  /// Right alignment.
  /// </summary>
  Right = 2
}
