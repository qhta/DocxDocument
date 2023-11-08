namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a main document part in a WordprocessingML document.
/// </summary>
public partial class Document: ModelElement<DXW.Document>
{
  public Document(): base(){ }
  
  public Document(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Document(DXW.Document openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  [DataMember]
  public DMW.DocumentBackground? DocumentBackground
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocumentBackground>();
      if (element != null)
        return DocumentBackgroundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocumentBackground>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentBackgroundConverter.CreateOpenXmlElement<DXW.DocumentBackground>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Body.
  /// </summary>
  [DataMember]
  public DMW.Body? Body
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Body>();
      if (element != null)
        return BodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Body>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyConverter.CreateOpenXmlElement<DXW.Body>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
