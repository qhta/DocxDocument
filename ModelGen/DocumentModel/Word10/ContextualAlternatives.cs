namespace DocumentModel.Word10;


/// <summary>
///   This element specifies whether to display the characters using contextual alternates. (For more information about contextual alternates, see OpenType.) By default, text is not displayed using contextual alternates.
/// </summary>
public partial class ContextualAlternatives: ModelElement<DXO10W.ContextualAlternatives>
{
  public ContextualAlternatives(): base(){ }
  
  public ContextualAlternatives(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContextualAlternatives(DXO10W.ContextualAlternatives openXmlElement): base(openXmlElement) { }
  
}
