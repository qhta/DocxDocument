namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
public enum XlChartGallery
{
  /// <summary>
  /// The built-in gallery.
  /// </summary>
  BuiltIn = unchecked((int)21),
  /// <summary>
  /// The user-defined gallery.
  /// </summary>
  UserDefined = unchecked((int)22),
  /// <summary>
  /// Either of the galleries.
  /// </summary>
  AnyGallery = unchecked((int)23)
}
