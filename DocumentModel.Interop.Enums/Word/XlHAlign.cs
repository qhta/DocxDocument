namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
public enum HAlign
{
  /// <summary>
  /// Align according to data type.
  /// </summary>
  General = 1,
  /// <summary>
  /// Fill.
  /// </summary>
  Fill = 5,
  /// <summary>
  /// Center across selection.
  /// </summary>
  CenterAcrossSelection = 7,
  /// <summary>
  /// Right.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Left.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  Justify = -4130,
  /// <summary>
  /// Distribute.
  /// </summary>
  Distributed = -4117,
  /// <summary>
  /// Center.
  /// </summary>
  Center = -4108
}
