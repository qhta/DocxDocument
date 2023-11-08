namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Text Class.
/// </summary>
public partial class Text: ModelElement<DXO16DCD.Text>
{
  public Text(): base(){ }
  
  public Text(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Text(DXO16DCD.Text openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextData.
  /// </summary>
  [DataMember]
  public DMDCD16.TextData? TextData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.TextData>();
      if (element != null)
        return TextDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.TextData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextDataConverter.CreateOpenXmlElement<DXO16DCD.TextData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   RichTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.RichTextBody? RichTextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.RichTextBody>();
      if (element != null)
        return RichTextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.RichTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RichTextBodyConverter.CreateOpenXmlElement<DXO16DCD.RichTextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
