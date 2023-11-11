namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies that one or more types of objects, when inserted into a WordprocessingML document, 
/// are automatically be labeled with a specific caption defined using the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaptions: NamedElementCollection<DXW.AutoCaptions, DXW.AutoCaption, DMW.AutoCaption>
{
  public AutoCaptions(){ }

  public AutoCaptions(DXW.AutoCaptions openXmlElement): base(openXmlElement) { }

}
