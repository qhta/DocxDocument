namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Categorization.
/// </summary>
public partial class Category: ModelElement<DXW.Category>
{
  public Category(): base(){ }
  
  public Category(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Category(DXW.Category openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  [DataMember]
  public DMW.Name? Name
  {
    get
    {
      return _Element?.GetObject<DMW.Name,DXW.Name>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Name,DXW.Name>(value);
    }
  }
  
  
  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  [DataMember]
  public DMW.DocPartGalleryKind? Gallery
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(_ExistingElement.GetFirstChild<DXW.Gallery>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Gallery>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>(itemElement, (DMW.DocPartGalleryKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Gallery, DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DMW.DocPartGalleryKind>((DMW.DocPartGalleryKind)value));
    }
  }
  
}
