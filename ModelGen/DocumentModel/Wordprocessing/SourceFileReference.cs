namespace DocumentModel.Wordprocessing;


/// <summary>
///   Source File for Frame.
/// </summary>
public partial class SourceFileReference: ModelElement<DXW.SourceFileReference>
{
  public SourceFileReference(): base(){ }
  
  public SourceFileReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SourceFileReference(DXW.SourceFileReference openXmlElement): base(openXmlElement) { }
  
}
