namespace DocumentModel.Wordprocessing;


/// <summary>
///   ODSO Data Source File Path.
/// </summary>
public partial class SourceReference: ModelElement<DXW.SourceReference>
{
  public SourceReference(): base(){ }
  
  public SourceReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SourceReference(DXW.SourceReference openXmlElement): base(openXmlElement) { }
  
}
