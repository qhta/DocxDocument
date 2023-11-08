namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType: ModelElement<DXD.BevelType>
{
  public BevelType(): base(){ }
  
  public BevelType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelType(DXD.BevelType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
  
  /// <summary>
  ///   Height
  /// </summary>
  [DataMember]
  public Int64? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      _ExistingElement.Height = value;
    }
  }
  
}
