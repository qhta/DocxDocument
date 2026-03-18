namespace DocumentModel.Interop;

public partial interface XMLNamespace
{
  /// <summary>
  /// Gets the location of the XML namespace.
  /// </summary>
  /// <param name="AllUsers">true to return the location for all users; otherwise, false.</param>
  /// <returns>The location as a string.</returns>
  public string Location(bool AllUsers);

  /// <summary>
  /// Gets the default XSL transform for the XML namespace.
  /// </summary>
  /// <param name="AllUsers">true to return the transform for all users; otherwise, false.</param>
  /// <returns>The default <see cref="XSLTransform"/> object.</returns>
  public XSLTransform DefaultTransform(bool AllUsers);
}
