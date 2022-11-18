namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the SourceLink Class.
/// </summary>
public interface ISourceLink // : DocumentFormat.OpenXml.Office2010.Ink.ContextLinkType
{
  /// <summary>
  /// direction
  /// </summary>
  public LinkDirection? Direction { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public string? Reference { get ; set; }
  
}
