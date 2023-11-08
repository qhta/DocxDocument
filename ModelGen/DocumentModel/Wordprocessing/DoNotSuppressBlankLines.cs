namespace DocumentModel.Wordprocessing;


/// <summary>
///   Remove Blank Lines from Merged Documents.
/// </summary>
public partial class DoNotSuppressBlankLines: ModelElement<DXW.DoNotSuppressBlankLines>
{
  public DoNotSuppressBlankLines(): base(){ }
  
  public DoNotSuppressBlankLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotSuppressBlankLines(DXW.DoNotSuppressBlankLines openXmlElement): base(openXmlElement) { }
  
}
