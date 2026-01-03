namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Copyrights Class.
/// </summary>
public interface Copyrights: IModelElement
{
  public Collection<String>? CopyrightXsdstrings { get; set; }
}