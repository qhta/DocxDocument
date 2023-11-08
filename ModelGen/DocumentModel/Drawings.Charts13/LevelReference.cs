namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LevelReference Class.
/// </summary>
public partial class LevelReference: ModelElement<DXO13DC.LevelReference>
{
  public LevelReference(): base(){ }
  
  public LevelReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelReference(DXO13DC.LevelReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  [DataMember]
  public DMDC13.SequenceOfReferences? SequenceOfReferences
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.SequenceOfReferences>();
      if (element != null)
        return SequenceOfReferencesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SequenceOfReferencesConverter.CreateOpenXmlElement<DXO13DC.SequenceOfReferences>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
