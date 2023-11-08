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
        return HexIntConverter.GetValue(_ExistingElement.AnchorId.Value);
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
      var element = _Element?.GetFirstChild<DXW.MovieReference>();
      if (element != null)
        return MovieReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MovieReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MovieReferenceConverter.CreateOpenXmlElement<DXW.MovieReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Control>();
      if (element != null)
        return ControlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Control>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlConverter.CreateOpenXmlElement<DXW.Control>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
