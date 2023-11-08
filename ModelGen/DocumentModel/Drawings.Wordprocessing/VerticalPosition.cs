namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Vertical Positioning.
/// </summary>
public partial class VerticalPosition: ModelElement<DXDW.VerticalPosition>
{
  public VerticalPosition(): base(){ }
  
  public VerticalPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalPosition(DXDW.VerticalPosition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  [DataMember]
  public DMDW.VerticalAlignment? VerticalAlignment
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.VerticalAlignment>();
      if (element != null)
        return VerticalAlignmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.VerticalAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VerticalAlignmentConverter.CreateOpenXmlElement<DXDW.VerticalAlignment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PositionOffset.
  /// </summary>
  [DataMember]
  public DMDW.PositionOffset? PositionOffset
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.PositionOffset>();
      if (element != null)
        return PositionOffsetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.PositionOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositionOffsetConverter.CreateOpenXmlElement<DXDW.PositionOffset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMWD.PercentagePositionVerticalOffset? PercentagePositionVerticalOffset
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10WD.PercentagePositionVerticalOffset>();
      if (element != null)
        return PercentagePositionVerticalOffsetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10WD.PercentagePositionVerticalOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PercentagePositionVerticalOffsetConverter.CreateOpenXmlElement<DXO10WD.PercentagePositionVerticalOffset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
