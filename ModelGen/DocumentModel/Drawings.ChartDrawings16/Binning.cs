namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Binning Class.
/// </summary>
public partial class Binning: ModelElement<DXO16DCD.Binning>
{
  public Binning(): base(){ }
  
  public Binning(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Binning(DXO16DCD.Binning openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   underflow, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Underflow
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Underflow);
    }
    set
    {
      _ExistingElement.Underflow = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Overflow
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Overflow);
    }
    set
    {
      _ExistingElement.Overflow = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Xsddouble.
  /// </summary>
  [DataMember]
  public DMDCD16.Xsddouble? Xsddouble
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Xsddouble,DXO16DCD.Xsddouble>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Xsddouble,DXO16DCD.Xsddouble>(value);
    }
  }
  
  
  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  [DataMember]
  public DMDCD16.BinCountXsdunsignedInt? BinCountXsdunsignedInt
  {
    get
    {
      return _Element?.GetObject<DMDCD16.BinCountXsdunsignedInt,DXO16DCD.BinCountXsdunsignedInt>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.BinCountXsdunsignedInt,DXO16DCD.BinCountXsdunsignedInt>(value);
    }
  }
  
}
