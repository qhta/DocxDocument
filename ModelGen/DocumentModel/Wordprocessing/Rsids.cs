namespace DocumentModel.Wordprocessing;


/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids: ModelElement<DXW.Rsids>
{
  public Rsids(): base(){ }
  
  public Rsids(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rsids(DXW.Rsids openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  [DataMember]
  public DMW.RsidRoot? RsidRoot
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType");
  }
  
}
