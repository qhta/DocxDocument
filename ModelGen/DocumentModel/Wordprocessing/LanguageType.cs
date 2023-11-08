namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LanguageType Class.
/// </summary>
public partial class LanguageType: ModelElement<DXW.LanguageType>
{
  public LanguageType(): base(){ }
  
  public LanguageType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LanguageType(DXW.LanguageType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Latin Language
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
  
  
  /// <summary>
  ///   East Asian Language
  /// </summary>
  [DataMember]
  public String? EastAsia
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EastAsia);
    }
    set
    {
      _ExistingElement.EastAsia = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Complex Script Language
  /// </summary>
  [DataMember]
  public String? Bidi
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Bidi);
    }
    set
    {
      _ExistingElement.Bidi = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
