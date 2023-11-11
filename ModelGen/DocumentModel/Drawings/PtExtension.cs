namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class PtExtension: ModelElement<DXD.PtExtension>
{
  public PtExtension(): base(){ }
  
  public PtExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PtExtension(DXD.PtExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDD.NonVisualDrawingProperties,DXO10DD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.NonVisualDrawingProperties,DXO10DD.NonVisualDrawingProperties>(value);
    }
  }
  
}
