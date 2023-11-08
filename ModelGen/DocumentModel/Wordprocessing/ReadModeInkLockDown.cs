namespace DocumentModel.Wordprocessing;


/// <summary>
///   Freeze Document Layout.
/// </summary>
public partial class ReadModeInkLockDown: ModelElement<DXW.ReadModeInkLockDown>
{
  public ReadModeInkLockDown(): base(){ }
  
  public ReadModeInkLockDown(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ReadModeInkLockDown(DXW.ReadModeInkLockDown openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  [DataMember]
  public Boolean? UseActualPages
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.UseActualPages);
    }
    set
    {
      _ExistingElement.UseActualPages = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  [DataMember]
  public UInt32? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
  
  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      _ExistingElement.Height = value;
    }
  }
  
  
  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  [DataMember]
  public String? FontSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FontSize);
    }
    set
    {
      _ExistingElement.FontSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
