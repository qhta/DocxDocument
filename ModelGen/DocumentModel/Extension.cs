namespace DocumentModel;


/// <summary>
///   Defines the Extension Class.
/// </summary>
public partial class Extension: ModelElement<DXO21OEL.Extension>
{
  public Extension(): base(){ }
  
  public Extension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extension(DXO21OEL.Extension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
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
  
}
