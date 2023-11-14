namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a rule entry in a rules element rule set that describes how a certain shape or set of shapes 
/// behaves during editing.
/// </summary>
public partial class Entry : ModelElement<DXVO.Entry>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Entry(): base(){ }

  public Entry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Entry(DXVO.Entry openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Specifies the ID of the new group. Default is 0.
  /// </summary>
  [DataMember]
  public int? New
  {
    get => _Element?.New?.Value;
    set => _ExistingElement.New = value;
  }

  /// <summary>
  /// Specifies the ID of the old group. Default is 0.
  /// </summary>
  [DataMember]
  public int? Type
  {
    get => _Element?.Old?.Value;
    set => _ExistingElement.Old = value;
  }

}
