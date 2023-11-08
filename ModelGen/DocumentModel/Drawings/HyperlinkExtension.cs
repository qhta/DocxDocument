namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class HyperlinkExtension: ModelElement<DXD.HyperlinkExtension>
{
  public HyperlinkExtension(): base(){ }
  
  public HyperlinkExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkExtension(DXD.HyperlinkExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMD.HyperlinkColorEnum? HyperlinkColor
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>(_ExistingElement.GetFirstChild<DXO19DHLC.HyperlinkColor>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19DHLC.HyperlinkColor>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>(itemElement, (DMD.HyperlinkColorEnum)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO19DHLC.HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>((DMD.HyperlinkColorEnum)value));
    }
  }
  
}
