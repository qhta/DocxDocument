namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Extension2 Class.
/// </summary>
public partial class Extension2: ModelElement<DXO16DCD.Extension2>
{
  public Extension2(): base(){ }
  
  public Extension2(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extension2(DXO16DCD.Extension2 openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uri, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
}
