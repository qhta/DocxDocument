namespace DocumentModel.Wordprocessing;

/// <summary>
///   Glossary Document Entry.
/// </summary>
public class DocPart
{
  /// <summary>
  ///   Glossary Document Entry Properties.
  /// </summary>
  public DocPartProperties? DocPartProperties { get; set; }

  /// <summary>
  ///   Contents of Glossary Document Entry.
  /// </summary>
  public DocPartBody? DocPartBody { get; set; }
}