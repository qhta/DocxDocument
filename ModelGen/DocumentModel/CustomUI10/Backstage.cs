namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the Backstage Class.
/// </summary>
public partial class Backstage: ModelElement<DXO10CUI.Backstage>
{
  public Backstage(): base(){ }
  
  public Backstage(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Backstage(DXO10CUI.Backstage openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onShow, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnShow
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnShow);
    }
    set
    {
      _ExistingElement.OnShow = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   onHide, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnHide
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnHide);
    }
    set
    {
      _ExistingElement.OnHide = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
