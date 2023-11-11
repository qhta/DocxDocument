namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of default paragraph and run properties which shall be applied to every paragraph and run in the current WordprocessingML document. These properties are applied first in the style hierarchy; therefore they are superseded by any further conflicting formatting but apply if no further formatting is present.
/// </summary>
public partial class DocDefaults: ModelElement<DXW.DocDefaults>
{
  public DocDefaults(): base(){ }
  
  public DocDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocDefaults(DXW.DocDefaults openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesDefault? RunPropertiesDefault
  {
    get
    {
      return _Element?.GetObject<DMW.RunPropertiesDefault,DXW.RunPropertiesDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunPropertiesDefault,DXW.RunPropertiesDefault>(value);
    }
  }
  
  
  /// <summary>
  ///   Default Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesDefault? ParagraphPropertiesDefault
  {
    get
    {
      return _Element?.GetObject<DMW.ParagraphPropertiesDefault,DXW.ParagraphPropertiesDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ParagraphPropertiesDefault,DXW.ParagraphPropertiesDefault>(value);
    }
  }
  
}
