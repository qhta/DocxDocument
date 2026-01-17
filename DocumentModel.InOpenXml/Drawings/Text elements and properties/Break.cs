namespace DocumentModel.Drawings;

/// <summary>
/// Represents a text line break within a drawing, optionally including run properties for the break.
/// </summary>
public class Break: ModelElement<DXW.Break>
{
  /// <summary>
  /// Text run properties applied to the break.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}