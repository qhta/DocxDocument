namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of default paragraph and run properties which shall be applied to every paragraph and run in the current WordprocessingML document. These properties are applied first in the style hierarchy; therefore they are superseded by any further conflicting formatting but apply if no further formatting is present.
/// </summary>
public partial class DocDefaults: ModelElement<DXW.DocDefaults>
{
  public DocDefaults(): base(){ }
  
  public DocDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocDefaults(DXW.DocDefaults openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesDefault? RunPropertiesDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunPropertiesDefault>();
      if (element != null)
        return RunPropertiesDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesDefaultConverter.CreateOpenXmlElement<DXW.RunPropertiesDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Default Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesDefault? ParagraphPropertiesDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ParagraphPropertiesDefault>();
      if (element != null)
        return ParagraphPropertiesDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ParagraphPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesDefaultConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
