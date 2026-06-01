using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PtExtension Class.
/// </summary>
public class PtExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}
