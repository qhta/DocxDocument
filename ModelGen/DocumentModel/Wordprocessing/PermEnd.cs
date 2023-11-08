namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public partial class PermEnd: ModelElement<DXW.PermEnd>
{
  public PermEnd(): base(){ }
  
  public PermEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PermEnd(DXW.PermEnd openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation ID
  /// </summary>
  [DataMember]
  public Int32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
}
