namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor: ModelElement<DXD.SystemColor>
{
  public SystemColor(): base(){ }
  
  public SystemColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SystemColor(DXD.SystemColor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  [DataMember]
  public DM.HexBinary? LastColor
  {
    get
    {
      if (_Element?.LastColor?.Value != null)
        return (DocumentModel.RGB)UInt32.Parse(_ExistingElement.LastColor.Value, NumberStyles.HexNumber);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.LastColor = ((UInt32)value).ToString("X6");
      else
        _ExistingElement.LastColor = null;
    }
  }
  
}
