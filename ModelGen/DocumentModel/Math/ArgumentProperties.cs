namespace DocumentModel.Math;


/// <summary>
///   Argument Properties.
/// </summary>
public partial class ArgumentProperties: ModelElement<DXM.ArgumentProperties>
{
  public ArgumentProperties(): base(){ }
  
  public ArgumentProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArgumentProperties(DXM.ArgumentProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Argument Size.
  /// </summary>
  [DataMember]
  public Int64? ArgumentSize
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXM.ArgumentSize>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXM.ArgumentSize,System.Int64>(_ExistingElement, value);
    }
  }
  
}
