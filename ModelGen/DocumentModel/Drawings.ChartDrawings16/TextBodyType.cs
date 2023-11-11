namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
public partial class TextBodyType: ModelElement<DXO16DCD.TextBodyType>
{
  public TextBodyType(): base(){ }
  
  public TextBodyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBodyType(DXO16DCD.TextBodyType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Body Properties.
  /// </summary>
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BodyProperties,DXD.BodyProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BodyProperties,DXD.BodyProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Text List Styles.
  /// </summary>
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get
    {
      return _Element?.GetObject<DMD.ListStyle,DXD.ListStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ListStyle,DXD.ListStyle>(value);
    }
  }
  
}
