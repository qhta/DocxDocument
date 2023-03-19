using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;

/// <summary>
///   Defines the PtExtension Class.
/// </summary>
public class PtExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}