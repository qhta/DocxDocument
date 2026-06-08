namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Glossary IDocument Entry.
/// </summary>
public class DocPart: ModelElement
{
  /// <summary>
  ///   Glossary IDocument Entry Properties.
  /// </summary>
  public DocPartProperties? DocPartProperties { get; set; }

  /// <summary>
  ///   Contents of Glossary IDocument Entry.
  /// </summary>
  public DocPartBody? DocPartBody { get; set; }
}
