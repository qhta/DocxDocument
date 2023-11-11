namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). The two child elements of this element shall be used to specify the properties and content of the current structured document tag via the sdtPr and sdtContent elements, respectively.
/// </summary>
public partial class SdtRow: ModelElement<DXW.SdtRow>
{
  public SdtRow(): base(){ }
  
  public SdtRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtRow(DXW.SdtRow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Row-Level Structured Document Tag Content.
  /// </summary>
  [DataMember]
  public DMW.SdtContentRow? SdtContentRow
  {
    get
    {
      return _Element?.GetObject<DMW.SdtContentRow,DXW.SdtContentRow>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtContentRow,DXW.SdtContentRow>(value);
    }
  }
  
  [DataMember]
  public DMW.SdtProperties? SdtProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SdtProperties,DXW.SdtProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtProperties,DXW.SdtProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.SdtEndCharProperties? SdtEndCharProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SdtEndCharProperties,DXW.SdtEndCharProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtEndCharProperties,DXW.SdtEndCharProperties>(value);
    }
  }
  
}
