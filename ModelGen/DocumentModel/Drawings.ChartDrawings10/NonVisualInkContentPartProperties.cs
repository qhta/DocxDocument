namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public partial class NonVisualInkContentPartProperties: ModelElement<DXO10DCD.NonVisualInkContentPartProperties>
{
  public NonVisualInkContentPartProperties(): base(){ }
  
  public NonVisualInkContentPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualInkContentPartProperties(DXO10DCD.NonVisualInkContentPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsComment
  {
    get
    {
      return _Element?.IsComment?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.IsComment = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.IsComment = null;
    }
  }
  
  
  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  [DataMember]
  public DMD10.ContentPartLocks? ContentPartLocks
  {
    get
    {
      return _Element?.GetObject<DMD10.ContentPartLocks,DXO10D.ContentPartLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ContentPartLocks,DXO10D.ContentPartLocks>(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD10.OfficeArtExtensionList,DXO10D.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.OfficeArtExtensionList,DXO10D.OfficeArtExtensionList>(value);
    }
  }
  
}
