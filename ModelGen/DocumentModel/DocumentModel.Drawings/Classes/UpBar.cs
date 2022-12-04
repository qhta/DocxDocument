namespace DocumentModel.Drawings;

/// <summary>
/// Defines the UpBar Class.
/// </summary>
public class UpBar: DocumentModel.Drawings.StyleEntry
{
  public override LineReference1? LineReference
  {
    get;
    set;
  }
  
  public override FillReference1? FillReference
  {
    get;
    set;
  }
  
  public override EffectReference1? EffectReference
  {
    get;
    set;
  }
  
  public override FontReference1? FontReference
  {
    get;
    set;
  }
  
  public override ShapeProperties3? ShapeProperties
  {
    get;
    set;
  }
  
  public override TextCharacterPropertiesType1? TextCharacterPropertiesType
  {
    get;
    set;
  }
  
  public override TextBodyProperties? TextBodyProperties
  {
    get;
    set;
  }
  
  public override OfficeArtExtensionList1? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
