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
  /// Specifies the text orientation for tick-mark labels.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// Specifies the text orientation for tick-mark labels.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// Specifies the text orientation for tick-mark labels.
  /// </summary>
  Vertical = -4166,
  /// <summary>
  /// Specifies the text orientation for tick-mark labels.
  /// </summary>
  Horizontal = -4128,
  /// <summary>
  /// Specifies the text orientation for tick-mark labels.
  /// </summary>
  Automatic = -4105
}
