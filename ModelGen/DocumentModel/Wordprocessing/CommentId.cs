namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentId Class.
/// </summary>
public partial class CommentId: ModelElement<DXO19WC.CommentId>
{
  public CommentId(): base(){ }
  
  public CommentId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentId(DXO19WC.CommentId openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaId
  {
    get
    {
      if (_Element?.ParaId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.ParaId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.ParaId = value.ToString();
      else
        _ExistingElement.ParaId = null;
    }
  }
  
  
  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? DurableId
  {
    get
    {
      if (_Element?.DurableId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.DurableId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.DurableId = value.ToString();
      else
        _ExistingElement.DurableId = null;
    }
  }
  
}
