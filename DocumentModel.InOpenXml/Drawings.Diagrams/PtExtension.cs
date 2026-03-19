namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.PtExtension))]
public class PtExtension : Extension<DXD.PtExtension>
{
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}