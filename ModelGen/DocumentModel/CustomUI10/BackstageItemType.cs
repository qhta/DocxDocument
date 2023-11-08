namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageItemType Class.
/// </summary>
public partial class BackstageItemType: ModelElement<DXO10CUI.BackstageItemType>
{
  public BackstageItemType(): base(){ }
  
  public BackstageItemType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageItemType(DXO10CUI.BackstageItemType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Label
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Label);
    }
    set
    {
      _ExistingElement.Label = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetLabel);
    }
    set
    {
      _ExistingElement.GetLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
