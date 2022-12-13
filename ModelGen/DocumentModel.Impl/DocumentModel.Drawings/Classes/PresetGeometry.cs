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
  
  public PresetGeometryImpl(): base() {}
  
  public PresetGeometryImpl(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preset Shape
  /// </summary>
  public DocumentModel.Drawings.ShapeKind? Preset
  {
    get => (DocumentModel.Drawings.ShapeKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.ShapeTypeValues?)value;
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
