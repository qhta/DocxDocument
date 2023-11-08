namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontCharSet Class.
/// </summary>
public partial class FontCharSet: ModelElement<DXW.FontCharSet>
{
  public FontCharSet(): base(){ }
  
  public FontCharSet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontCharSet(DXW.FontCharSet openXmlElement): base(openXmlElement) { }
  
  
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
