namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the font size which shall be applied to all noncomplex script characters in the contents of this run when displayed. The font sizes specified by this element’s val attribute are expressed as half-point values.
/// </summary>
public partial class FrameSize: ModelElement<DXW.FrameSize>
{
  public FrameSize(): base(){ }
  
  public FrameSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FrameSize(DXW.FrameSize openXmlElement): base(openXmlElement) { }
  
}
