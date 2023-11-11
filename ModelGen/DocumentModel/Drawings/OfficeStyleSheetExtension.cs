namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class OfficeStyleSheetExtension: ModelElement<DXD.OfficeStyleSheetExtension>
{
  public OfficeStyleSheetExtension(): base(){ }
  
  public OfficeStyleSheetExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeStyleSheetExtension(DXD.OfficeStyleSheetExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMT.ThemeFamily? ThemeFamily
  {
    get
    {
      return _Element?.GetObject<DMT.ThemeFamily,DXO13T.ThemeFamily>();
    }
    set
    {
      _ExistingElement.SetObject<DMT.ThemeFamily,DXO13T.ThemeFamily>(value);
    }
  }
  
}
