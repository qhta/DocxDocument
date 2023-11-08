namespace DocumentModel.Wordprocessing;


/// <summary>
///   Restart Numbering Level Symbol.
/// </summary>
public partial class LevelRestart: ModelElement<DXW.LevelRestart>
{
  public LevelRestart(): base(){ }
  
  public LevelRestart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelRestart(DXW.LevelRestart openXmlElement): base(openXmlElement) { }
  
}
