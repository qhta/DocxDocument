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
        _ExistingElement.IsComment = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXO10D.ContentPartLocks>();
      if (element != null)
        return ContentPartLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ContentPartLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContentPartLocksConverter.CreateOpenXmlElement<DXO10D.ContentPartLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO10D.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO10D.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
