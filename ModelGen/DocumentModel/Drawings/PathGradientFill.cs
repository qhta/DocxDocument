namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class PathGradientFill: ModelElement<DXD.PathGradientFill>
{
  public PathGradientFill(): base(){ }
  
  public PathGradientFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PathGradientFill(DXD.PathGradientFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  [DataMember]
  public DMD.FillToRectangle? FillToRectangle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FillToRectangle>();
      if (element != null)
        return FillToRectangleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillToRectangleConverter.CreateOpenXmlElement<DXD.FillToRectangle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
