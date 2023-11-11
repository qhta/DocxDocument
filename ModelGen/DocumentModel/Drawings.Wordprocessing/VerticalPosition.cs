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
      return _Element?.GetObject<DMDW.VerticalAlignment,DXDW.VerticalAlignment>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.VerticalAlignment,DXDW.VerticalAlignment>(value);
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
      return _Element?.GetObject<DMDW.PositionOffset,DXDW.PositionOffset>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.PositionOffset,DXDW.PositionOffset>(value);
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
      return _Element?.GetObject<DMWD.PercentagePositionVerticalOffset,DXO10WD.PercentagePositionVerticalOffset>();
    }
    set
    {
      _ExistingElement.SetObject<DMWD.PercentagePositionVerticalOffset,DXO10WD.PercentagePositionVerticalOffset>(value);
    }
  }
  
}
