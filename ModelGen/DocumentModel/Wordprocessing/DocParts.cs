namespace DocumentModel.Wordprocessing;


/// <summary>
///   List of Glossary Document Entries.
/// </summary>
public partial class DocParts: ModelElement<DXW.DocParts>
{
  public DocParts(): base(){ }
  
  public DocParts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocParts(DXW.DocParts openXmlElement): base(openXmlElement) { }
  
}
