namespace DocumentModel.Math;


/// <summary>
///   Matrix Column.
/// </summary>
public partial class MatrixColumn: ModelElement<DXM.MatrixColumn>
{
  public MatrixColumn(): base(){ }
  
  public MatrixColumn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixColumn(DXM.MatrixColumn openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Column Properties.
  /// </summary>
  [DataMember]
  public DMM.MatrixColumnProperties? MatrixColumnProperties
  {
    get
    {
      return _Element?.GetObject<DMM.MatrixColumnProperties,DXM.MatrixColumnProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.MatrixColumnProperties,DXM.MatrixColumnProperties>(value);
    }
  }
  
}
