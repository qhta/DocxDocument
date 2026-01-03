using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the PtExtension interface.
/// </summary>
public interface PtExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}