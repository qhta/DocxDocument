namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies where a paragraph should be relocated in relation to its current position.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelocate?view=office-pia` for Office interop details.
/// </remarks>
public enum Relocate
{
  /// <summary>
  /// Above the previous visible paragraph.
  /// </summary>
  Up = 0,
  /// <summary>
  /// Below the next visible paragraph.
  /// </summary>
  Down = 1
}
