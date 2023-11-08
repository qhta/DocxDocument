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
      var element = _Element?.GetFirstChild<DXO16DCD.Xsddouble>();
      if (element != null)
        return XsddoubleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Xsddouble>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = XsddoubleConverter.CreateOpenXmlElement<DXO16DCD.Xsddouble>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.BinCountXsdunsignedInt>();
      if (element != null)
        return BinCountXsdunsignedIntConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.BinCountXsdunsignedInt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BinCountXsdunsignedIntConverter.CreateOpenXmlElement<DXO16DCD.BinCountXsdunsignedInt>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
