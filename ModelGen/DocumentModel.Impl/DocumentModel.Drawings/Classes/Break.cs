namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public class BreakImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Break>, Break
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
}
