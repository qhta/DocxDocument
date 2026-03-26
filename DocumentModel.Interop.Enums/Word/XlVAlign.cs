namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
public enum VAlign
{
  /// <summary>
  /// Top
  /// </summary>
  Top = -4160,
  /// <summary>
  /// Justify
  /// </summary>
  Justify = -4130,
  /// <summary>
  /// Distributed
  /// </summary>
  Distributed = -4117,
  /// <summary>
  /// Center
  /// </summary>
  Center = -4108,
  /// <summary>
  /// Bottom
  /// </summary>
  Bottom = -4107
}
