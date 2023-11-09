namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingPrinterSettingsPart
/// </summary>
public partial class WordprocessingPrinterSettingsPart: ModelPartElement<DXPack.WordprocessingPrinterSettingsPart>
{
  public WordprocessingPrinterSettingsPart(): base(){ }
  
  public WordprocessingPrinterSettingsPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public WordprocessingPrinterSettingsPart(DXPack.WordprocessingPrinterSettingsPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
