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
      return _Element?.GetObject<DMD.FillToRectangle,DXD.FillToRectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FillToRectangle,DXD.FillToRectangle>(value);
    }
  }
  
}
