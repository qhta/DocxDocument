namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Category.
/// </summary>
public partial class ColorTransformCategory: ModelElement<DXDDD.ColorTransformCategory>
{
  public ColorTransformCategory(): base(){ }
  
  public ColorTransformCategory(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformCategory(DXDDD.ColorTransformCategory openXmlElement): base(openXmlElement) { }
  
  
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
