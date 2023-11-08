namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a pattern fill. A repeated pattern is used to fill the object.
/// </summary>
public partial class PatternFill: ModelElement<DXD.PatternFill>
{
  public PatternFill(): base(){ }
  
  public PatternFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PatternFill(DXD.PatternFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Foreground color.
  /// </summary>
  [DataMember]
  public DMD.ForegroundColor? ForegroundColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ForegroundColor>();
      if (element != null)
        return ForegroundColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ForegroundColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForegroundColorConverter.CreateOpenXmlElement<DXD.ForegroundColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Background color.
  /// </summary>
  [DataMember]
  public DMD.BackgroundColor? BackgroundColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BackgroundColor>();
      if (element != null)
        return BackgroundColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BackgroundColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundColorConverter.CreateOpenXmlElement<DXD.BackgroundColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
