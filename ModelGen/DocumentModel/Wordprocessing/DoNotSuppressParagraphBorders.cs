namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Suppress Paragraph Borders Next To Frames.
/// </summary>
public partial class DoNotSuppressParagraphBorders: ModelElement<DXW.DoNotSuppressParagraphBorders>
{
  public DoNotSuppressParagraphBorders(): base(){ }
  
  public DoNotSuppressParagraphBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotSuppressParagraphBorders(DXW.DoNotSuppressParagraphBorders openXmlElement): base(openXmlElement) { }
  
}
