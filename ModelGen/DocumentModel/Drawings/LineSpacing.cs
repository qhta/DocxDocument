namespace DocumentModel.Drawings;


/// <summary>
///   Line Spacing.
/// </summary>
public partial class LineSpacing: ModelElement<DXD.LineSpacing>
{
  public LineSpacing(): base(){ }
  
  public LineSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSpacing(DXD.LineSpacing openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Int32? SpacingPercent
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPercent>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPercent>(value);
  }
  
  [DataMember]
  public Int32? SpacingPoints
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPoints>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPoints>(value);
  }
  
}
