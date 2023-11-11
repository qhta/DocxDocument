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
      return _Element?.GetObject<DMDW.HorizontalAlignment,DXDW.HorizontalAlignment>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.HorizontalAlignment,DXDW.HorizontalAlignment>(value);
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
      return _Element?.GetObject<DMDW.PositionOffset,DXDW.PositionOffset>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.PositionOffset,DXDW.PositionOffset>(value);
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
      return _Element?.GetObject<DMWD.PercentagePositionHeightOffset,DXO10WD.PercentagePositionHeightOffset>();
    }
    set
    {
      _ExistingElement.SetObject<DMWD.PercentagePositionHeightOffset,DXO10WD.PercentagePositionHeightOffset>(value);
    }
  }
  
}
