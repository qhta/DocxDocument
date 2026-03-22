namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
public enum XlChartGallery
{
  /// <summary>
  /// The built-in gallery.
  /// </summary>
  xlBuiltIn = unchecked((int)21),
  /// <summary>
  /// The user-defined gallery.
  /// </summary>
  xlUserDefined = unchecked((int)22),
  /// <summary>
  /// Either of the galleries.
  /// </summary>
  xlAnyGallery = unchecked((int)23)
}
