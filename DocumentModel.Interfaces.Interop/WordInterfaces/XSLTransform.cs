namespace DocumentModel.Interop;

/// <summary>
/// Represents a single registered Extensible Stylesheet Language Transformation (XSLT).
/// </summary>
public partial interface XSLTransform : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; }
}
