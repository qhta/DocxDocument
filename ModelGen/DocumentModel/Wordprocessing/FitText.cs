namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run shall not be automatically displayed based on the width of its contents, rather its contents shall be resized to fit the width specified by the val attribute. This expansion/contraction shall be performed by equally increasing/decreasing the size of each character in this run's contents when displayed.
/// </summary>
public partial class FitText: ModelElement<DXW.FitText>
{
  public FitText(): base(){ }
  
  public FitText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FitText(DXW.FitText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public UInt32? Val
  {
    get
    {
      return _Element?.Val?.Value;
    }
    set
    {
      _ExistingElement.Val = value;
    }
  }
  
  
  /// <summary>
  ///   Fit Text Run ID
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
