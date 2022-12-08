namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public class LineSketchStylePropertiesImpl: ModelElementImpl, LineSketchStyleProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd
  {
    get;
    set;
  }
  
  public CustomGeometry? CustomGeometry
  {
    get;
    set;
  }
  
  public PresetGeometry? PresetGeometry
  {
    get;
    set;
  }
  
  public LineSketchTypeProperties? LineSketchTypeProperties
  {
    get;
    set;
  }
  
  public String? LineSketchSeed
  {
    get;
    set;
  }
  
  public OfficeArtExtensionList8? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
