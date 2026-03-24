namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the point on the specified axis where the other axis crosses.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxiscrosses?view=office-pia` for Office interop details.
/// </remarks>
public enum XlAxisCrosses
{
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Maximum = 2,
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Minimum = 4,
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Custom = -4114,
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Automatic = -4105
}
