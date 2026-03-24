namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum XlOrientation
{
  /// <summary>
  /// Specifies the text orientation.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// Specifies the text orientation.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// Specifies the text orientation.
  /// </summary>
  Vertical = -4166,
  /// <summary>
  /// Specifies the text orientation.
  /// </summary>
  Horizontal = -4128
}
