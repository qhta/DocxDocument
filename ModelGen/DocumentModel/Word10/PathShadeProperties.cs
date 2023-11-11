namespace DocumentModel.Word10;


/// <summary>
///   This element specifies that a gradient fill follows a path versus a linear line.
/// </summary>
public partial class PathShadeProperties: ModelElement<DXO10W.PathShadeProperties>
{
  public PathShadeProperties(): base(){ }
  
  public PathShadeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PathShadeProperties(DXO10W.PathShadeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  [DataMember]
  public DMW10.FillToRectangle? FillToRectangle
  {
    get
    {
      return _Element?.GetObject<DMW10.FillToRectangle,DXO10W.FillToRectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.FillToRectangle,DXO10W.FillToRectangle>(value);
    }
  }
  
}
