namespace DocumentModel.Wordprocessing;


/// <summary>
///   Magnification Setting.
/// </summary>
public partial class Zoom: ModelElement<DXW.Zoom>
{
  public Zoom(): base(){ }
  
  public Zoom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Zoom(DXW.Zoom openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  [DataMember]
  public String? Percent
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Percent);
    }
    set
    {
      _ExistingElement.Percent = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
