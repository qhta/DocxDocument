namespace DocumentModel.Wordprocessing;


/// <summary>
///   Record Currently Displayed In Merged Document.
/// </summary>
public partial class ActiveRecord: ModelElement<DXW.ActiveRecord>
{
  public ActiveRecord(): base(){ }
  
  public ActiveRecord(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ActiveRecord(DXW.ActiveRecord openXmlElement): base(openXmlElement) { }
  
}
