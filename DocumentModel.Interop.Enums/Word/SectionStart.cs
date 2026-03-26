namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectionstart?view=office-pia` for Office interop details.
/// </remarks>
public enum SectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  Continuous = 0,
  /// <summary>
  /// New column section break.
  /// </summary>
  NewColumn = 1,
  /// <summary>
  /// New page section break.
  /// </summary>
  NewPage = 2,
  /// <summary>
  /// Even pages section break.
  /// </summary>
  EvenPage = 3,
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  OddPage = 4
}
