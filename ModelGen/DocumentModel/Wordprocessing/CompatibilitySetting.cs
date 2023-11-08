namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public partial class CompatibilitySetting: ModelElement<DXW.CompatibilitySetting>
{
  public CompatibilitySetting(): base(){ }
  
  public CompatibilitySetting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uri
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
