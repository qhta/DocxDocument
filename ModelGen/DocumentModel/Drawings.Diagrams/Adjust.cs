namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape Adjust.
/// </summary>
public partial class Adjust: ModelElement<DXDDD.Adjust>
{
  public Adjust(): base(){ }
  
  public Adjust(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Adjust(DXDDD.Adjust openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Handle Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get
    {
      return _Element?.Index?.Value;
    }
    set
    {
      _ExistingElement.Index = value;
    }
  }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public Double? Val
  {
    get
    {
      return _Element?.Val?.Value;
    }
    set
    {
      _ExistingElement.Val = value;
    }
  }
  
}
