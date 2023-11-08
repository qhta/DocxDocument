namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageSize Class.
/// </summary>
public partial class PageSize: ModelElement<DXW.PageSize>
{
  public PageSize(): base(){ }
  
  public PageSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSize(DXW.PageSize openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Page Width
  /// </summary>
  [DataMember]
  public UInt32? Width
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
  ///   Page Height
  /// </summary>
  [DataMember]
  public UInt32? Height
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
  
  
  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  [DataMember]
  public UInt16? Code
  {
    get
    {
      return _Element?.Code?.Value;
    }
    set
    {
      _ExistingElement.Code = value;
    }
  }
  
}
