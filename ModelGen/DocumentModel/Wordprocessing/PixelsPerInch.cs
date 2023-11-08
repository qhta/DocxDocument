namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PixelsPerInch Class.
/// </summary>
public partial class PixelsPerInch: ModelElement<DXW.PixelsPerInch>
{
  public PixelsPerInch(): base(){ }
  
  public PixelsPerInch(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PixelsPerInch(DXW.PixelsPerInch openXmlElement): base(openXmlElement) { }
  
}
