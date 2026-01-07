using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtension interface.
/// </summary>
public interface PtExtension: Extension
{
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}