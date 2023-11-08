namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the &quot;focus&quot; rectangle for the center shade, specified relative to the fill tile rectangle.  The center shade fills the entire tile except the margins specified by each attribute.
/// </summary>
public partial class FillToRectangle: ModelElement<DXD.FillToRectangle>
{
  public FillToRectangle(): base(){ }
  
  public FillToRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillToRectangle(DXD.FillToRectangle openXmlElement): base(openXmlElement) { }
  
}
