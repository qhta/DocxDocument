namespace DocumentModel.Drawings;

/// <summary>
/// 3D floor formatting.
/// </summary>
public class Floor2Impl: DocumentModel.Drawings.SurfaceTypeImpl, Floor2
{
  public new DocumentFormat.OpenXml.Drawing.Charts.Floor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Floor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Byte? Thickness
  {
    get;
    set;
  }
  
  public override ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  public override PictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  public override ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
