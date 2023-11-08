namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Simplified Rules For Table Border Conflicts.
/// </summary>
public partial class UseSingleBorderForContiguousCells: ModelElement<DXW.UseSingleBorderForContiguousCells>
{
  public UseSingleBorderForContiguousCells(): base(){ }
  
  public UseSingleBorderForContiguousCells(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseSingleBorderForContiguousCells(DXW.UseSingleBorderForContiguousCells openXmlElement): base(openXmlElement) { }
  
}
