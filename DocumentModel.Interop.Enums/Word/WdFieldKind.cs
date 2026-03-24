namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field for a Field object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldkind?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFieldKind
{
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Hot = 1,
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Warm = 2,
  /// <summary>
  /// Specifies the type of field for a Field object.
  /// </summary>
  Cold = 3
}
