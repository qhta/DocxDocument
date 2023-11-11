namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). The two child elements of this element shall be used to specify the properties and content of the current structured document tag via the sdtPr and sdtContent elements, respectively.
/// </summary>
public partial class SdtCell: ModelElement<DXW.SdtCell>
{
  public SdtCell(): base(){ }
  
  public SdtCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtCell(DXW.SdtCell openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Cell-Level Structured Document Tag Content.
  /// </summary>
  [DataMember]
  public DMW.SdtContentCell? SdtContentCell
  {
    get
    {
      return _Element?.GetObject<DMW.SdtContentCell,DXW.SdtContentCell>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtContentCell,DXW.SdtContentCell>(value);
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
