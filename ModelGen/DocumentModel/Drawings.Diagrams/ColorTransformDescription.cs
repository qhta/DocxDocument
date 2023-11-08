namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Description.
/// </summary>
public partial class ColorTransformDescription: ModelElement<DXDDD.ColorTransformDescription>
{
  public ColorTransformDescription(): base(){ }
  
  public ColorTransformDescription(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformDescription(DXDDD.ColorTransformDescription openXmlElement): base(openXmlElement) { }
  
  
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
