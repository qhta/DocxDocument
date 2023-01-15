namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document.
/// </summary>
public partial class Document
{
  /// <summary>
  ///   conformance
  /// </summary>
  public DocumentConformance? Conformance { get; set; }

  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   Body.
  /// </summary>
  public Body? Body { get; set; }
}