namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class NonVisualPicturePropertiesExtension: ModelElement<DXD.NonVisualPicturePropertiesExtension>
{
  public NonVisualPicturePropertiesExtension(): base(){ }
  
  public NonVisualPicturePropertiesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPicturePropertiesExtension(DXD.NonVisualPicturePropertiesExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
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
  
  [DataMember]
  public DMD10.CameraTool? CameraTool
  {
    get
    {
      return _Element?.GetObject<DMD10.CameraTool,DXO10D.CameraTool>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.CameraTool,DXO10D.CameraTool>(value);
    }
  }
  
  [DataMember]
  public DMD.SignatureLine? SignatureLine
  {
    get
    {
      return _Element?.GetObject<DMD.SignatureLine,DXO13D.SignatureLine>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SignatureLine,DXO13D.SignatureLine>(value);
    }
  }
  
  [DataMember]
  public DMD.ObjectProperties? ObjectProperties
  {
    get
    {
      return _Element?.GetObject<DMD.ObjectProperties,DXO13D.ObjectProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ObjectProperties,DXO13D.ObjectProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.LiveFeedProperties? LiveFeedProperties
  {
    get
    {
      return _Element?.GetObject<DMD.LiveFeedProperties,DXO21DL.LiveFeedProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LiveFeedProperties,DXO21DL.LiveFeedProperties>(value);
    }
  }
  
  [DataMember]
  public DMDIF.ImageFormula? ImageFormula
  {
    get
    {
      return _Element?.GetObject<DMDIF.ImageFormula,DXOD22IF.ImageFormula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDIF.ImageFormula,DXOD22IF.ImageFormula>(value);
    }
  }
  
}
