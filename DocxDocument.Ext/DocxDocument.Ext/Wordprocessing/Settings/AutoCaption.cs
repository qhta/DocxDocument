namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies what type(s) of objects shall automatically labelled with captions (§17.15.1.17), 
/// and with which captions the specified objects shall be labelled as defined in the caption element (§17.15.1.16).
/// </summary>
[DataContract]
public partial class AutoCaption: ModelElement<DXW.AutoCaption>, INamedElement
{
  public AutoCaption(): base(){ }

  public AutoCaption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public AutoCaption(DXW.AutoCaption openXmlElement): base(openXmlElement) { }

  [DataMember]
  public string? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }

  [DataMember]
  public string? Caption
  {
    get => _Element?.Caption;
    set => _ExistingElement.Caption = value;
  }
}
