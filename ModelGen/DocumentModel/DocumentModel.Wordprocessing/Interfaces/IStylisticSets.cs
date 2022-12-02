namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public interface IStylisticSets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IStyleSet>? StyleSets { get ; set; }
  
}
