namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a set of default run properties for the current document. The actual run properties are stored within the rPr child element of the current element.
/// </summary>
public partial class RunPropertiesDefault: ModelElement<DXW.RunPropertiesDefault>
{
  public RunPropertiesDefault(): base(){ }
  
  public RunPropertiesDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunPropertiesDefault(DXW.RunPropertiesDefault openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get
    {
      return _Element?.GetObject<DMW.RunPropertiesBaseStyle,DXW.RunPropertiesBaseStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunPropertiesBaseStyle,DXW.RunPropertiesBaseStyle>(value);
    }
  }
  
}
