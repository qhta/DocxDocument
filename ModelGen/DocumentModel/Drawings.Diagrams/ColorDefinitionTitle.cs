namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Title.
/// </summary>
public partial class ColorDefinitionTitle: ModelElement<DXDDD.ColorDefinitionTitle>
{
  public ColorDefinitionTitle(): base(){ }
  
  public ColorDefinitionTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorDefinitionTitle(DXDDD.ColorDefinitionTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Language);
    }
    set
    {
      _ExistingElement.Language = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Description Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
