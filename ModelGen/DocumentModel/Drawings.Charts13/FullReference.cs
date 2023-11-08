namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FullReference Class.
/// </summary>
public partial class FullReference: ModelElement<DXO13DC.FullReference>
{
  public FullReference(): base(){ }
  
  public FullReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FullReference(DXO13DC.FullReference openXmlElement): base(openXmlElement) { }
  
  
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
