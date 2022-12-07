namespace DocumentModel.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public class PresetGeometryImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PresetGeometry>, PresetGeometry
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public ShapeKind1? Preset
  {
    get => (ShapeKind1?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.ShapeTypeValues?)value;
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public AdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
}
