namespace DocumentModel.Math;


/// <summary>
///   Group-Character Function.
/// </summary>
public partial class GroupChar: ModelElement<DXM.GroupChar>
{
  public GroupChar(): base(){ }
  
  public GroupChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupChar(DXM.GroupChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  [DataMember]
  public DMM.GroupCharProperties? GroupCharProperties
  {
    get
    {
      return _Element?.GetObject<DMM.GroupCharProperties,DXM.GroupCharProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.GroupCharProperties,DXM.GroupCharProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      return _Element?.GetObject<DMM.Base,DXM.Base>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Base,DXM.Base>(value);
    }
  }
  
}
