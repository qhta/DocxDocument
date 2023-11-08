namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Category.
/// </summary>
public partial class StyleDisplayCategory: ModelElement<DXDDD.StyleDisplayCategory>
{
  public StyleDisplayCategory(): base(){ }
  
  public StyleDisplayCategory(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDisplayCategory(DXDDD.StyleDisplayCategory openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Category Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Priority
  /// </summary>
  [DataMember]
  public UInt32? Priority
  {
    get
    {
      return _Element?.Priority?.Value;
    }
    set
    {
      _ExistingElement.Priority = value;
    }
  }
  
}
