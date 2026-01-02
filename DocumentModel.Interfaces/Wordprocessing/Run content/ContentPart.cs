namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies a reference to XML content in a format not defined by ECMA-376. 
///   This part allows the native use of other commonly used interchange formats, such as:  
///   <list type="bullet">
///    <item>
///     MathML (http://www.w3.org/TR/MathML2/) 
///    </item><item>
///     SMIL (http://www.w3.org/TR/REC-smil/) 
///    </item><item>
///     SVG (http://www.w3.org/TR/SVG11/) 
///    </item>
///   </list>
///   The relationship type of the explicit relationship specified by this element shall be  
///   http://purl.oclc.org/ooxml/officeDocument/relationships/customXml and have a TargetMode attribute value of Internal. 
///   If an application cannot process content of the content type specified by the targeted part, 
///   then it should continue to process the file. If possible, it should also provide some indication that unknown content was not imported. 
/// </summary>
public class ContentPart: ModelElement, IRunContent, DMM.IMathArgumentContent
{
  /// <summary>
  ///   Specifies the relationship ID to a specified part.
  /// </summary>
  public string? Id { get; set; }
}