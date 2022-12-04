namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public class LineSketchStyleProperties
{
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
  
  public OfficeArtExtensionList6? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
