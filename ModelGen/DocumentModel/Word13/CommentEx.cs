namespace DocumentModel.Word13;


/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public partial class CommentEx: ModelElement<DXO13W.CommentEx>
{
  public CommentEx(): base(){ }
  
  public CommentEx(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentEx(DXO13W.CommentEx openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaId
  {
    get
    {
      if (_Element?.ParaId?.Value != null)
        return HexIntConverter.GetValue(_Element?.ParaId.Value);
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
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaIdParent
  {
    get
    {
      if (_Element?.ParaIdParent?.Value != null)
        return HexIntConverter.GetValue(_Element?.ParaIdParent.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.ParaIdParent = value.ToString();
      else
        _ExistingElement.ParaIdParent = null;
    }
  }
  
  
  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Done
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Done);
    }
    set
    {
      _ExistingElement.Done = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
