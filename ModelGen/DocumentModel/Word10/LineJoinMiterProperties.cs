namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that a line join is mitered.
/// </summary>
public partial class LineJoinMiterProperties: ModelElement<DXO10W.LineJoinMiterProperties>
{
  public LineJoinMiterProperties(): base(){ }
  
  public LineJoinMiterProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineJoinMiterProperties(DXO10W.LineJoinMiterProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lim, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Limit
  {
    get
    {
      return _Element?.Limit?.Value;
    }
    set
    {
      _ExistingElement.Limit = value;
    }
  }
  
}
