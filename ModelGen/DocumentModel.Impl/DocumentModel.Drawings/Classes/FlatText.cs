namespace DocumentModel.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public class FlatTextImpl: ModelElementImpl, FlatText
{
  public DocumentFormat.OpenXml.Drawing.FlatText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FlatText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public Int64? Z
  {
    get => (Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
}
