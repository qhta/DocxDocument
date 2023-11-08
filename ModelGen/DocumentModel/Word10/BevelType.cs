namespace DocumentModel.Word10;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType: ModelElement<DXO10W.BevelType>
{
  public BevelType(): base(){ }
  
  public BevelType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelType(DXO10W.BevelType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
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
  ///   h, this property is only available in Office 2010 and later.
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
