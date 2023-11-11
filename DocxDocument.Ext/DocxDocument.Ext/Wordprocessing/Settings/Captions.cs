namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the presence of information about captions in a given WordprocessingML document. 
/// This information is divided into two components:
/// <list type="bullet">
///   <item>The child elements Caption defines the format for a single type of caption to be automatically added to the document.</item>
///   <item>The child element AutoCaptions defines the types of objects to which a caption format shall automatically be applied.</item>
/// </list>
///  This information should be used to determine the captions which are automatically added to objects when they are inserted into a WordprocessingML document. [Note: This setting is typically ignored unless it is specified in an application's default template. end note]
/// </summary>
public partial class Captions: NamedElementCollection<DXW.Captions, DXW.Caption, DMW.Caption>
{
  public Captions(): base(){ }

  public Captions(DXW.Captions openXmlElement): base(openXmlElement) { }

}
