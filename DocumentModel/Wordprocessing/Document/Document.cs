namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document.
/// </summary>
public partial class Document: ModelElement
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