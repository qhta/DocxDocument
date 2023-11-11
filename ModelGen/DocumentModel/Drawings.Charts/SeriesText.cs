namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Series Text.
/// </summary>
public partial class SeriesText: ModelElement<DXDC.SeriesText>
{
  public SeriesText(): base(){ }
  
  public SeriesText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesText(DXDC.SeriesText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      return _Element?.GetObject<DMDC.StringReference,DXDC.StringReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringReference,DXDC.StringReference>(value);
    }
  }
  
  
  /// <summary>
  ///   NumericValue.
  /// </summary>
  [DataMember]
  public DM.NumericValue? NumericValue
  {
    get
    {
      return NumericValueConverter.GetValue(_Element?.NumericValue);
    }
    set
    {
      _ExistingElement.NumericValue = NumericValueConverter.CreateOpenXmlElement<DXDC.NumericValue>(value);
    }
  }
  
}
