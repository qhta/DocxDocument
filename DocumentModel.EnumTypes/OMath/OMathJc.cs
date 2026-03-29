namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathjc?view=office-pia` for Office interop details.
/// </remarks>
public enum OMathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  CenterGroup = 1,
  /// <summary>
  /// Center.
  /// </summary>
  Center = 2,
  /// <summary>
  /// Left.
  /// </summary>
  Left = 3,
  /// <summary>
  /// Right.
  /// </summary>
  Right = 4,
  /// <summary>
  /// Inline.
  /// </summary>
  Inline = 7
}
