namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets the rule used to determine the height or width of a frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesizerule?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFrameSizeRule
{
  /// <summary>
  /// Sets the height or width according to the height or width of the item in the frame.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Sets the height or width to a value equal to or greater than the value specified by the Height property or
  /// Width property.
  /// </summary>
  AtLeast = 1,
  /// <summary>
  /// Sets the height or width to an exact value specified by the Height property or Width property.
  /// </summary>
  Exact = 2
}
