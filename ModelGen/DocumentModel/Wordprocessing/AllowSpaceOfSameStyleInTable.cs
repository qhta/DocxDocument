namespace DocumentModel.Wordprocessing;


/// <summary>
///   Allow Contextual Spacing of Paragraphs in Tables.
/// </summary>
public partial class AllowSpaceOfSameStyleInTable: ModelElement<DXW.AllowSpaceOfSameStyleInTable>
{
  public AllowSpaceOfSameStyleInTable(): base(){ }
  
  public AllowSpaceOfSameStyleInTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AllowSpaceOfSameStyleInTable(DXW.AllowSpaceOfSameStyleInTable openXmlElement): base(openXmlElement) { }
  
}
