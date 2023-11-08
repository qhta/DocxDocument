namespace DocumentModel.Math;


/// <summary>
///   Break.
/// </summary>
public partial class Break: ModelElement<DXM.Break>
{
  public Break(): base(){ }
  
  public Break(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Break(DXM.Break openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  [DataMember]
  public Int64? AlignAt
  {
    get
    {
      return _Element?.AlignAt?.Value;
    }
    set
    {
      _ExistingElement.AlignAt = value;
    }
  }
  
  
  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  [DataMember]
  public Int64? Val
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
