namespace DocumentModel.Wordprocessing;

/// <summary>
///   This class does not exists in wordprocessing document. 
///   In OpenXml sections are represented by SectionProperties elements only.
///   Each document body has one SectionProperties element at the end. This element represents properties of the last section of the document.
///   Other SectionProperties are contained in paragraphs and represent the properties of just ended sections.
///   This class is introduced an additional level between body and its elements to clearly divide them to sections. 
/// </summary>
public class Section : ElementCollection<IBodyElement>, IBodyElement
{
   [XmlContentElement] public SectionProperties? Properties { get; set; }
}