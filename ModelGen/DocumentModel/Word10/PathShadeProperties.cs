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
      var element = _Element?.GetFirstChild<DXO10W.FillToRectangle>();
      if (element != null)
        return FillToRectangleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillToRectangleConverter.CreateOpenXmlElement<DXO10W.FillToRectangle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
