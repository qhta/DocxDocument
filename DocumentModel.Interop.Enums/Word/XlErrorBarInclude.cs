namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which error-bar parts to include.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlerrorbarinclude?view=office-pia` for Office interop details.
/// </remarks>
public enum XlErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  Both = 1,
  /// <summary>
  /// Only positive error range.
  /// </summary>
  PlusValues = 2,
  /// <summary>
  /// Only negative error range.
  /// </summary>
  MinusValues = 3,
  /// <summary>
  /// Specifies which error-bar parts to include.
  /// </summary>
  None = -4142
}
