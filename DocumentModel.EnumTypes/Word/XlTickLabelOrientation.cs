namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTickLabelOrientation
{
  /// <summary>
  /// Text runs up.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// Text runs down.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  Vertical = -4166,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  Horizontal = -4128,
  /// <summary>
  /// Text orientation set by Word.
  /// </summary>
  Automatic = -4105
}
