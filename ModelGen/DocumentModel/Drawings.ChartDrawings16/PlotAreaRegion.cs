namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public partial class PlotAreaRegion: ModelElement<DXO16DCD.PlotAreaRegion>
{
  public PlotAreaRegion(): base(){ }
  
  public PlotAreaRegion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotAreaRegion(DXO16DCD.PlotAreaRegion openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotSurface? PlotSurface
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.PlotSurface>();
      if (element != null)
        return PlotSurfaceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PlotSurface>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotSurfaceConverter.CreateOpenXmlElement<DXO16DCD.PlotSurface>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
