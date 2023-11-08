namespace DocumentModel.Wordprocessing;


/// <summary>
///   Inserted Run Content.
/// </summary>
public partial class InsertedRun: ModelElement<DXW.InsertedRun>
{
  public InsertedRun(): base(){ }
  
  public InsertedRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InsertedRun(DXW.InsertedRun openXmlElement): base(openXmlElement) { }
  
}
