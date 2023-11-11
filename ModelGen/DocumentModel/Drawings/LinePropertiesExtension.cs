namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class LinePropertiesExtension: ModelElement<DXD.LinePropertiesExtension>
{
  public LinePropertiesExtension(): base(){ }
  
  public LinePropertiesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinePropertiesExtension(DXD.LinePropertiesExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDSS.LineSketchStyleProperties? LineSketchStyleProperties
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchStyleProperties,DXO21DSS.LineSketchStyleProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchStyleProperties,DXO21DSS.LineSketchStyleProperties>(value);
    }
  }
  
}
