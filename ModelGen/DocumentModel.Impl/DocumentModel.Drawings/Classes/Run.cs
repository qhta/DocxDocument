namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public class RunImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Run>, Run
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
}
