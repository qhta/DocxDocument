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
    get => _Element?.GetIntVal<Int64, DXM.ArgumentSize>();
    set => _ExistingElement.SetIntVal<Int64, DXM.ArgumentSize>(value);
  }
  
}
