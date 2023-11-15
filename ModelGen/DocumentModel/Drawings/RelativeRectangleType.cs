namespace DocumentModel.Drawings;


/// <summary>
///   Defines the RelativeRectangleType Class.
/// </summary>
public partial class RelativeRectangleType: ModelElement<DXD.RelativeRectangleType>
{
  public RelativeRectangleType(): base(){ }
  
  public RelativeRectangleType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeRectangleType(DXD.RelativeRectangleType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Left Offset
  /// </summary>
  [DataMember]
  public Int32? Left
  {
    get => _Element?.Left?.Value;
    set => _ExistingElement.Left = value;
  }
  
  
  /// <summary>
  ///   Top Offset
  /// </summary>
  [DataMember]
  public Int32? Top
  {
    get => _Element?.Top?.Value;
    set => _ExistingElement.Top = value;
  }
  
  
  /// <summary>
  ///   Right Offset
  /// </summary>
  [DataMember]
  public Int32? Right
  {
    get => _Element?.Right?.Value;
    set => _ExistingElement.Right = value;
  }
  
  
  /// <summary>
  ///   Bottom Offset
  /// </summary>
  [DataMember]
  public Int32? Bottom
  {
    get => _Element?.Bottom?.Value;
    set => _ExistingElement.Bottom = value;
  }
  
}
