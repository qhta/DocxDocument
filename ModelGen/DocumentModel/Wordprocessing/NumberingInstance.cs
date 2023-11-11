namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definition Instance.
/// </summary>
public partial class NumberingInstance: ModelElement<DXW.NumberingInstance>
{
  public NumberingInstance(): base(){ }
  
  public NumberingInstance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingInstance(DXW.NumberingInstance openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   numId
  /// </summary>
  [DataMember]
  public Int32? NumberID
  {
    get
    {
      return _Element?.NumberID?.Value;
    }
    set
    {
      _ExistingElement.NumberID = value;
    }
  }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  [DataMember]
  public Int32? DurableId
  {
    get
    {
      return _Element?.DurableId?.Value;
    }
    set
    {
      _ExistingElement.DurableId = value;
    }
  }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  [DataMember]
  public DMW.AbstractNumId? AbstractNumId
  {
    get
    {
      return _Element?.GetObject<DMW.AbstractNumId,DXW.AbstractNumId>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AbstractNumId,DXW.AbstractNumId>(value);
    }
  }
  
}
