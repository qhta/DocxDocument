namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema within the Schema Library.
/// </summary>
public partial interface XMLNamespace : InteropObject
{
  /// <summary>
  /// The uri.
  /// </summary>
  public string URI { get; }

  /// <summary>
  /// The xsltransforms.
  /// </summary>
  public XSLTransforms XSLTransforms { get; }
}
