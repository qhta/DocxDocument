namespace DocumentModel.Drawings;


/// <summary>
///   This element specifics the color mapping layer which allows a user to define colors for background and text.  This allows for swapping out of light/dark colors for backgrounds and the text on top of the background in order to maintain readability of the text  On a deeper level, this specifies exactly which colors the first 12 values refer to in the color scheme.
/// </summary>
public partial class ColorMap: ModelElement<DXD.ColorMap>
{
  public ColorMap(): base(){ }
  
  public ColorMap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMap(DXD.ColorMap openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
