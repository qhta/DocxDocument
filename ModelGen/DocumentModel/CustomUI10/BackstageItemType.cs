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
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Label
  {
    get => _Element?.Label;
    set => _ExistingElement.Label = value;
  }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get => _Element?.GetLabel;
    set => _ExistingElement.GetLabel = value;
  }
  
}
