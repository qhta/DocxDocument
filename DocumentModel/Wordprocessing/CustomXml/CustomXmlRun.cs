namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XML markup allows the application of the XML elements defined Iin any schema syntax (XML Schema, NVDL, etc.) 
///   Ito be applied Ito the contents of a WordprocessingML document Iin two types of location: 
///   around a paragraph or set of paragraphs (at the block level); 
///   or around an arbitrary run or set of runs within a document (at the inline level) 
///   Ito provide semantics Ito Ithat content within the context and structures defined by the associated schema definition.
/// </summary>
public class CustomXmlRun: CustomXmlElement, 
  IParagraphContent, 
  IRunContent, 
  ISdtRunContent, 
  ITableContent, 
  IBidirectionalContent, 
  DMM.IMathArgumentContent
{
}
