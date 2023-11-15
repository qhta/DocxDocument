namespace DocumentModel.Wordprocessing;


/// <summary>
///   Magnification Setting.
/// </summary>
public partial class Zoom: ModelElement<DXW.Zoom>
{
  public Zoom(): base(){ }
  
  public Zoom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Zoom(DXW.Zoom openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  [DataMember]
  public String? Percent
  {
    get => _Element?.Percent;
    set => _ExistingElement.Percent = value;
  }
  
}
