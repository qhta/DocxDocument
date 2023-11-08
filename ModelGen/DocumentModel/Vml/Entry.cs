namespace DocumentModel.Vml;


/// <summary>
///   Regroup Entry.
/// </summary>
public partial class Entry: ModelElement<DXVO.Entry>
{
  public Entry(): base(){ }
  
  public Entry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Entry(DXVO.Entry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   New Group ID
  /// </summary>
  [DataMember]
  public Int32? New
  {
    get
    {
      return _Element?.New?.Value;
    }
    set
    {
      _ExistingElement.New = value;
    }
  }
  
  
  /// <summary>
  ///   Old Group ID
  /// </summary>
  [DataMember]
  public Int32? Old
  {
    get
    {
      return _Element?.Old?.Value;
    }
    set
    {
      _ExistingElement.Old = value;
    }
  }
  
}
