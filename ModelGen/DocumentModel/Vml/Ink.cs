namespace DocumentModel.Vml;


/// <summary>
///   Ink.
/// </summary>
public partial class Ink: ModelElement<DXVO.Ink>
{
  public Ink(): base(){ }
  
  public Ink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Ink(DXVO.Ink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Ink Data
  /// </summary>
  [DataMember]
  public DM.Base64Binary? InkData
  {
    get
    {
      if (_Element?.InkData?.Value != null)
        return Convert.FromBase64String(_ExistingElement.InkData.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.InkData = Convert.ToBase64String(value);
      else
        _ExistingElement.InkData = null;
    }
  }
  
  
  /// <summary>
  ///   Annotation Flag
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AnnotationFlag
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
}
