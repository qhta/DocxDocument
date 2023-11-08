namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill: ModelElement<DXD.GradientFill>
{
  public GradientFill(): base(){ }
  
  public GradientFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFill(DXD.GradientFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get
    {
      return _Element?.RotateWithShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.RotateWithShape = null;
    }
  }
  
  
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  [DataMember]
  public DMD.GradientStopList? GradientStopList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GradientStopList>();
      if (element != null)
        return GradientStopListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientStopListConverter.CreateOpenXmlElement<DXD.GradientStopList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.LinearGradientFill? LinearGradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LinearGradientFill>();
      if (element != null)
        return LinearGradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LinearGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinearGradientFillConverter.CreateOpenXmlElement<DXD.LinearGradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PathGradientFill? PathGradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PathGradientFill>();
      if (element != null)
        return PathGradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PathGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathGradientFillConverter.CreateOpenXmlElement<DXD.PathGradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.TileRectangle? TileRectangle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.TileRectangle>();
      if (element != null)
        return TileRectangleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.TileRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TileRectangleConverter.CreateOpenXmlElement<DXD.TileRectangle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
