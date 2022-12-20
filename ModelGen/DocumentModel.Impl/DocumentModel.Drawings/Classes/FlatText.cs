namespace DocumentModel.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public partial class FlatTextImpl: ModelElementImpl, FlatText
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.FlatText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FlatText?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FlatTextImpl(): base() {}
  
  public FlatTextImpl(DocumentFormat.OpenXml.Drawing.FlatText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public Int64? Z
  {
    get => (System.Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
}
