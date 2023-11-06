namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a rule entry in a rules element rule set that describes how a certain shape or set of shapes 
/// behaves during editing.
/// </summary>
public partial class Entry : ModelElement<DXVO.Entry>
{
  public Entry(): base(){ }

  public Entry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Entry(DXVO.Entry openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// Specifies the ID of the new group. Default is 0.
  /// </summary>
  [DataMember]
  public int? New
  {
    get => _Element.New?.Value;
    set => _Element.New = value;
  }

  /// <summary>
  /// Specifies the ID of the old group. Default is 0.
  /// </summary>
  [DataMember]
  public int? Type
  {
    get => _Element.Old?.Value;
    set => _Element.Old = value;
  }

}
