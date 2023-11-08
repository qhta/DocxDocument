namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the background for every page of the document containing the background element. A document's background is the image or fill for the entire page surface, behind all other document content.
/// </summary>
public partial class DocumentBackground: ModelElement<DXW.DocumentBackground>
{
  public DocumentBackground(): base(){ }
  
  public DocumentBackground(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentBackground(DXW.DocumentBackground openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   themeTint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeTint);
    }
    set
    {
      _ExistingElement.ThemeTint = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   themeShade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeShade);
    }
    set
    {
      _ExistingElement.ThemeShade = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Background.
  /// </summary>
  [DataMember]
  public DMVML.Background? Background
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.Background>();
      if (element != null)
        return BackgroundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.Background>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundConverter.CreateOpenXmlElement<DXV.Background>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
