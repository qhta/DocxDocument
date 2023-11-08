namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPastelsSmooth Class.
/// </summary>
public partial class ArtisticPastelsSmooth: ModelElement<DXO10D.ArtisticPastelsSmooth>
{
  public ArtisticPastelsSmooth(): base(){ }
  
  public ArtisticPastelsSmooth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPastelsSmooth(DXO10D.ArtisticPastelsSmooth openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Transparancy
  {
    get
    {
      return _Element?.Transparancy?.Value;
    }
    set
    {
      _ExistingElement.Transparancy = value;
    }
  }
  
  
  /// <summary>
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? BrushSize
  {
    get
    {
      return _Element?.BrushSize?.Value;
    }
    set
    {
      _ExistingElement.BrushSize = value;
    }
  }
  
}
