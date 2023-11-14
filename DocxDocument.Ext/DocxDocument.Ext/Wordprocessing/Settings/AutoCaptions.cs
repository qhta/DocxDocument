namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies that one or more types of objects, when inserted into a WordprocessingML document, 
/// are automatically be labeled with a specific caption defined using the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaptions: NamedElementCollection<DXW.AutoCaptions, DXW.AutoCaption, DMW.AutoCaption>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public AutoCaptions(){ }

  public AutoCaptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public AutoCaptions(DXW.AutoCaptions openXmlElement): base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
