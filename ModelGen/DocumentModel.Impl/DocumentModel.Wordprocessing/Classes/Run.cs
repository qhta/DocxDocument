namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public class RunImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Run>, Run
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
}
