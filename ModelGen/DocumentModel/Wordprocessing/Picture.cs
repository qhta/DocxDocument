namespace DocumentModel.Wordprocessing;


/// <summary>
///   VML Object.
/// </summary>
public partial class Picture: ModelElement<DXW.Picture>
{
  public Picture(): base(){ }
  
  public Picture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Picture(DXW.Picture openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? AnchorId
  {
    get
    {
      if (_Element?.AnchorId?.Value != null)
        return HexIntConverter.GetValue(_Element?.AnchorId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.AnchorId = value.ToString();
      else
        _ExistingElement.AnchorId = null;
    }
  }
  
  [DataMember]
  public DMW.MovieReference? MovieReference
  {
    get
    {
      return _Element?.GetObject<DMW.MovieReference,DXW.MovieReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MovieReference,DXW.MovieReference>(value);
    }
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get
    {
      return _Element?.GetObject<DMW.Control,DXW.Control>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Control,DXW.Control>(value);
    }
  }
  
}
