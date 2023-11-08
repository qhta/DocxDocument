namespace DocumentModel.Drawings;


/// <summary>
///   Tab Stop.
/// </summary>
public partial class TabStop: ModelElement<DXD.TabStop>
{
  public TabStop(): base(){ }
  
  public TabStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TabStop(DXD.TabStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Tab Position
  /// </summary>
  [DataMember]
  public Int32? Position
  {
    get
    {
      return _Element?.Position?.Value;
    }
    set
    {
      _ExistingElement.Position = value;
    }
  }
  
}
