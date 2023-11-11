namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartType: ModelElement<DXW.SdtDocPartType>
{
  public SdtDocPartType(): base(){ }
  
  public SdtDocPartType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtDocPartType(DXW.SdtDocPartType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  [DataMember]
  public DMW.DocPartGallery? DocPartGallery
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartGallery,DXW.DocPartGallery>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartGallery,DXW.DocPartGallery>(value);
    }
  }
  
  
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  [DataMember]
  public DMW.DocPartCategory? DocPartCategory
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartCategory,DXW.DocPartCategory>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartCategory,DXW.DocPartCategory>(value);
    }
  }
  
  
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  [DataMember]
  public DMW.DocPartUnique? DocPartUnique
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartUnique,DXW.DocPartUnique>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartUnique,DXW.DocPartUnique>(value);
    }
  }
  
}
