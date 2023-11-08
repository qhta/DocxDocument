namespace DocumentModel.Vml;


/// <summary>
///   Shape Clipping Path.
/// </summary>
public partial class ClipPath: ModelElement<DXVO.ClipPath>
{
  public ClipPath(): base(){ }
  
  public ClipPath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ClipPath(DXVO.ClipPath openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Path Definition
  /// </summary>
  [DataMember]
  public String? Value
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Value);
    }
    set
    {
      _ExistingElement.Value = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
