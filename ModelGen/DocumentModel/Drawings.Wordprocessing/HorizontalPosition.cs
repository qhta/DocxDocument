namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Horizontal Positioning.
/// </summary>
public partial class HorizontalPosition: ModelElement<DXDW.HorizontalPosition>
{
  public HorizontalPosition(): base(){ }
  
  public HorizontalPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HorizontalPosition(DXDW.HorizontalPosition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  [DataMember]
  public DMDW.HorizontalAlignment? HorizontalAlignment
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.HorizontalAlignment>();
      if (element != null)
        return HorizontalAlignmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.HorizontalAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HorizontalAlignmentConverter.CreateOpenXmlElement<DXDW.HorizontalAlignment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Absolute Position Offset.
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
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMWD.PercentagePositionHeightOffset? PercentagePositionHeightOffset
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10WD.PercentagePositionHeightOffset>();
      if (element != null)
        return PercentagePositionHeightOffsetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10WD.PercentagePositionHeightOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PercentagePositionHeightOffsetConverter.CreateOpenXmlElement<DXO10WD.PercentagePositionHeightOffset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
