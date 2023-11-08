namespace DocumentModel.Drawings;


/// <summary>
///   This simple type determines the relationship between effects in a container, either sibling or tree.
/// </summary>
public partial class EffectContainerType: ModelElement<DXD.EffectContainerType>
{
  public EffectContainerType(): base(){ }
  
  public EffectContainerType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EffectContainerType(DXD.EffectContainerType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
