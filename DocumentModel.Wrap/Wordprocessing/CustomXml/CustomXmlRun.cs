namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XML markup allows the application of the XML elements defined in any schema syntax (XML Schema, NVDL, etc.) 
///   to be applied to the contents of a WordprocessingML document in two types of location: 
///   around a paragraph or set of paragraphs (at the block level); 
///   or around an arbitrary run or set of runs within a document (at the inline level) 
///   to provide semantics to that content within the context and structures defined by the associated schema definition.
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