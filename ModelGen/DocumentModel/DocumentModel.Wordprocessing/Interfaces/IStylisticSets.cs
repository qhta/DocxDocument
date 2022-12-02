namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public interface IStylisticSets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IStyleSet>? StyleSets { get ; set; }
  
}
