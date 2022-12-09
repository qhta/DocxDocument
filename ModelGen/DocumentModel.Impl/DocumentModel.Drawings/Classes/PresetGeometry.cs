namespace DocumentModel.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public class PresetGeometryImpl: ModelElementImpl, PresetGeometry
{
  public DocumentFormat.OpenXml.Drawing.PresetGeometry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PresetGeometry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Preset Shape
  /// </summary>
  public ShapeKind2? Preset
  {
    get => (ShapeKind2?)OpenXmlElement?.Preset?.Value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
