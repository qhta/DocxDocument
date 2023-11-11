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
      return _Element?.GetObject<DMD.ForegroundColor,DXD.ForegroundColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ForegroundColor,DXD.ForegroundColor>(value);
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
      return _Element?.GetObject<DMD.BackgroundColor,DXD.BackgroundColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundColor,DXD.BackgroundColor>(value);
    }
  }
  
}
