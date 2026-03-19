namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.PtExtension))]
/// <summary>
/// Represents the Pt Extension.
/// </summary>
public class PtExtension : Extension<DXD.PtExtension>
{
  /// <summary>
  /// Non Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
}

